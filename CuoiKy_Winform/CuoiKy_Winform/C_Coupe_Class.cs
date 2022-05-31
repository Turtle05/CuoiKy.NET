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
    public partial class C_Coupe_Class : Form
    {
        string pathC200_Coupe = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200 Coupe.jpg";
        string pathC300_Coupe = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300 Coupe.jpg";
    
        string pathC200_Coupe_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200 Coupe.jpg";
        string pathC300_Coupe_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300 Coupe.jpg";
        public C_Coupe_Class()
        {
            InitializeComponent();
            C200_Coupe.Image = Image.FromFile(pathC200_Coupe);
            C300_Coupe.Image = Image.FromFile(pathC300_Coupe);

            //C200_COUPE.Image = Image.FromFile(pathC200_Coupe_hau);
            //C300_COUPE.Image = Image.FromFile(pathC300_Coupe_hau);

        }
    }
}
