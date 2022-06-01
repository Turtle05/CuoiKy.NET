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
    public partial class E_Class : Form
    {
        string pathE200 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E200.jpg";
        string pathE300 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E300.jpg";
        string pathE350 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E350.jpg";
        string pathE43 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E43.jpg";

        string pathE200_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E200.jpg";
        string pathE300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E300.jpg";
        string pathE350_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E350.jpg";
        string pathE43_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E43.jpg";
        public E_Class()
        {
            InitializeComponent();
            E200.Image = Image.FromFile(pathE200);
            E300.Image = Image.FromFile(pathE300);
            E350.Image = Image.FromFile(pathE350);
            E43.Image = Image.FromFile(pathE43);

            //E200.Image = Image.FromFile(pathE200_hau);
            //E300.Image = Image.FromFile(pathE300_hau);
            //E350.Image = Image.FromFile(pathE350_hau);
            //E43.Image = Image.FromFile(pathE43_hau);
        }

        private void lbEClass_Click(object sender, EventArgs e)
        {

        }
    }
}
