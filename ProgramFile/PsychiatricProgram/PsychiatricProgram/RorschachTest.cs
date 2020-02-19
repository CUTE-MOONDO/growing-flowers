using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PsychiatricProgram
{
    public partial class RorschachTest : Form
    {
        MainForm mf;
        public RorschachTest(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            init();
        }

        void init()
        { 
            //아이콘을 resources에 담아둔 icon파일로 설정한다.
            this.Icon = Properties.Resources.MainIcon;
        }

        private void RorschachTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.Form_OnClose();
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //과거 이력 저장
            mf.user.setUserpast(when_textBox.Text, content_textBox.Text);

            //패널 숨기기
            panel1.Visible = false;
            panel2.Visible = false;
        }
    }
}
