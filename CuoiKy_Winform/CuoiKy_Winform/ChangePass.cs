using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_Winform
{
    public partial class ChangePass : Form
    {
        string member_id;
        string currPass;
        Profile frmProfile;

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        public ChangePass()
        {
            InitializeComponent();
        }

        public ChangePass(Profile parent, string memberid)
        {
            InitializeComponent();

            frmProfile = parent;
            member_id = memberid;
            currPass = GetCurPass();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtCurPass.Text != currPass)
            {
                lbCurPass.Text = "Your current password is incorrect. Try again!";
                txtCurPass.Clear(); txtNewPass.Clear(); txtConfirmPass.Clear();
                txtCurPass.Focus();
            }
            else
            {
                lbCurPass.Text = "";
                if (txtNewPass.Text.Length > 6)
                {
                    if (txtNewPass.Text == txtConfirmPass.Text)
                    {
                        if (conn == null)
                            conn = new SqlConnection(strConn);
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        SqlCommand command = new SqlCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "update member set pass = " + txtNewPass.Text + " where member_id = " + member_id;
                        command.Connection = conn;

                        int ret = command.ExecuteNonQuery();
                        if (ret > 0)
                        {
                            DialogResult dlr = MessageBox.Show("Change password successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dlr == DialogResult.OK)
                            {
                                lbNewPass.Text = "";
                                this.Close();
                                frmProfile.Show();
                            }
                        }
                    }
                    else
                    {
                        lbConfirmPass.Text = "Your confirm password different from your new password!";
                        txtCurPass.Clear(); txtNewPass.Clear(); txtConfirmPass.Clear();
                        txtCurPass.Focus();
                    }
                }
                else
                {
                    lbNewPass.Text = "Password must longer than 6 characters!";
                    txtNewPass.Clear(); txtConfirmPass.Clear();
                    txtNewPass.Focus();
                }
            }
        }

        public string GetCurPass()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select pass from member where member_id = " + member_id;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            string pass = "";

            if (reader.Read())
            {
                pass = reader.GetString(0);
            }
            reader.Close();

            return pass;
        }

        private void cbNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNewPass.Checked)
                txtNewPass.PasswordChar = (char)0;
            else
                txtNewPass.PasswordChar = '*';
        }

        private void cbConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirmPass.Checked)
                txtConfirmPass.PasswordChar = (char)0;
            else
                txtConfirmPass.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmProfile.Show();
            this.Close();
        }
    }
}
