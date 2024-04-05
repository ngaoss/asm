using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string username = "long";
        string password = "1234";

        bool Check(string username, string password)
        {
            if (username == this.username && password == this.password)
            {
                return true;
            }

            return false;

        }

        private void buttonLogin(object sender, EventArgs e)
        {
            if (Check(textBox1.Text, textBox2.Text))
            {
                ShowInformation login = new ShowInformation();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
