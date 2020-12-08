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
    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }
         
        private void userInfo_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void addUser(object sender, EventArgs e)
        {
            new personalInformation().Show();
        }
    }
}
