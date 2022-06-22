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
    public partial class SUV : Form
    {
        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;

        Home frmHome;

        public SUV()
        {
            InitializeComponent();
        }

        public SUV(Home parent, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public SUV(Home parent, string memberid, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            member_id = memberid;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public string Get_FormName()
        {
            return "SUV";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome.Show();
        }

        private void lbGLCClass_Click(object sender, EventArgs e)
        {
            new GLC_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGLEClass_Click(object sender, EventArgs e)
        {
            new GLE_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGLSClass_Click(object sender, EventArgs e)
        {
            new GLS_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGClass_Click(object sender, EventArgs e)
        {
            new G_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbEQBClass_Click(object sender, EventArgs e)
        {
            new EQB_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbGLC_Class_Click(object sender, EventArgs e)
        {
            new GLC_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbGLE_Class_Click(object sender, EventArgs e)
        {
            new GLE_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbGLS_Class_Click(object sender, EventArgs e)
        {
            new GLS_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbG_Class_Click(object sender, EventArgs e)
        {
            new G_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbEQB_Class_Click(object sender, EventArgs e)
        {
            new EQB_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }
    }
}
