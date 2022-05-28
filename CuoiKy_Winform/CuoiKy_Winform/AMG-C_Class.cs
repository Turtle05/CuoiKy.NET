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
    public partial class AMG_C_Class : Form
    {
        string pathAMG_C43 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-C43 Coupe.jpg";
        string pathAMG_C63 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-c63 Coupe.jpeg";


        string pathAMG_C43_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-C43 Coupe.jpg";
        string pathAMG_C63_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-c63 Coupe.jpg";
        public AMG_C_Class()
        {
            InitializeComponent();
            //AMG_C43.Image = Image.FromFile(pathAMG_C43);
           // AMG_C63.Image = Image.FromFile(pathAMG_C63);


            AMG_C43.Image = Image.FromFile(pathAMG_C43_hau);
            AMG_C63.Image = Image.FromFile(pathAMG_C63_hau);
        }
    }
}
