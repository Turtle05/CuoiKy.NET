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
    public partial class GLE_Class : Form
    {
        string pathGLE300= "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE300.jpg";
        string pathGLE400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE400.jpg";
        string pathGLE500 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE500.jpeg";

        string pathGLE300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE300.jpg";
        string pathGLE400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE400.jpg";
        string pathGLE500_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE500.jpeg";
        public GLE_Class()
        {
            InitializeComponent();
            GLE300.Image = Image.FromFile(pathGLE300);
            GLE400.Image = Image.FromFile(pathGLE400);
            GLE500.Image = Image.FromFile(pathGLE500);

            //GLE300.Image = Image.FromFile(pathGLE300_hau);
            //GLE400.Image = Image.FromFile(pathGLE400_hau);
            //GLE500.Image = Image.FromFile(pathGLE500_hau);
        }
    }
}
