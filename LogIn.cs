using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VingereEncDec
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (((txtUser.Text == "admin") || (txtUser.Text == "ADMIN")) && txtPassword.Text == "admin")
            {
            new Aplikacioni().Show();
            this.Hide();
            }
            else
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Ju Lutem Mbusheni Hapsirat e Zbrazeta!");
            }
            else
                if ((txtUser.Text != "ADMIN") || (txtUser.Text != "admin"))
            {
                MessageBox.Show("Keni Shtypur User-in gabim");
            }
            else
            if (txtPassword.Text != "admin")
            {
                MessageBox.Show("Keni Shtypur Fjalkalim-in gabim");
            }
        }
    }
}
