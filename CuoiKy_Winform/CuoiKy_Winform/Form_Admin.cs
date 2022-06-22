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
    public partial class Form_Admin : Form
    {
        private Form currentChildForm;
        public Form_Admin()
        {
            InitializeComponent();
            timer1.Start();
            //lbNameUser.Text = 
        }

        // Đồng hồ
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("HH:mm:ss");
        }

        private void OpenChildFrom(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // BUTTON USER
        private void btUser_Click(object sender, EventArgs e)
        {
            new Form_UserInfo().Show();
        }

        // BUTTON CAR
        private void btCar_Click(object sender, EventArgs e)
        {
            new Form_Car().Show();
            //this.Hide();
        }

        // BUTTON USER ACCOUNT
        private void btUserAccount_Click(object sender, EventArgs e)
        {
            new Form_UserAccount().Show();
        }

        // BUTTON EXIT
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
