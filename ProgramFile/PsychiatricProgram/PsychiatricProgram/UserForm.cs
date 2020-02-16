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
            nextForm(sender, e);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            //아이콘을 resources에 담아둔 icon파일로 설정한다
            this.Icon = Properties.Resources.MainIcon;

            //MaskTextBox 컨트롤을 맨 앞으로 보낸다
            userAge.BringToFront();
        }

        private void userAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EnterKey눌렀을 때
            if (e.KeyChar == (char)Keys.Enter)
            {
                nextForm(sender, e);
            };
        }

        private void nextForm(object sender, EventArgs e)
        {
            if (userName.Text != "" && userAge.Text != "")
            {
                //현재 Form 을 hide하고 다음 Form show
                this.Visible = false;
                MainForm fm1 = new MainForm(this);
                fm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("이름과 나이를 모두 입력하여 주세요", "비어있음", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userName.Focus();
            }
        }
    }
}
