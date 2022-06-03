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
    public partial class C_Coupe_Class : Form
    {
        string pathC200_Coupe = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200 Coupe.jpg";
        string pathC300_Coupe = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300 Coupe.jpg";
    
        string pathC200_Coupe_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C200 Coupe.jpg";
        string pathC300_Coupe_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\C300 Coupe.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";
        public C_Coupe_Class()
        {
            InitializeComponent();
            //C200_Coupe.Image = Image.FromFile(pathC200_Coupe);
            //C300_Coupe.Image = Image.FromFile(pathC300_Coupe);

            C200_Coupe.Image = Image.FromFile(pathC200_Coupe_hau);
            C300_Coupe.Image = Image.FromFile(pathC300_Coupe_hau);

        }

        private void C_Coupe_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(C200_Coupe); lstpcb.Add(C300_Coupe);
            lstlb.Add(lbC200_Coupe); lstlb.Add(lbC300_Coupe); 

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
    }
}
