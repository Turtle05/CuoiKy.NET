using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_Winform
{
    public partial class Form_UserInfo : Form
    {
        public Form_UserInfo()
        {
            InitializeComponent();
            setLabel();
        }

        private void setLabel()
        {
            
        }

        // BOTTON EDITINFORMATION 
        private void btEditInfo_Click(object sender, EventArgs e)
        {
            new Form_EditInfo().Show();
        }

        // BOTTON CHANGEPASSWORD
        private void btChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
