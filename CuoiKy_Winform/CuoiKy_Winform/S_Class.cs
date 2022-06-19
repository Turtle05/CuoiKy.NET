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
   
    public partial class S_Class : Form
    {
        string parent_name;
        string pathS450 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S450.jpg";
        string pathS500 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S500.jpg";
        string pathS600 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S600.jpg";
        string pathS680 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S680.jpg";
        string pathS65 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S65.jpg";

        string pathS450_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S450.jpg";
        string pathS500_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S500.jpg";
        string pathS600_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S600.jpg";
        string pathS680_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S680.jpg";
        string pathS65_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\S65.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        Home frmHome;
        Sedan frmSedan;
        All_CarClass frmAll;

        Booking bk;
        public S_Class()
        {
            InitializeComponent();
            //S450.Image = Image.FromFile(pathS450);
            //S500.Image = Image.FromFile(pathS500);
            //S600.Image = Image.FromFile(pathS600);
            //S680.Image = Image.FromFile(pathS680);
            //S65.Image = Image.FromFile(pathS65);

            S450.Image = Image.FromFile(pathS450_hau);
            S500.Image = Image.FromFile(pathS500_hau);
            S600.Image = Image.FromFile(pathS600_hau);
            S680.Image = Image.FromFile(pathS680_hau);
            S65.Image = Image.FromFile(pathS65_hau);
        }
        public S_Class(Home parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            //S450.Image = Image.FromFile(pathS450);
            //S500.Image = Image.FromFile(pathS500);
            //S600.Image = Image.FromFile(pathS600);
            //S680.Image = Image.FromFile(pathS680);
            //S65.Image = Image.FromFile(pathS65);

            S450.Image = Image.FromFile(pathS450_hau);
            S500.Image = Image.FromFile(pathS500_hau);
            S600.Image = Image.FromFile(pathS600_hau);
            S680.Image = Image.FromFile(pathS680_hau);
            S65.Image = Image.FromFile(pathS65_hau);

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public S_Class(Sedan parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            //S450.Image = Image.FromFile(pathS450);
            //S500.Image = Image.FromFile(pathS500);
            //S600.Image = Image.FromFile(pathS600);
            //S680.Image = Image.FromFile(pathS680);
            //S65.Image = Image.FromFile(pathS65);

            S450.Image = Image.FromFile(pathS450_hau);
            S500.Image = Image.FromFile(pathS500_hau);
            S600.Image = Image.FromFile(pathS600_hau);
            S680.Image = Image.FromFile(pathS680_hau);
            S65.Image = Image.FromFile(pathS65_hau);

            parent_name = parent_form_name;

            frmSedan = parent;
            carName = carname;
            carPath = carpath;
        }

        public S_Class(All_CarClass parent, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            //S450.Image = Image.FromFile(pathS450);
            //S500.Image = Image.FromFile(pathS500);
            //S600.Image = Image.FromFile(pathS600);
            //S680.Image = Image.FromFile(pathS680);
            //S65.Image = Image.FromFile(pathS65);

            S450.Image = Image.FromFile(pathS450_hau);
            S500.Image = Image.FromFile(pathS500_hau);
            S600.Image = Image.FromFile(pathS600_hau);
            S680.Image = Image.FromFile(pathS680_hau);
            S65.Image = Image.FromFile(pathS65_hau);

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }



        private void pnlSClass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtxtS680_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_Class_Load(object sender, EventArgs e)
        {
            //if (conn == null)
            //    conn = new SqlConnection(strConn);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.StoredProcedure;
            //command.CommandText = "Car_Details";
            //command.Connection = conn;

            if (conn == null)
                conn = new SqlConnection(strConn2);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Car_Details";
            command.Connection = conn;

            // List PictureBox & Label
            List<PictureBox> lstpcb = new List<PictureBox>();
            List<Label> lstlb = new List<Label>();
            lstpcb.Add(S450); lstpcb.Add(S500); lstpcb.Add(S600); lstpcb.Add(S680); lstpcb.Add(S65);
            lstlb.Add(lbS450); lstlb.Add(lbS500); lstlb.Add(lbS600); lstlb.Add(lbS680); lstlb.Add(lbS65);

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

        private void S_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "Sedan")
                frmSedan.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void S450_Click(object sender, EventArgs e)
        {
            if (carName.Contains("S450") == false)
            {
                //carPath.Add(pathS450);
                carName.Add("S450");

                carPath.Add(pathS450_hau);
            }
        }
        private void S500_Click(object sender, EventArgs e)
        {
            if (carName.Contains("S500") == false)
            {
                //carPath.Add(pathS500);
                carName.Add("S500");

                carPath.Add(pathS450_hau);
            }
        }

        private void S600_Click(object sender, EventArgs e)
        {
            if (carName.Contains("S600") == false)
            {
                //carPath.Add(pathS600);
                carName.Add("S600");

                carPath.Add(pathS450_hau);
            }
        }

        private void S680_Click(object sender, EventArgs e)
        {
            if (carName.Contains("S680") == false)
            {
                //carPath.Add(pathS680);
                carName.Add("S680");

                carPath.Add(pathS450_hau);
            }
        }

        private void S65_Click(object sender, EventArgs e)
        {
            if (carName.Contains("S65") == false)
            {
                //carPath.Add(pathS65);
                carName.Add("S65");

                carPath.Add(pathS450_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(carName, carPath).Show();
        }
    }
    
}
