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
            panel1.Visible = false;
            panel2.Visible = false;
        }
    }
}
