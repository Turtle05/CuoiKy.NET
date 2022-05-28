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
   
    public partial class S_Class : Form
    {
        string pathS450 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S450.jpg";
        string pathS500 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S500.jpg";
        string pathS600 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S600.jpg";
        string pathS680 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S680.jpg";
        string pathS65 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S65.jpg";

        string pathS450_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S450.jpg";
        string pathS500_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S500.jpg";
        string pathS600_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S600.jpg";
        string pathS680_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S680.jpg";
        string pathS65_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S65.jpg";
        public S_Class()
        {
            InitializeComponent();
            //S450.Image = Image.FromFile(pathS450);
            //S500.Image = Image.FromFile(pathS500);
            //S600.Image = Image.FromFile(pathS600);
            //S680.Image = Image.FromFile(pathS680);
            //S65.Image = Image.FromFile(pathS65);

            S450.Image = Image.FromFile(pathS450_hau);
            S500.Image = Image.FromFile(pathS500_hau);
            S600.Image = Image.FromFile(pathS600_hau);
            S680.Image = Image.FromFile(pathS680_hau);
            S65.Image = Image.FromFile(pathS65_hau);
        }

        private void S450_Click(object sender, EventArgs e)
        {

        }

        private void pnlSClass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtxtS680_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
