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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //현재 Form 을 hide하고 다음 Form show
            this.Visible = false;
            Form1 fm1 = new Form1(this);
            fm1.ShowDialog();


        }
        public void form_OnClose()
        {
            //다른 Form이 종료됐을 때 현재 Form Visivle = true
            this.Visible = true;

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //아이콘을 resources에 담아둔 icon파일로 설정한다.
            this.Icon = Properties.Resources.MainIcon;
        }
    }
}
