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
    public partial class Coupe : Form
    {
        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;

        Home frmHome;

        public Coupe()
        {
            InitializeComponent();
        }

        public Coupe(Home parent, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public Coupe(Home parent, string memberid, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            member_id = memberid;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public string Get_FormName()
        {
            return "Coupe";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome.Show();
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
