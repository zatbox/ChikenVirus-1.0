using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VIrus01_꼬꼬댁_바이러스
{
    public partial class Form1 : Form
    {
        string tempPath = Path.Combine(Path.GetTempPath());
        Point cursor_point = new Point(0,0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Position = cursor_point;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("진짜 바이러스에 감염됩니다. ㅋㅋㅋㅋㅋㅋ");
            MainVirus mv = new MainVirus();
            this.Visible = false;
            mv.Show();
        }
    }
}
