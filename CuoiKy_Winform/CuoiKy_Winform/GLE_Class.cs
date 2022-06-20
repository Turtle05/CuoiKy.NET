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
    public partial class GLE_Class : Form
    {
        string parent_name;
        string pathGLE300= "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE300.jpg";
        string pathGLE400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE400.jpg";
        string pathGLE500 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE500.jpeg";

        string pathGLE300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE300.jpg";
        string pathGLE400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE400.jpg";
        string pathGLE500_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLE500.jpeg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        Home frmHome;
        SUV frmSUV;
        All_CarClass frmAll;

        Booking bk;
        public GLE_Class()
        {
            InitializeComponent();
            GLE300.Image = Image.FromFile(pathGLE300);
            GLE400.Image = Image.FromFile(pathGLE400);
            GLE500.Image = Image.FromFile(pathGLE500);

            //GLE300.Image = Image.FromFile(pathGLE300_hau);
            //GLE400.Image = Image.FromFile(pathGLE400_hau);
            //GLE500.Image = Image.FromFile(pathGLE500_hau);
        }

        public GLE_Class(Home parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLE300.Image = Image.FromFile(pathGLE300);
            GLE400.Image = Image.FromFile(pathGLE400);
            GLE500.Image = Image.FromFile(pathGLE500);

            //GLE300.Image = Image.FromFile(pathGLE300_hau);
            //GLE400.Image = Image.FromFile(pathGLE400_hau);
            //GLE500.Image = Image.FromFile(pathGLE500_hau);

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public GLE_Class(SUV parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLE300.Image = Image.FromFile(pathGLE300);
            GLE400.Image = Image.FromFile(pathGLE400);
            GLE500.Image = Image.FromFile(pathGLE500);

            //GLE300.Image = Image.FromFile(pathGLE300_hau);
            //GLE400.Image = Image.FromFile(pathGLE400_hau);
            //GLE500.Image = Image.FromFile(pathGLE500_hau);

            parent_name = parent_form_name;

            frmSUV = parent;
            carName = carname;
            carPath = carpath;
        }

        public GLE_Class(All_CarClass parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLE300.Image = Image.FromFile(pathGLE300);
            GLE400.Image = Image.FromFile(pathGLE400);
            GLE500.Image = Image.FromFile(pathGLE500);

            //GLE300.Image = Image.FromFile(pathGLE300_hau);
            //GLE400.Image = Image.FromFile(pathGLE400_hau);
            //GLE500.Image = Image.FromFile(pathGLE500_hau);

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }

        private void GLE_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(GLE300); lstpcb.Add(GLE400); lstpcb.Add(GLE500); 
            lstlb.Add(lbGLE300); lstlb.Add(lbGLE400); lstlb.Add(lbGLE500); 
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

        private void GLE_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "SUV")
                frmSUV.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void GLE300_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLE300") == false)
            {
                carPath.Add(pathGLE300);
                carName.Add("GLE300");

                //carPath.Add(pathGLE300_hau);
            }
        }

        private void GLE400_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLE400") == false)
            {
                carPath.Add(pathGLE400);
                carName.Add("GLE400");

                //carPath.Add(pathGLE400_hau);
            }
        }

        private void GLE500_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLE500") == false)
            {
                carPath.Add(pathGLE500);
                carName.Add("GLE500");

                //carPath.Add(pathGLE500_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(carName, carPath).Show();
        }
    }
    
}
