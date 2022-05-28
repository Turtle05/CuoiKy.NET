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
    public partial class C_Class : Form
    {
        string pathC200 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200.jpg";
        string pathC300 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300.jpg";
        string pathC43 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C43.jpg";

        string pathC200_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200.jpg";
        string pathC300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300.jpg";
        string pathC43_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C43.jpg";
        public C_Class()
        {
            InitializeComponent();
            //C200.Image = Image.FromFile(pathC200);
            //C300.Image = Image.FromFile(pathC300);
            //C43.Image = Image.FromFile(pathC43);

            C200.Image = Image.FromFile(pathC200_hau);
            C300.Image = Image.FromFile(pathC300_hau);
            C43.Image = Image.FromFile(pathC43_hau);
        }

        private void lbCClass_Click(object sender, EventArgs e)
        {

        }

        private void C_Class_Load(object sender, EventArgs e)
        {

        }

      

        
    }
}
