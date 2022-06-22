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
    public partial class GLS_Class : Form
    {
        string parent_name;
        string pathGLS400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS400.jpeg";
        string pathGLS500 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS500.jpg";


        string pathGLS400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS400.jpeg";
        string pathGLS500_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLS500.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;
        Home frmHome;
        SUV frmSUV;
        All_CarClass frmAll;

        Booking bk;
        public GLS_Class()
        {
            InitializeComponent();
            GLS400.Image = Image.FromFile(pathGLS400);
            GLS500.Image = Image.FromFile(pathGLS500);


            //GLS400.Image = Image.FromFile(pathGLS400_hau);
            //GLS500.Image = Image.FromFile(pathGLS500_hau);
        }
        public GLS_Class(Home parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLS400.Image = Image.FromFile(pathGLS400);
            GLS500.Image = Image.FromFile(pathGLS500);


            //GLS400.Image = Image.FromFile(pathGLS400_hau);
            //GLS500.Image = Image.FromFile(pathGLS500_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public GLS_Class(SUV parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLS400.Image = Image.FromFile(pathGLS400);
            GLS500.Image = Image.FromFile(pathGLS500);


            //GLS400.Image = Image.FromFile(pathGLS400_hau);
            //GLS500.Image = Image.FromFile(pathGLS500_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmSUV = parent;
            carName = carname;
            carPath = carpath;
        }

        public GLS_Class(All_CarClass parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLS400.Image = Image.FromFile(pathGLS400);
            GLS500.Image = Image.FromFile(pathGLS500);


            //GLS400.Image = Image.FromFile(pathGLS400_hau);
            //GLS500.Image = Image.FromFile(pathGLS500_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }

        private void GLS_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(GLS400); lstpcb.Add(GLS500); 
            lstlb.Add(lbGLS400); lstlb.Add(lbGLS500);

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

        private void GLS_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "SUV")
                frmSUV.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void GLS400_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLS400") == false)
            {
                carPath.Add(pathGLS400);
                carName.Add("GLS400");

               // carPath.Add(pathGLS400_hau);
            }
        }

        private void GLS500_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLS500") == false)
            {
                carPath.Add(pathGLS500);
                carName.Add("GLS500");

                //carPath.Add(pathGLS500_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(member_id, carName, carPath).Show();
        }
    }
}
