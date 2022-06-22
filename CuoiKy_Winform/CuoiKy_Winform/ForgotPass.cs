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
    public partial class ForgotPass : Form
    {
        string member_id;

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            member_id = CheckEmail(txtEmail.Text);
            if (member_id == "")
            {
                lbEmail.Text = "Your email is incorrect! Try again";
                txtEmail.Clear(); txtNewPass.Clear(); txtConfirmPass.Clear();
                txtEmail.Focus();
            }
            else
            {
                lbEmail.Text = "";
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
                                new Home(member_id).Show();
                            }
                        }
                    }
                    else
                    {
                        lbConfirmPass.Text = "Your confirm password different from your new password!";
                        txtEmail.Clear(); txtNewPass.Clear(); txtConfirmPass.Clear();
                        txtEmail.Focus();
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

        public string CheckEmail(string email)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select member_id from member where email = " + "'" + email + "'";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                member_id = reader.GetInt32(0).ToString();
            }
            MessageBox.Show(member_id);
            reader.Close();

            return member_id;
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
            new Form_SignIn().Show();
            this.Close();
        }
    }
}
