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
    public partial class Sedan : Form
    {
        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();

        Home frmHome;

        public Sedan()
        {
            InitializeComponent();
        }

        public Sedan(Home parent, List<string> carname, List<string> carpath)
        {
            InitializeComponent();

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public string Get_FormName()
        {
            return "Sedan";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome.Show();
        }

        private void lbAClass_Click(object sender, EventArgs e)
        {
            new A_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbCClass_Click(object sender, EventArgs e)
        {
            new C_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbEClass_Click(object sender, EventArgs e)
        {
            new E_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbSClass_Click(object sender, EventArgs e)
        {
            new S_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbEQSClass_Click(object sender, EventArgs e)
        {
            new EQS_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }
    }
}
