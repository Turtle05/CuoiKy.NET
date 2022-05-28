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
    public partial class AMG_GT_Class : Form
    {
        string pathAMG_GT2 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-GT 2 door.jpg";
        string pathAMG_GT4 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-GT 4 door.jpeg";


        string pathAMG_GT2_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-GT 2 door.jpg";
        string pathAMG_GT4_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-GT 4 door.jpeg";
        public AMG_GT_Class()
        {
            InitializeComponent();
          //  AMG_GT2.Image = Image.FromFile(pathAMG_GT2);
          //  AMG_GT4.Image = Image.FromFile(pathAMG_GT4);


            AMG_GT2.Image = Image.FromFile(pathAMG_GT2_hau);
            AMG_GT4.Image = Image.FromFile(pathAMG_GT4_hau);
        }
    }
}
