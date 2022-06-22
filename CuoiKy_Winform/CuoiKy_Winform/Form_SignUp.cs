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
        string member_id;
        Cover frmCover;

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        public Form_SignUp()
        {
            InitializeComponent();
        }

        public Form_SignUp(Cover parent)
        {
            InitializeComponent();

            frmCover = parent;
        }

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
            bool validEmail = true;
            if (txtEmail.Text == "")
            {
                label10.Text = "*";
                lbMessage.Text = "";
            }
            else if (txtEmail.Text.Contains('@') != true)
            {
                validEmail = false;
                lbMessage.Text = "Your email don't have '@' character. Try again";
            }    
            else if (txtPassword.Text == "")
                label11.Text = "*";
            else if (txtPassword.Text.Length <= 6)
            {
                lbMessage.Text = "Password must longer than 6 characters!";
                txtPassword.Clear(); txtComfirmpass.Clear();
                txtPassword.Focus();
            }
            else if (txtComfirmpass.Text == "")
                label12.Text = "*";
            else if (txtPassword.Text != txtComfirmpass.Text)
                MessageBox.Show("Confirm password do not match!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                validEmail = true;
                if (validEmail == true) // Kiểm tra email hợp lệ hay không
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

                if (check == 1) // Nếu tài khoản chưa trùng
                {
                    lbMessage.Text = "";
                    label10.Text = ""; label11.Text = ""; label12.Text = "";
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;
                    command.Parameters.Add("@role", SqlDbType.VarChar).Value = "USER";

                    SqlCommand command2 = new SqlCommand();
                    command2.CommandType = CommandType.Text;
                    command2.CommandText = "select count(*) from member";
                    command2.Connection = conn;

                    int ret = command.ExecuteNonQuery();
                    int id = (int)command2.ExecuteScalar();
                    member_id = id.ToString();
                    if (ret > 0)
                    {
                        MessageBox.Show(member_id);
                        MessageBox.Show("Sign up successfully!", "Notification", MessageBoxButtons.OK);
                        new Home(member_id).Show();
                        this.Close();
                    }
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
            frmCover.Show();
            this.Hide();
        }
    }
}
