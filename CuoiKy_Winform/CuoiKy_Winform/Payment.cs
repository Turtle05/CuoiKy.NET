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
    public partial class Payment : Form
    {
        List<string> lstCar;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(List<string> lstcar)
        {
            InitializeComponent();
            lstCar = new List<string>();
            lstCar = lstcar;
            foreach (var item in lstCar)
            {
                Label lb = new Label();
                lb.Text = item;
                lb.BackColor = Color.CornflowerBlue;
                fpnlPayment.Controls.Add(lb);
            }
        }
    }
}
