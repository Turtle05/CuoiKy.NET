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
    public partial class GLC_Class : Form
    {
        string pathGLC300 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC300.jpg";
        string pathGLC350 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC350.jpg";
        string pathGLC400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC400.jpg";

        string pathGLC300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC300.jpg";
        string pathGLC350_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC350.jpg";
        string pathGLC400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC400.jpg";
        public GLC_Class()
        {
            InitializeComponent();
            GLC300.Image = Image.FromFile(pathGLC300);
            GLC350.Image = Image.FromFile(pathGLC350);
            GLC400.Image = Image.FromFile(pathGLC400);

            //GLC300.Image = Image.FromFile(pathGLC300_hau);
            //GLC350.Image = Image.FromFile(pathGLC350_hau);
            //GLC400.Image = Image.FromFile(pathGLC400_hau);
        }
    }
}
