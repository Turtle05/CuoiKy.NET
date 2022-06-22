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
    public partial class Home : Form
    {
        public List<string> carName = new List<string>();
        public List<string> carPath = new List<string>();
        public string member_id;
        public string member_name;

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        public Home()
        {
            InitializeComponent();
        }

        public Home(string memberid)
        {
            InitializeComponent();
            member_id = memberid;
            member_name = GetMemberName(member_id);
            lbMemberName.Text = "Member: " + GetMemberName(member_id);
        }

        public string Get_FormName()
        {
            return "Home";
        }

        public string GetMemberName(string memberid)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select member_name from member where member_id = " + memberid;
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select member_name from member where member_id = " + memberid;
            //command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            string membername = "";
            if (reader.Read())
            {
                membername = reader.GetString(0);
            }
            reader.Close();

            return membername;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            new All_CarClass(this, member_id, carName, carPath).Show();
        }

        private void btnSedan_Click(object sender, EventArgs e)
        {
            new Sedan(this, member_id, carName, carPath).Show();
            this.Hide();
        }

        private void btnSUV_Click(object sender, EventArgs e)
        {
            new SUV(this, member_id, carName, carPath).Show();
            this.Hide();
        }

        private void btnCoupe_Click(object sender, EventArgs e)
        {
            new Coupe(this, member_id, carName, carPath).Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            new Cover().Show();
        }

        private void lbAClass_Click(object sender, EventArgs e)
        {
            new A_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbCClass_Click(object sender, EventArgs e)
        {
            new C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbEClass_Click(object sender, EventArgs e)
        {
            new E_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();

        }

        private void lbGLCClass_Click(object sender, EventArgs e)
        {
            new GLC_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGLEClass_Click(object sender, EventArgs e)
        {
            new GLE_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbGLSClass_Click(object sender, EventArgs e)
        {
            new GLS_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbAMGGT_Click(object sender, EventArgs e)
        {
            new AMG_GT_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbAMGC_Click(object sender, EventArgs e)
        {
            new AMG_C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbECoupe_Click(object sender, EventArgs e)
        {
            new E_Coupe_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbMoreSedan_Click(object sender, EventArgs e)
        {
            new Sedan(this, member_id, carName, carPath).Show();
            this.Hide();
        }

        private void lbMoreSUV_Click(object sender, EventArgs e)
        {
            new SUV(this, member_id, carName, carPath).Show();
            this.Hide();
        }

        private void lbMoreCoupe_Click(object sender, EventArgs e)
        {
            new Coupe(this, member_id, carName, carPath).Show();
            this.Hide();
        }

        private void pcbA_Class_Click(object sender, EventArgs e)
        {
            new A_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbC_Class_Click(object sender, EventArgs e)
        {
            new C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbE_Class_Click(object sender, EventArgs e)
        {
            new E_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbGLC_Class_Click(object sender, EventArgs e)
        {
            new GLC_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbGLE_Class_Click(object sender, EventArgs e)
        {
            new GLE_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbGLS_Class_Click(object sender, EventArgs e)
        {
            new GLS_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbAMGGT_Class_Click(object sender, EventArgs e)
        {
            new AMG_GT_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbAMGC_Class_Click(object sender, EventArgs e)
        {
            new AMG_C_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void pcbE_Coupe_Class_Click(object sender, EventArgs e)
        {
            new E_Coupe_Class(this, member_id, Get_FormName(), carName, carPath).Show();
            this.Hide();
        }

        private void lbMemberName_Click(object sender, EventArgs e)
        {
            new Profile(this, member_id, lbMemberName.Text).Show();
            this.Hide();
        }
    }
}
