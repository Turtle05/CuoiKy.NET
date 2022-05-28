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
    public partial class A_Class : Form
    {
        static string frmStatus = "Active";
        string pathA200 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A200.jpg";
        string pathA220 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A220.jpg";
        string pathA45 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A45.jpg";

        string pathA200_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A200.jpg";
        string pathA220_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A220.jpg";
        string pathA45_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\A45.jpg";
        public A_Class()
        {
            InitializeComponent();
           // A200.Image = Image.FromFile(pathA200);
           //A220.Image = Image.FromFile(pathA220);
           // A45.Image = Image.FromFile(pathA45);

            A200.Image = Image.FromFile(pathA200_hau);
            A220.Image = Image.FromFile(pathA220_hau);
            A45.Image = Image.FromFile(pathA45_hau);
        }

        private void A200_Click(object sender, EventArgs e)
        {
            frmStatus = "Hidden";
            new Booking().Show();
        }

        private void rtxtA220_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtA200_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
