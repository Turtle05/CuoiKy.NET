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
        public Sedan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void lbAClass_Click(object sender, EventArgs e)
        {
            new A_Class().Show();
            this.Hide();
        }

        private void lbCClass_Click(object sender, EventArgs e)
        {
            new C_Class().Show();
            this.Hide();
        }

        private void lbEClass_Click(object sender, EventArgs e)
        {
            new E_Class().Show();
            this.Hide();
        }

        private void lbSClass_Click(object sender, EventArgs e)
        {
            new S_Class().Show();
            this.Hide();
        }

        private void lbEQSClass_Click(object sender, EventArgs e)
        {
            new EQS_Class().Show();
            this.Hide();
        }
    }
}
