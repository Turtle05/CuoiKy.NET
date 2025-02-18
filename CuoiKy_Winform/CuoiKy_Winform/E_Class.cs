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

        List<string> carName = new List<string>();
        List<string> carPath = new List<string>();
        string member_id;
        Home frmHome;
        Sedan frmSedan;
        All_CarClass frmAll;

        Booking bk;

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
        public E_Class(Home parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
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

            member_id = memberid;

            parent_name = parent_form_name;

            frmHome = parent;
            carName = carname;
            carPath = carpath;
        }

        public E_Class(Sedan parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
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

            member_id = memberid;

            parent_name = parent_form_name;

            frmSedan = parent;
            carName = carname;
            carPath = carpath;
        }

        public E_Class(All_CarClass parent, string memberid, string parent_form_name, List<string> carname, List<string> carpath)
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

            member_id = memberid;

            parent_name = parent_form_name;

            frmAll = parent;
            carName = carname;
            carPath = carpath;
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
                frmHome.Show();
            else if (parent_name == "Sedan")
                frmSedan.Show();
            else if (parent_name == "All_CarClass")
                frmAll.Show();
        }

        private void E200_Click(object sender, EventArgs e)
        {
            if (carName.Contains("E200") == false)
            {
                carPath.Add(pathE200);
                carName.Add("E200");

               // carPath.Add(pathE200_hau);
            }
        }

        private void E300_Click(object sender, EventArgs e)
        {
            if (carName.Contains("E300") == false)
            {
                carPath.Add(pathE300);
                carName.Add("E300");

                //carPath.Add(pathE300_hau);
            }
        }

        private void E350_Click(object sender, EventArgs e)
        {
            if (carName.Contains("E350") == false)
            {
                carPath.Add(pathE350);
                carName.Add("E350");

                //carPath.Add(pathE350_hau);
            }
        }

        private void E43_Click(object sender, EventArgs e)
        {
            if (carName.Contains("E43") == false)
            {
                carPath.Add(pathE43);
                carName.Add("E43");

               // carPath.Add(pathE43_hau);
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            new Booking(member_id, carName, carPath).Show();
        }
    }
}
