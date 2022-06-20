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
    public partial class EQS_Class : Form
    {
        string parent_name;
        string pathEQS = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\EQS.jpg";

        string pathEQS_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\EQS.jpg";
        
        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";


        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        Home frmHome;
        Sedan frmSedan;
        All_CarClass frmAll;

        Booking bk;
        public EQS_Class()
        {
            InitializeComponent();
            EQS.Image = Image.FromFile(pathEQS);

            //EQS.Image = Image.FromFile(pathEQS_hau);
            
        }

        public EQS_Class(Home parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            EQS.Image = Image.FromFile(pathEQS);

            //EQS.Image = Image.FromFile(pathEQS_hau);
            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public EQS_Class(Sedan parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            EQS.Image = Image.FromFile(pathEQS);

            //EQS.Image = Image.FromFile(pathEQS_hau);

            parent_name = parent_form_name;

            frmSedan = parent;
            carName = carname;
            carPath = carpath;
        }

        public EQS_Class(All_CarClass parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            EQS.Image = Image.FromFile(pathEQS);

            //EQS.Image = Image.FromFile(pathEQS_hau);

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }

        private void lbEQSClass_Click(object sender, EventArgs e)
        {

        }

        private void EQS_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(EQS); 
            lstlb.Add(lbEQS); 

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

        private void EQS_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "Sedan")
                frmSedan.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void EQS_Click(object sender, EventArgs e)
        {
            if (carName.Contains("EQS") == false)
            {
                carPath.Add(pathEQS);
                carName.Add("EQS");

                //carPath.Add(pathEQS_hau);
            }
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(carName, carPath).Show();
        }

        
    }
    
}
