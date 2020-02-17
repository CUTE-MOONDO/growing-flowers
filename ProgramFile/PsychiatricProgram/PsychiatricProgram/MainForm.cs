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
    public partial class MainForm : Form
    {
        UserForm uf;
        User user;
        public MainForm(UserForm uf)
        {
            InitializeComponent();
            this.uf = uf;
            Init();
        }

        public void Init()
        {
            //User class 생성후 정보 가져오기
            user = new User(uf.userName.Text, Int32.Parse(uf.userAge.Text));

            userName_label.Text = user.getUserName();
            userAge_label.Text = "" + user.getUserAge();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //아이콘을 resources에 담아둔 icon파일로 설정한다.
            this.Icon = Properties.Resources.MainIcon;
        }

        public void Form_OnClose()
        {
            //다른 Form이 종료됐을 때 현재 Form Visivle = true
            this.Visible = true;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            uf.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            RorschachTest rt = new RorschachTest(this);
            rt.ShowDialog();
        }
    }
}
