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
            new GLC_Class(Get_FormName()).Show();
            this.Hide();
        }

        private void lbGLEClass_Click(object sender, EventArgs e)
        {
            new GLE_Class(Get_FormName()).Show();
            this.Hide();
        }

        private void lbGLSClass_Click(object sender, EventArgs e)
        {
            new GLS_Class(Get_FormName()).Show();
            this.Hide();
        }

        private void lbGClass_Click(object sender, EventArgs e)
        {
            new G_Class(Get_FormName()).Show();
            this.Hide();
        }

        private void lbEQBClass_Click(object sender, EventArgs e)
        {
            new EQB_Class(Get_FormName()).Show();
            this.Hide();
        }
    }
}
