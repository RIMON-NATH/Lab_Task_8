using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Task_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bitClick(object sender, EventArgs e)
        {
            string username = userName.Text;
            string Password = password.Text;
            if (username=="18-38929-3"& Password=="rimon")
            {
                new userInfo().Show();
            }
            else
            {
                MessageBox.Show("Invalid user name or password", "Login Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
