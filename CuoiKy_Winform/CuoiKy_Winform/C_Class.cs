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
    public partial class C_Class : Form
    {
        string parent_name;
        string pathC200 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200.jpg";
        string pathC300 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300.jpg";
        string pathC43 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C43.jpg";

        string pathC200_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200.jpg";
        string pathC300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300.jpg";
        string pathC43_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C43.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;
        Home frmHome;
        Sedan frmSedan;
        All_CarClass frmAll;

        Booking bk;

       

        public C_Class(string parent_formname)
        {
            InitializeComponent();
            C200.Image = Image.FromFile(pathC200);
            C300.Image = Image.FromFile(pathC300);
            C43.Image = Image.FromFile(pathC43);

            //C200.Image = Image.FromFile(pathC200_hau);
            //C300.Image = Image.FromFile(pathC300_hau);
            //C43.Image = Image.FromFile(pathC43_hau);

            parent_name = parent_formname;
        }

        public C_Class(Home parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            C200.Image = Image.FromFile(pathC200);
            C300.Image = Image.FromFile(pathC300);
            C43.Image = Image.FromFile(pathC43);

            //C200.Image = Image.FromFile(pathC200_hau);
            //C300.Image = Image.FromFile(pathC300_hau);
            //C43.Image = Image.FromFile(pathC43_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public C_Class(Sedan parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            C200.Image = Image.FromFile(pathC200);
            C300.Image = Image.FromFile(pathC300);
            C43.Image = Image.FromFile(pathC43);

            //C200.Image = Image.FromFile(pathC200_hau);
            //C300.Image = Image.FromFile(pathC300_hau);
            //C43.Image = Image.FromFile(pathC43_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmSedan = parent;
            carName = carname;
            carPath = carpath;
        }

        public C_Class(All_CarClass parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            C200.Image = Image.FromFile(pathC200);
            C300.Image = Image.FromFile(pathC300);
            C43.Image = Image.FromFile(pathC43);

            //C200.Image = Image.FromFile(pathC200_hau);
            //C300.Image = Image.FromFile(pathC300_hau);
            //C43.Image = Image.FromFile(pathC43_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }

        private void lbCClass_Click(object sender, EventArgs e)
        {

        }

        private void C_Class_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Car_Details";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "Car_Details";
            //command.Connection = conn;

            // List PictureBox & Label
            List<PictureBox> lstpcb = new List<PictureBox>();
            List<Label> lstlb = new List<Label>();
            lstpcb.Add(C200); lstpcb.Add(C300); lstpcb.Add(C43);
            lstlb.Add(lbC200); lstlb.Add(lbC300); lstlb.Add(lbC43);

            for (int i = 0; i < lstpcb.Count(); i++)
            {
                SqlParameter parCar_name = new SqlParameter("@car_name", SqlDbType.VarChar);
                parCar_name.Value = lstpcb[i].Name;
                command.Parameters.Add(parCar_name);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string car_name = "Name: Mercedes-benz " + reader.GetString(0);
                    string car_type = "Type: " + reader.GetString(1);
                    string car_class = "Class: " + reader.GetString(2);
                    int car_seat = reader.GetInt32(3);
                    string energy_type = "Energy type: " + reader.GetString(4);
                    string car_color = "Color: " + reader.GetString(5);
                    string car_info = "Information: " + reader.GetString(6);
                    lstlb[i].Text = car_name + "\n" + car_type + "          " + car_class + "            " + energy_type + "\n" + "Seat: " + car_seat.ToString() 
                        + "                  " + car_color + "\n" + car_info + "\n";
                }
                reader.Close();
                command.Parameters.Clear();
            }
        }

        private void C_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "Sedan")
                frmSedan.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void C200_Click(object sender, EventArgs e)
        {
            if (carName.Contains(" C200") == false)
            {
                carPath.Add(pathC200);
                carName.Add("C200");

               // carPath.Add(pathC200_hau);
            }
        }

        private void C300_Click(object sender, EventArgs e)
        {
            if (carName.Contains("C300") == false)
            {
                carPath.Add(pathC300);
                carName.Add("C300");

                //carPath.Add(pathC300_hau);
            }
        }

        private void C43_Click(object sender, EventArgs e)
        {
            if (carName.Contains("C43") == false)
            {
                carPath.Add(pathC43);
                carName.Add("C43");

               // carPath.Add(pathC43_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(member_id, carName, carPath).Show();
        }
    }
}
