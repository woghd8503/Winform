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

namespace _37_MultiThreadClientForm
{
    public partial class Form1 : Form
    {
        Socket clientSocket;
        IPEndPoint ipep;

        Thread tRecv;
        bool isRecv;

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
                this.isRecv = false;
                // 클라이언트 소켓 객체가 존재하고, 연결되어있다면
                if(this.clientSocket != null &&
                    this.clientSocket.Connected)
                {
                    this.clientSocket.Close();
                }
            }catch(Exception ex)
            {
                addLogListBox("Exception: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.addMsgLog = this.addLogListBox;

            this.btnConnect.Enabled = true;
            this.btnDisconnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // 소켓 생성(휴대폰 구매)
            this.clientSocket =
                new Socket(AddressFamily.InterNetwork,
                           SocketType.Stream,
                           ProtocolType.Tcp);
            string ip = this.tb_IP.Text;
            int port = Int32.Parse(this.tb_Port.Text);
            this.ipep =
                new IPEndPoint(IPAddress.Parse(ip), port);

            addLogListBox("서버 접속 시도");
            this.clientSocket.Connect(this.ipep);
            addLogListBox("서버 접속 완료");

            // 서버와 송/수신 스레드 생성
            this.isRecv = true;
            tRecv = new Thread(new ThreadStart(ThreadRecv));
            tRecv.Start();

            this.btnConnect.Enabled = false;
            this.btnDisconnect.Enabled = true;
        }

        void ThreadRecv()
        {
            NetworkStream ns =
                new NetworkStream(this.clientSocket);
            StreamReader sr = new StreamReader(ns);

            while (this.isRecv)
            {
                try
                {
                    string data = sr.ReadLine();
                    addLogListBox("수신: " + data);
                }catch(Exception e)
                {
                    addLogListBox("Exception: " + e.Message);
                    this.isRecv = false;
                    this.clientSocket = null;
                }
            }
            addLogListBox("서버 접속 종료~");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.isRecv = false;
                // 클라이언트 소켓 객체가 존재하고, 연결되어있다면
                if (this.clientSocket != null &&
                    this.clientSocket.Connected)
                {
                    this.clientSocket.Close();
                }
            }
            catch (Exception ex)
            {
                addLogListBox("Exception: " + ex.Message);
            }

            this.btnConnect.Enabled = true;
            this.btnDisconnect.Enabled = false;
        }

        void addLogListBox(string log)
        {
            if (lb_Log.InvokeRequired)
            {
                Invoke(addMsgLog, new object[] { log });
            }
            else
            {
                lb_Log.Items.Add(log);
                lb_Log.SelectedIndex = lb_Log.Items.Count - 1;
            }
        }

        private void tb_SendData_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.clientSocket != null &&
                this.clientSocket.Connected)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        string data = tb_SendData.Text;
                        NetworkStream ns =
                            new NetworkStream(this.clientSocket);
                        StreamWriter sw = new StreamWriter(ns);
                        sw.WriteLine(data);
                        sw.Flush();
                        addLogListBox("송신 : " + data);
                        break;
                }
            }
            else
            {
                this.tb_SendData.Text = "";
            }
        }
    }
}
