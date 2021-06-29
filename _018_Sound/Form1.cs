using MediaPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_Sound
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        double addOpa = -0.01;

        MediaPlayerClass mp3Player = new MediaPlayerClass();
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += this.addOpa;

            if (this.Opacity <= 0.0D || this.Opacity >= 1.0D)
                this.addOpa = -this.addOpa; // this.addOpa *= -1;
        }


        private void btnOpacity_Click(object sender, EventArgs e)
        {

            if (timer.Enabled)
            {
                timer.Stop();
                this.Opacity = 1.0D;
            }
            else
                timer.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
                        SoundPlayer sp = new SoundPlayer();
            // 상대 경로 얻기 
            sp.SoundLocation = "../../../NameDiallerStartTone.wav";
            sp.Play();

            System.Threading.Thread.Sleep(1000);

            mp3Player.EnableContextMenu = true;
            // 절대 경로 얻기
            // \n, \b, \t, 역슬래시(\)는 뒤의 문자와 결합하는 특수문자

            // [방법 1]
            //mp3Player.FileName = "D:\\_01_CSharp\\lec\\_04_WinForm\\lec\\WinFormApplications\\_018_Sound\\비상.mp3";

            // [방법 2]
            mp3Player.FileName = @"D:\_01_CSharp\lec\_04_WinForm\lec\WinFormApplications\_018_Sound\비상.mp3";

            // [방법 3]
            //String path = Directory.GetCurrentDirectory(); // 실행파일 경로
            //String path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //mp3Player.FileName = path + @"\지난날.mp3";

            // [방법 4] 파일 선택하기
            /*OpenFileDialog opd = new OpenFileDialog();
            opd.ShowDialog();
            string fileName = opd.FileName;
            mp3Player.FileName = fileName;
            mp3Player.Play();*/
            
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            Image image = Properties.Resources.play;
            this.btnPlay.BackgroundImage = image;
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            Image image = Properties.Resources.playing;
            this.btnPlay.BackgroundImage = image;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            Image image = Properties.Resources.musicplay;
            this.btnPlay.BackgroundImage = image;
        }
    }
}
