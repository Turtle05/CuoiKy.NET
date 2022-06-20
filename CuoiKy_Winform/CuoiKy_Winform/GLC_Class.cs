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
    public partial class GLC_Class : Form
    {
        string parent_name;
        string pathGLC300 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC300.jpg";
        string pathGLC350 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC350.jpg";
        string pathGLC400 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC400.jpg";

        string pathGLC300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC300.jpg";
        string pathGLC350_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC350.jpg";
        string pathGLC400_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\GLC400.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        Home frmHome;
        SUV frmSUV;
        All_CarClass frmAll;

        Booking bk;
        public GLC_Class()
        {
            InitializeComponent();
            GLC300.Image = Image.FromFile(pathGLC300);
            GLC350.Image = Image.FromFile(pathGLC350);
            GLC400.Image = Image.FromFile(pathGLC400);

            //GLC300.Image = Image.FromFile(pathGLC300_hau);
            //GLC350.Image = Image.FromFile(pathGLC350_hau);
            //GLC400.Image = Image.FromFile(pathGLC400_hau);

       
        }

        public GLC_Class(Home parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLC300.Image = Image.FromFile(pathGLC300);
            GLC350.Image = Image.FromFile(pathGLC350);
            GLC400.Image = Image.FromFile(pathGLC400);

            //GLC300.Image = Image.FromFile(pathGLC300_hau);
            //GLC350.Image = Image.FromFile(pathGLC350_hau);
            //GLC400.Image = Image.FromFile(pathGLC400_hau);

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public GLC_Class(SUV parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLC300.Image = Image.FromFile(pathGLC300);
            GLC350.Image = Image.FromFile(pathGLC350);
            GLC400.Image = Image.FromFile(pathGLC400);

            //GLC300.Image = Image.FromFile(pathGLC300_hau);
            //GLC350.Image = Image.FromFile(pathGLC350_hau);
            //GLC400.Image = Image.FromFile(pathGLC400_hau);

            parent_name = parent_form_name;

            frmSUV = parent;
            carName = carname;
            carPath = carpath;
        }

        public GLC_Class(All_CarClass parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            GLC300.Image = Image.FromFile(pathGLC300);
            GLC350.Image = Image.FromFile(pathGLC350);
            GLC400.Image = Image.FromFile(pathGLC400);

            //GLC300.Image = Image.FromFile(pathGLC300_hau);
            //GLC350.Image = Image.FromFile(pathGLC350_hau);
            //GLC400.Image = Image.FromFile(pathGLC400_hau);
            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }

        private void GLC_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(GLC300); lstpcb.Add(GLC350); lstpcb.Add(GLC400); 
            lstlb.Add(lbGLC300); lstlb.Add(lbGLC350); lstlb.Add(lbGLC400); 

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

        private void GLC_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "SUV")
                frmSUV.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void GLC300_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLC300") == false)
            {
                carPath.Add(pathGLC300);
                carName.Add("GLC300");

                //carPath.Add(pathGLC300_hau);
            }
        }

        private void GLC350_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLC350") == false)
            {
                carPath.Add(pathGLC350);
                carName.Add("GLC350");

                //carPath.Add(pathGLC350_hau);
            }
        }

        private void GLC400_Click(object sender, EventArgs e)
        {
            if (carName.Contains("GLC400") == false)
            {
                carPath.Add(pathGLC400);
                carName.Add("GLC400");

                //carPath.Add(pathGLC400_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(carName, carPath).Show();
        }
    }
    
}
