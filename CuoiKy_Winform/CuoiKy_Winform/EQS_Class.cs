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
    public partial class EQS_Class : Form
    {
        string pathEQS = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\EQS.jpg";

        string pathEQS_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\EQS.jpg";
        public EQS_Class()
        {
            InitializeComponent();
            EQS.Image = Image.FromFile(pathEQS);

            //EQS.Image = Image.FromFile(pathEQS_hau);
        }

        private void lbEQSClass_Click(object sender, EventArgs e)
        {

        }
    }
}
