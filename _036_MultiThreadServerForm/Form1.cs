using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_MultiThreadServerForm
{
    public partial class Form1 : Form
    {
        Socket acceptSocket; // VIPS의 입구에 있는 안내 직원
        IPEndPoint ipep;     // 서버의 주소를 담는 객체

        Thread tAccept;     // 클라이언트 접속허용 스레드 객체
        bool isAccept;      // 스레드가 접속허용 가능여부

        // clientList를 1개의 스레드만 접근하도록
        // 동기화 하기 위한 키락
        object keyObj = new object();
        // 접속 연결된 클라이언트들을 저장하는 리스트 저장소
        List<Socket> clientList = new List<Socket>();

        // addLogListBox 메서드를 저장하는 델리게이트 선언
        delegate void AddMsgLog(string log);
        AddMsgLog addMsgLog = null;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                /*
                접속허용소켓을 닫으면 
                ThreadAccept에서 예외가 발생하고
                while 루프를 빠져나오게 된다
                ThreadAccept 담당 스레드가 종료된다.
                */
                this.isAccept = false;
                this.acceptSocket.Close();

                // 모든 클라이언트와의 연결을 종료
                closeAllClient();
            }
            catch (Exception ex)
            {
                addLogListBox("Exception: " + ex.Message);
            }

            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // addLogListBox 메서드를 델리게이트 변수에 담는다
            this.addMsgLog = this.addLogListBox;

            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.acceptSocket =
                new Socket(AddressFamily.InterNetwork,
                           SocketType.Stream,
                           ProtocolType.Tcp);
            int port = Int32.Parse(tb_Port.Text);
            this.ipep = 
                new IPEndPoint(IPAddress.Any, port);
            this.acceptSocket.Bind(this.ipep); // 소켓에 주소 부여
            this.acceptSocket.Listen(100);      // 소켓 대기 큐
            addLogListBox("서버 시작");

            // 클라이언트의 Connect를 Accept할 역할을
            // 담당한 스레드를 생성한다
            this.isAccept = true;
            tAccept = new Thread(new ThreadStart(ThreadAccept));
            tAccept.Start();

            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                접속허용소켓을 닫으면 
                ThreadAccept에서 예외가 발생하고
                while 루프를 빠져나오게 된다
                ThreadAccept 담당 스레드가 종료된다.
                */
                this.isAccept = false;
                this.acceptSocket.Close();

                // 모든 클라이언트와의 연결을 종료
                closeAllClient();
            }catch(Exception ex)
            {
                addLogListBox("Exception: " + ex.Message);
            }

            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        void closeAllClient()
        {
            lock (this.keyObj)
            {
                foreach(Socket clientSocket in clientList)
                {
                    // 클라이언트와의 연결을 끊고,
                    // ThreadRecv에서 sr.ReadLine()에서 
                    // 대기중이다가 예외가 발생해서
                    // ThreadRecv를 담당하는 스레드가
                    // 종료되게 된다.
                    clientSocket.Close();
                }
            }
        }

        /// <summary>
        /// 클라이언트의 Connect 시도를 허용하는 스레드
        /// </summary>
        void ThreadAccept()
        {
            while (this.isAccept)
            {
                try
                {
                    // VIPS에서 입구 안내직원이 고객한테 다른 직원과
                    // 연결시켜주는 것과 같다
                    // 실제 Client와 통신하는 것은 clientSocket이다.
                    addLogListBox("서버 접속 대기중...");
                    Socket clientSocket = this.acceptSocket.Accept();

                    // 현재 스레드가 클라이언트를 추가중 일 때는
                    // 다른 스레드는 해당 lock입구에서 대기하게 한다
                    lock (this.keyObj)
                    {
                        this.clientList.Add(clientSocket);
                    }
                    addLogListBox("클라이언트 접속 성공");

                    // 해당 클라이언트와 송/수신을 담당할 스레드 생성
                    Thread tRecv =
                        new Thread(new ParameterizedThreadStart(ThreadRecv));
                    tRecv.Start(clientSocket);
                }
                catch (Exception e)
                {
                    addLogListBox("Exception:" + e.Message);
                }
            }

            addLogListBox("ThreadAccept 종료~");
        }

        void ThreadRecv(object sock)
        {
            addLogListBox("클라이언트 담당 스레드 시작!");
            Socket clientSocket = sock as Socket;

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamReader sr = new StreamReader(ns);

            while (true)
            {
                try
                {
                    // 클라이언트로부터 수신 대기위해 멈춰있다가
                    // 데이터가 들어오면 리턴하여 data에 저장
                    string data = sr.ReadLine();
                    addLogListBox("수신: " + data);
                    // clientSocket을 제외한 전체 클라이언트 한테 전송
                    //sendAllData(data, clientSocket);
                    sendAllData(data);  // 모두 전송
                }catch(Exception e)
                {
                    addLogListBox("Exception: " + e.Message);
                    closeClient(clientSocket);
                    break;
                }
            }

            addLogListBox("ThreadRecv 종료~");
        }

        /// <summary>
        /// 해당 클라이언트를 종료하고 리스트에서 제거
        /// </summary>
        /// <param name="clientSocket"></param>
        void closeClient(Socket clientSocket)
        {
            lock (this.keyObj)
            {
                foreach(Socket socket in clientList)
                {
                    if(socket == clientSocket)
                    {
                        socket.Close();
                        clientList.Remove(socket);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 접속한 모든 클라이언트한테 데이터를 전송하는 메서드
        /// </summary>
        /// <param name="data">전송할 데이터</param>
        /// <param name="exceptSocket">전송 제외할 소켓
        ///                       null이면 전송 제외할 소켓 없음
        /// </param>
        void sendAllData(string data, Socket exceptSocket = null)
        {
            /*
            ThreadAccept와 ThreadRecv에서 동시에 접근할 위험을
            방지하기 위해 키락을 걸어준다
            어느 스레드가 점유할 때 다른 스레드는 lock의 입구에서
            진입 대기한다
            */
            lock (this.keyObj)
            {
                /*
                clientList에 등록된 모든 클라이언트에 전송한다
                단 exceptSocket은 제외하고
                */
                foreach (Socket clientSocket in clientList)
                {
                    if (clientSocket != exceptSocket)
                    {
                        NetworkStream ns = new NetworkStream(clientSocket);
                        StreamWriter sw = new StreamWriter(ns);
                        sw.WriteLine(data);
                        sw.Flush(); // 버퍼의 데이터를 즉시 전송하라
                    }
                }
            }
        }

        void addLogListBox(string log)
        {
            /*
            윈폼에서 main 스레드가 아닌 특정 스레드에서
            UI를 접근할 때 종종 오류가 발생한다.
            이것을 방지하기 위해 직접 접근이 어려울 때는
            델리게이트를 이용해서 간접적으로 메서드를 호출해야 한다
            */
            if (this.lb_Log.InvokeRequired)
            {
                /*
                addMsgLog에 저장된 메서드에 log 매개변수를 
                전달하여 호출한다
                */
                Invoke(this.addMsgLog, new object[] { log });
            }
            else
            {
                this.lb_Log.Items.Add(log);  // 리스트 박스에 추가
                // 로그가 많이 쌓일 때 자동으로 스크롤 하기 위해 추가
                this.lb_Log.SelectedIndex =
                    this.lb_Log.Items.Count - 1;
            }
        }
    }
}
