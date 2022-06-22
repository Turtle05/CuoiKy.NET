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
    public partial class Form_SignIn : Form
    {
        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string member_id;
        Cover frmCover;

        public Form_SignIn()
        {
            InitializeComponent();
        }

        public Form_SignIn(Cover parent)
        {
            InitializeComponent();

            frmCover = parent;
        }

        string strConn3 = @"data source = MUNKY\SQLEXPRESS; Database = ShopOTo; Integrated Security = True";


        private SqlDataReader ExecuteConnection(string str_SP)
        {
            //if (conn == null)
            //    conn = new SqlConnection(strConn);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = str_SP;
            //command.Connection = conn;

            if (conn == null)
                conn = new SqlConnection(strConn3);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = str_SP;
            command.Connection = conn;

            return command.ExecuteReader();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //if (conn == null)
            //    conn = new SqlConnection(strConn);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "Check_Email";
            //command.Connection = conn;

            if (conn == null)
                conn = new SqlConnection(strConn3);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Check_Email";
            command.Connection = conn;

            SqlParameter parEmail = new SqlParameter("@email", SqlDbType.VarChar);
            parEmail.Value = txtEmail.Text;
            command.Parameters.Add(parEmail);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(1) == txtPassword.Text)
                {    
                    member_id = reader.GetInt32(0).ToString();
                    new Home(member_id).Show();
                    this.Hide();
                    reader.Close();
                }
                else
                {
                    lbMessage.Text = "Your password is incorrect! Try again";
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtEmail.Focus();
                    reader.Close();
                }
            }
            else
            {
                lbMessage.Text = "Your email or password is incorrect! Try again";
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
                reader.Close();
            }
        }

        private void lbClearField_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            frmCover.Show();
            this.Hide();
        }

        private void lbForgotPass_Click(object sender, EventArgs e)
        {
            new ForgotPass().Show();
            this.Hide();
        }
    }
}
