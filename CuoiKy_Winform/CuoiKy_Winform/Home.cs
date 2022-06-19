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
    public partial class Home : Form
    {
        public List<string> carName = new List<string>();
        public List<string> carPath = new List<string>();

        public Home()
        {
            InitializeComponent();
        }

        public string Get_FormName()
        {
            return "Home";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            new All_CarClass(carName, carPath).Show();
        }

        private void btnSedan_Click(object sender, EventArgs e)
        {
            new Sedan(this, carName, carPath).Show();
            this.Hide();
        }

        private void btnSUV_Click(object sender, EventArgs e)
        {
            new SUV(this, carName, carPath).Show();
            this.Hide();
        }

        private void btnCoupe_Click(object sender, EventArgs e)
        {
            new Coupe(this, carName, carPath).Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void lbGLCClass_Click(object sender, EventArgs e)
        {
            new GLC_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGLEClass_Click(object sender, EventArgs e)
        {
            new GLE_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGLSClass_Click(object sender, EventArgs e)
        {
            new GLS_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbAMGGT_Click(object sender, EventArgs e)
        {
            new AMG_GT_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbAMGC_Click(object sender, EventArgs e)
        {
            new AMG_C_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbECoupe_Click(object sender, EventArgs e)
        {
            new E_Coupe_Class(this, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbMoreSedan_Click(object sender, EventArgs e)
        {
            new Sedan(this, carName, carPath).Show();
            this.Hide();
        }

        private void lbMoreSUV_Click(object sender, EventArgs e)
        {
            new SUV(this, carName, carPath).Show();
            this.Hide();
        }

        private void lbMoreCoupe_Click(object sender, EventArgs e)
        {
            new Coupe(this, carName, carPath).Show();
            this.Hide();
        }
    }
}
