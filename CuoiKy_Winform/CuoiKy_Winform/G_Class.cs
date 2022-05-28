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
    public partial class G_Class : Form
    {
        string pathG400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\G400.jpg";
        string pathG63 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\G63.jpg";


        string pathG400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\G400.jpg";
        string pathG63_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\G63.jpg";
        public G_Class()
        {
            InitializeComponent();
           // G400.Image = Image.FromFile(pathG400);
           // G63.Image = Image.FromFile(pathG63);


            G400.Image = Image.FromFile(pathG400_hau);
            G63.Image = Image.FromFile(pathG63_hau);

        }

        private void G_Class_Load(object sender, EventArgs e)
        {

        }
    }
}
