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
    public partial class Profile : Form
    {
        string member_id;
        string member_name;
        Home frmHome;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(Home parent, string memberid, string membername)
        {
            InitializeComponent();

            frmHome = parent;
            member_id = memberid;
            member_name = membername;
            lbMemberName.Text = member_name;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            new ChangePass(this, member_id).Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmHome.Show();
            this.Hide();
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome.Show();
            this.Hide();
        }
    }
}
