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
    public partial class personalInformation : Form
    {
        public personalInformation()
        {
            InitializeComponent();
        }

        private void res(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string output = String.Format("Name:" + FirstName + LastName);
            richTextBox.Text = output;
        }
    }
}
