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
        public SUV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void lbGLCClass_Click(object sender, EventArgs e)
        {
            new GLC_Class().Show();
            this.Hide();
        }

        private void lbGLEClass_Click(object sender, EventArgs e)
        {
            new GLE_Class().Show();
            this.Hide();
        }

        private void lbGLSClass_Click(object sender, EventArgs e)
        {
            new GLS_Class().Show();
            this.Hide();
        }

        private void lbGClass_Click(object sender, EventArgs e)
        {
            new G_Class().Show();
            this.Hide();
        }

        private void lbEQBClass_Click(object sender, EventArgs e)
        {
            new EQB_Class().Show();
            this.Hide();
        }
    }
}
