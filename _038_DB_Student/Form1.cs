using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace _38_DB_Student
{
    public partial class Form1 : Form
    {
        // localhost == 127.0.0.1
        // 외부서버접속시 해당 Host IP
        string connInfo = "Server=localhost;database=Test_DB;uid=Test_Login;pwd=p1234";
        SqlConnection conn = null;  // SQL-Server 연결 객체

        public Form1()
        {
            InitializeComponent();
        }

        void enableConnectButton(bool isConn)
        {
            if (isConn)
            {
                btn_DBConnect.Enabled = false;
                btn_DBDisconnect.Enabled = true;
                btn_Select.Enabled = true;

                btn_Delete.Enabled = true;
            }
            else
            {
                btn_DBConnect.Enabled = true;
                btn_DBDisconnect.Enabled = false;
                btn_Select.Enabled = false;

                btn_Delete.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enableConnectButton(false);
        }

        void addLogListBox(string log)
        {
            lb_Log.Items.Add(log);
            lb_Log.SelectedIndex = lb_Log.Items.Count - 1;
        }

        private void btn_DBConnect_Click(object sender, EventArgs e)
        {
            this.conn = new SqlConnection(this.connInfo);
            try
            {
                this.conn.Open();   // SQL-Server에 접속연결
                if(this.conn.State == ConnectionState.Open)
                {
                    addLogListBox("SQL-Server 연결 성공~");
                    enableConnectButton(true);
                }
                else
                {
                    addLogListBox("연결상태 : " + this.conn.State.ToString());
                }
            }
            catch (Exception ex)
            {
                addLogListBox("Exception : " + ex.Message);
                if (this.conn != null &&
                    this.conn.State == ConnectionState.Open ||
                    this.conn.State == ConnectionState.Connecting)
                    this.conn.Close();
                this.conn = null;
                return;
            }
        }

        private void btn_DBDisconnect_Click(object sender, EventArgs e)
        {
            if(this.conn != null &&
                this.conn.State == ConnectionState.Open ||
                this.conn.State == ConnectionState.Connecting)
            {
                this.conn.Close();
                this.conn = null;
                addLogListBox("SQL-Server 연결 해제~");
                enableConnectButton(false);
            }            
        }

        void runSelectCmd()
        {
            addLogListBox("SELECT문 실행");
            lv_table.Items.Clear(); // ListView 내용 전체 삭제

            try
            {
                SqlCommand cmd = new SqlCommand();// SQL문 실행 객체
                cmd.Connection = this.conn; // 연결객체 가져오기
                cmd.CommandText = "SELECT * FROM dbo.Student";

                // 실행 후 결과정보를 받는다
                // reader 객체에 결과정보가 담긴다
                SqlDataReader reader = cmd.ExecuteReader();
                /*
                reader내부의 커서(테이블의 행을 가리키는 위치 정보)는
                첫번째 행 이전을 가리키고 있다.
                reader.Read()가 호출되면 2가지 일을 하게 된다
                1) 다음 행에 읽을 데이터가 존재하면 true를 리턴한다
                2) 동시에 커서의 위치를 읽어야 할 다음 행으로 이동한다

                테이블의 모든 행을 읽었다면, 더 이상 읽어야 할 행이
                존재하지 않으므로 reader.Read()는 false를 리턴하게 되고
                이 때 while문을 빠져나가게 된다.
                */
                while (reader.Read())
                {
                    // 한 행의 컬럼(데이터) 개수만큼 객체 생성
                    string[] datas = new string[reader.FieldCount];
                    // 한 행의 데이터를 순서대로 배열에 담는다.
                    for (int i = 0; i < datas.Length; i++)
                        datas[i] = reader.GetValue(i).ToString();

                    // ListView에 보여준다
                    lv_table.Items.Add(new ListViewItem(datas));
                }

                reader.Close(); // 닫는다
                cmd.Dispose();  // 리소스 메모리 해제

            }
            catch (Exception ex)
            {
                addLogListBox("Exception : " + ex.Message);
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            runSelectCmd();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            addLogListBox("DELETE 문 실행~");

            int idx = lv_table.FocusedItem.Index;
            string strCnt = lv_table.Items[idx].SubItems[0].Text;

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = this.conn;
                    cmd.CommandText = "DELETE FROM dbo.Student WHERE cnt=@번호";
                    cmd.Parameters.AddWithValue("@번호", strCnt);
                    int cnt = cmd.ExecuteNonQuery();
                    addLogListBox(cnt + "행이 처리되었습니다~");

                    runSelectCmd();
                }

            }
            catch (Exception ex)
            {
                addLogListBox("Exception : " + ex.Message);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            addLogListBox("INSERT 문 실행~");

            try
            {
                /*
                .NET의 클래스는 IDispose 인터페이스를 상속해서
                Dispose() 추상 메서드를 구현하는데 이 메서드 내부에
                리소스 메모리 해제 기능을 구현해놓는다.
                .NET의 클래스 객체의 메모리 해제는 
                GC(Garbage Collector)에 의해 관리되어 해제되므로
                우리는 소멸자의 호출시점을 예측할 수 없다.
                그러므로 소멸자를 대신해서 Dispose()를 호출하여
                메모리를 절약한다
                */
                //using 구문이 끝날 때 자동으로 Dispose()가 호출된다
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = this.conn;
                    cmd.CommandText = "INSERT INTO dbo.Student" + "\r\n"
                                    + "VALUES(@이름, @나이, @성적)";
                    cmd.Parameters.AddWithValue("@이름", this.tb_Name.Text);
                    cmd.Parameters.AddWithValue("@나이", this.tb_Age.Text);
                    cmd.Parameters.AddWithValue("@성적", this.tb_Score.Text);
                    int cnt = cmd.ExecuteNonQuery();
                    addLogListBox(cnt + "행이 처리되었습니다~");

                    runSelectCmd();
                }

            }catch(Exception ex)
            {
                addLogListBox("Exception : " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            addLogListBox("UPDATE 문 실행~");

            int idx = lv_table.FocusedItem.Index;
            string strCnt = lv_table.Items[idx].SubItems[0].Text;

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = this.conn;
                    cmd.CommandText = "UPDATE dbo.Student SET name=@이름,"
                               + "\r\n" + "age=@나이, score=@성적"
                               + "\r\n" + "WHERE cnt=@번호";
                    cmd.Parameters.AddWithValue("@이름", this.tb_Name.Text);
                    cmd.Parameters.AddWithValue("@나이", this.tb_Age.Text);
                    cmd.Parameters.AddWithValue("@성적", this.tb_Score.Text);
                    cmd.Parameters.AddWithValue("@번호", strCnt);
                    int cnt = cmd.ExecuteNonQuery();
                    addLogListBox(cnt + "행이 처리되었습니다~");

                    runSelectCmd();
                }
            }
            catch (Exception ex)
            {
                addLogListBox("Exception : " + ex.Message);
            }
        }

        private void lv_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            int idx = lv.FocusedItem.Index;   // 행위치
            string name = lv.Items[idx].SubItems[1].Text;
            string age = lv.Items[idx].SubItems[2].Text;
            string score = lv.Items[idx].SubItems[3].Text;
            this.tb_Name.Text = name;
            this.tb_Age.Text = age;
            this.tb_Score.Text = score;
        }
    }
}
