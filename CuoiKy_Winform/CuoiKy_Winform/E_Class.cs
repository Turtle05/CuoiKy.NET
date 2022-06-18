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
    public partial class E_Class : Form
    {
        string parent_name;
        string pathE200 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E200.jpg";
        string pathE300 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E300.jpg";
        string pathE350 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E350.jpg";
        string pathE43 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E43.jpg";

        string pathE200_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E200.jpg";
        string pathE300_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E300.jpg";
        string pathE350_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E350.jpg";
        string pathE43_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\E43.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        public E_Class()
        {
            InitializeComponent();
            E200.Image = Image.FromFile(pathE200);
            E300.Image = Image.FromFile(pathE300);
            E350.Image = Image.FromFile(pathE350);
            E43.Image = Image.FromFile(pathE43);

            //E200.Image = Image.FromFile(pathE200_hau);
            //E300.Image = Image.FromFile(pathE300_hau);
            //E350.Image = Image.FromFile(pathE350_hau);
            //E43.Image = Image.FromFile(pathE43_hau);
        }
        public E_Class(string parent_formname)
        {
            InitializeComponent();
            E200.Image = Image.FromFile(pathE200);
            E300.Image = Image.FromFile(pathE300);
            E350.Image = Image.FromFile(pathE350);
            E43.Image = Image.FromFile(pathE43);

            //E200.Image = Image.FromFile(pathE200_hau);
            //E300.Image = Image.FromFile(pathE300_hau);
            //E350.Image = Image.FromFile(pathE350_hau);
            //E43.Image = Image.FromFile(pathE43_hau);

            parent_name = parent_formname;
        }

        private void lbEClass_Click(object sender, EventArgs e)
        {

        }

        private void E_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(E200); lstpcb.Add(E300); lstpcb.Add(E350); lstpcb.Add(E43);
            lstlb.Add(lbE200); lstlb.Add(lbE300); lstlb.Add(lbE350); lstlb.Add(lbE43);

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

        private void E_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                new Home().Show();
            else
                new Sedan().Show();
        }
    }
}
