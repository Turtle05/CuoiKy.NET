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
    public partial class All_CarClass : Form
    {
        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();

        public All_CarClass()
        {
            InitializeComponent();
        }

        public All_CarClass(List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            carName = carname;
            carPath = carpath;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
