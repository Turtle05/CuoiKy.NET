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
    public partial class All_CarClass : Form
    {
        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;
        Home frmHome;

        public All_CarClass()
        {
            InitializeComponent();
        }

        public All_CarClass(Home parent, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public All_CarClass(Home parent, string memberid, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            member_id = memberid;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public string Get_FormName()
        {
            return "All_CarClass";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome.Show();
        }

        private void All_CarClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmHome.Show();
        }

        private void lbAClass_Click(object sender, EventArgs e)
        {
            new A_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbCClass_Click(object sender, EventArgs e)
        {
            new C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbEClass_Click(object sender, EventArgs e)
        {
            new E_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbSClass_Click(object sender, EventArgs e)
        {
            new S_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbEQSClass_Click(object sender, EventArgs e)
        {
            new EQS_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbA_Class_Click(object sender, EventArgs e)
        {
            new A_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbC_Class_Click(object sender, EventArgs e)
        {
            new C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbE_Class_Click(object sender, EventArgs e)
        {
            new E_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbS_Class_Click(object sender, EventArgs e)
        {
            new S_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbEQS_Class_Click(object sender, EventArgs e)
        {
            new EQS_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
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

        private void lbEQBClss_Click(object sender, EventArgs e)
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

        private void lbAMGGT_Click(object sender, EventArgs e)
        {
            new AMG_GT_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbAMGC_Click(object sender, EventArgs e)
        {
            new AMG_C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbECoupe_Click(object sender, EventArgs e)
        {
            new E_Coupe_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbCCoupe_Click(object sender, EventArgs e)
        {
            new C_Coupe_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbAMGGT_Class_Click(object sender, EventArgs e)
        {
            new AMG_GT_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbAMGC_Class_Click(object sender, EventArgs e)
        {
            new AMG_C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbE_Coupe_Class_Click(object sender, EventArgs e)
        {
            new E_Coupe_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbC_Coupe_Class_Click(object sender, EventArgs e)
        {
            new C_Coupe_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }
    }
}
