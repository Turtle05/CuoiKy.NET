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
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
        }

        private void cover_Load(object sender, EventArgs e)
        {
            lbWelcome.Parent = pictureBox1;
            lbWelcome.BackColor = Color.Transparent;
            btnSignIn.Parent = pictureBox1;
            btnSignIn.BackColor = Color.Transparent;
            btnSignUp.Parent = pictureBox1;
            btnSignUp.BackColor = Color.Transparent;
            btnExit.Parent = pictureBox1;
            btnExit.BackColor = Color.Transparent;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new Form_SignIn().Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new Form_SignUp().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
