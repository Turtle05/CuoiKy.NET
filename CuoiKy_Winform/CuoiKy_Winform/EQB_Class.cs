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
    public partial class EQB_Class : Form
    {
        string pathEQB = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\EQB.jpg";

        string pathEQB_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\EQB.jpg";
        public EQB_Class()
        {
            InitializeComponent();
            // EQB.Image = Image.FromFile(pathEQB);

            EQB.Image = Image.FromFile(pathEQB_hau);
        }

        private void lbEQBClass_Click(object sender, EventArgs e)
        {

        }
    }
}
