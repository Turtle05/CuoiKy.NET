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
    public partial class GLS_Class : Form
    {
        string pathGLS400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS400.jpeg";
        string pathGLS500 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS500.jpg";


        string pathGLS400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS400.jpeg";
        string pathGLS500_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS500.jpg";

        public GLS_Class()
        {
            InitializeComponent();
            //  GLS400.Image = Image.FromFile(pathGLS400);
            //  GLS500.Image = Image.FromFile(pathGLS500);


            GLS400.Image = Image.FromFile(pathGLS400_hau);
            GLS500.Image = Image.FromFile(pathGLS500_hau);

        }
    }
}
