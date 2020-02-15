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
    public partial class Form1 : Form
    {
        UserForm uf;
        
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(UserForm uf)
        {
            InitializeComponent();
            this.uf = uf;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            uf.form_OnClose();
        }
    }
}
