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
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Add_Member";
            command.Connection = conn;

            command.Parameters.Add("@member_name", SqlDbType.NVarChar).Value = txtName.Text;
            if (chbNam.Checked)
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = chbNam.Text;
            else
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = chbNu.Text;
            command.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = txtNationality.Text;
            command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = txtAddress.Text;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;

            SqlCommand command1 = new SqlCommand();
            int check = 0;
            if (txtEmail.Text == "")
            {
                label10.Text = "*";
                lbMessage.Text = "";
            }
            else if (txtPassword.Text == "")
                label11.Text = "*";
            else if (txtComfirmpass.Text == "")
                label12.Text = "*";
            else if (txtPassword.Text != txtComfirmpass.Text)
                MessageBox.Show("Confirm password do not match!");
            else
            {
                if (txtEmail.Text.Contains('@')) // Kiểm tra email hợp lệ hay không
                {
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.CommandText = "Check_Email";
                    command1.Connection = conn;

                    SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar);
                    parEmail.Value = txtEmail.Text;
                    command1.Parameters.Add(parEmail);

                    SqlDataReader reader = command1.ExecuteReader();
                    if (reader.Read()) // Nếu tài khoản trùng
                    {
                        lbMessage.Text = "This email has been existed! Try again";
                        txtEmail.Focus();
                        reader.Read();
                        check = 0;
                    }
                    else
                        check = 1;
                    reader.Close();
                }
                else // Nếu email không hợp lệ
                {
                    check = 0;
                    lbMessage.Text = "Your email don't have '@' character. Try again";
                }

                if (check == 1) // Nếu tài khoản chưa trùng
                {
                    lbMessage.Text = "";
                    label10.Text = ""; label11.Text = ""; label12.Text = "";
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
                    command.Parameters.Add("@role", SqlDbType.VarChar).Value = "USER";
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                        new Home().Show();
                }
            }
        }

        private void lbClearField_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtNationality.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
