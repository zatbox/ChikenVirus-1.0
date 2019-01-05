using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIrus01_꼬꼬댁_바이러스
{
    public partial class MainVirus : Form
    {
        int a = 0;
        Random rd = new Random();
        Point formPoint = new Point();
        Point cursorPoint = new Point();

        public MainVirus()
        {
            InitializeComponent();
        }

        private void MainVirus_Load(object sender, EventArgs e)
        {
            // 바이러스 설정
            this.ShowInTaskbar = false;
            // 폼 숨기기
            this.Visible = false;


            // 여기는 옛날에 있던 부분입니다.

            // FormPoint의 X와 Y 수정
            //formPoint.X = rd.Next(0, 256);
            //formPoint.Y = rd.Next(0, 256);

            // 폼의 위치를 FormPoint로 수정
            //this.Location = formPoint;

            try
            {
                CursorEffect.StartInfo.UseShellExecute = false;
                CursorEffect.StartInfo.FileName = "C:\\Windows\\System32\\notepad.exe";
                CursorEffect.StartInfo.CreateNoWindow = true;
                CursorEffect.Start();
            }
            catch
            {
                Console.WriteLine("hello");
            }
            
            SendKeys.Send("당신의 컴퓨터는 꼬꼬댁바이러스에 감염되었습니다!");
            SendKeys.Send("{ENTER}");
            SendKeys.Send("이제 꼬꼬댁을 즐기세요!!!");
            SendKeys.Send("{ENTER}");
            SendKeys.Send("{ENTER}");
            SendKeys.Send("Created By Redwiki YT ! ! !");
            CursorEffectTimer.Start();
        }

        private void CursorEffectTimer_Tick(object sender, EventArgs e)
        {
            cursorPoint.X = rd.Next(0, 4090);
            cursorPoint.Y = rd.Next(0, 1080);
            Cursor.Position = cursorPoint;
        }

        private void msgTimer_Tick(object sender, EventArgs e)
        {
            a = rd.Next(1, 5);
            if (a == 1)
            {
                MessageBox.Show("꼬꼬댁", "CH.EXE" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (a == 2)
            {
                MessageBox.Show("댁꼬", "Microsoft Windows", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (a == 3)
            {
                MessageBox.Show("꼬꼬댁", "devenv.exe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (a == 4)
            {
                MessageBox.Show("댁꼬꼬", "???", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (a == 5)
            {
                MessageBox.Show("꼬꼬댁?", "IDKJVLSKDFJW", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            }
        }
    }
}
