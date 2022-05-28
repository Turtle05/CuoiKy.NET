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
        string pathC200_COUPE = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200 Coupe.jpg";
        string pathC300_COUPE = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300 Coupe.jpg";
    
        string pathC200_COUPE_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200 Coupe.jpg";
        string pathC300_COUPE_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300 Coupe.jpg";
        public C_Coupe_Class()
        {
            InitializeComponent();
            //C200_COUPE.Image = Image.FromFile(pathC200_COUPE);
            //C300_COUPE.Image = Image.FromFile(pathC300_COUPE);
            
            C200_COUPE.Image = Image.FromFile(pathC200_COUPE_hau);
            C300_COUPE.Image = Image.FromFile(pathC300_COUPE_hau);
          
        }
    }
}
