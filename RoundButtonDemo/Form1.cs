using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Control ActiveControl;
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            SendKeys.Send(btn.Text);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void button_WOC12_Click(object sender, EventArgs e)
        {
            txtPassword.Text = ""; // txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_Dashboard fd = new Form_Dashboard())
            {
                fd.ShowDialog();
            }
        }
    }
}
