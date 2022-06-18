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
            new AMG_GT_Class(Get_FormName()).Show();
            this.Hide();
        }

        private void lbAMGC_Click(object sender, EventArgs e)
        {
            //new AMG_C_Class(Get_FormName(), carName, carPath).Show();
            //this.Hide();
        }

        private void lbECoupe_Click(object sender, EventArgs e)
        {
            new E_Coupe_Class(Get_FormName()).Show();
            this.Hide();
        }

        private void lbCCoupe_Click(object sender, EventArgs e)
        {
            new C_Coupe_Class(Get_FormName()).Show();
            this.Hide();
        }
    }
}
