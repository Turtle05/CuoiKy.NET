﻿using System;
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
    public partial class AMG_C_Class : Form
    {
        static string parent_name;
        string pathAMG_C43 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-C43 Coupe.jpg";
        string pathAMG_C63 = "C:\\Users\\ADMIN\\Documents\\GitHub\\CuoiKy.NET\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-C63 Coupe.jpg";


        string pathAMG_C43_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-C43 Coupe.jpg";
        string pathAMG_C63_hau = "C:\\Users\\Hau\\Documents\\GitHub\\CuoiKy_Winform\\CuoiKy_Winform\\Resources\\AMG-C63 Coupe.jpg";

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;
        Home frmHome;
        Coupe frmCoupe;
        All_CarClass frmAll;

        Booking bk;
        public AMG_C_Class()
        {
            InitializeComponent();
            AMG_C43.Image = Image.FromFile(pathAMG_C43);
            AMG_C63.Image = Image.FromFile(pathAMG_C63);


            //AMG_C43.Image = Image.FromFile(pathAMG_C43_hau);
            //AMG_C63.Image = Image.FromFile(pathAMG_C63_hau);
        }
        public AMG_C_Class(Home parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            AMG_C43.Image = Image.FromFile(pathAMG_C43);
            AMG_C63.Image = Image.FromFile(pathAMG_C63);


            //AMG_C43.Image = Image.FromFile(pathAMG_C43_hau);
            //AMG_C63.Image = Image.FromFile(pathAMG_C63_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public AMG_C_Class(Coupe parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            AMG_C43.Image = Image.FromFile(pathAMG_C43);
            AMG_C63.Image = Image.FromFile(pathAMG_C63);


            //AMG_C43.Image = Image.FromFile(pathAMG_C43_hau);
            //AMG_C63.Image = Image.FromFile(pathAMG_C63_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmCoupe = parent;
            carName = carname;
            carPath = carpath;
        }

        public AMG_C_Class(All_CarClass parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
        {
            InitializeComponent();
            AMG_C43.Image = Image.FromFile(pathAMG_C43);
            AMG_C63.Image = Image.FromFile(pathAMG_C63);


            //AMG_C43.Image = Image.FromFile(pathAMG_C43_hau);
            //AMG_C63.Image = Image.FromFile(pathAMG_C63_hau);

            member_id = memberid;

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
        }

        private void AMG_C_Class_Load(object sender, EventArgs e)
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
            lstpcb.Add(AMG_C43); lstpcb.Add(AMG_C63); 
            lstlb.Add(lbAMG_C43); lstlb.Add(lbAMG_C63);

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
        private void AMG_C_Class_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parent_name == "Home")
                frmHome.Show();
            else if (parent_name == "Coupe")
                frmCoupe.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void AMG_C43_Click(object sender, EventArgs e)
        {
            if (carName.Contains("AMG_C43") == false)
            {
                carPath.Add(pathAMG_C43);
                carName.Add("AMG_C43");

                //carPath.Add(pathAMG_C43_hau);
            }
        }

        private void AMG_C63_Click(object sender, EventArgs e)
        {
            if (carName.Contains("AMG_C63") == false)
            {
                carPath.Add(pathAMG_C63);
                carName.Add("AMG_C63");

                //carPath.Add(pathAMG_C63_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(member_id, carName, carPath).Show();
        }
    }
}
