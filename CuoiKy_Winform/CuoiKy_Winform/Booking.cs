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
    public partial class Booking : Form
    {
        public List<string> pcb_path = new List<string>();
        public List<string> car_Name = new List<string>();
        public List<string> payment_Carpath = new List<string>();
        List<BookingItem> lstbk = new List<BookingItem>();
        string member_id;

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";


        //PictureBox pcbcar;
        //TextBox txt_quantity;
        //Label lb_info;
        //Button btn1, btn2;
        NumericUpDown nud;
        //FlowLayoutPanel fpnl;
        //CheckBox cb;

        //List<PictureBox> lstpcbcar;
        //List<TextBox> lsttxt_quantity;
        //List<Label> lstlb_info;
        //List<Button> lstbtn1, lstbtn2;
        //List<NumericUpDown> lstnud = new List<NumericUpDown>();
        //List<FlowLayoutPanel> lstfpnl = new List<FlowLayoutPanel>();
        //List<CheckBox> lstcb = new List<CheckBox>();
        //List<string> click_fpnl = new List<string>();
        double []quantity = new double[50];

        public Booking()
        {
            InitializeComponent();
        }

        public Booking(string memberid, List<string> carname,List<string> path)
        {
            InitializeComponent();

            member_id = memberid;
            car_Name = carname;
            pcb_path = path;
            fpnlBooking.FlowDirection = FlowDirection.TopDown;

            int soLuong = car_Name.Count();
            lbSoluong.Text = "Số lượng: " + soLuong.ToString();

            for (int i = 0; i < pcb_path.Count(); i++)
            {
                BookingItem bkitem = new BookingItem();
                bkitem.pcbcar = new PictureBox();
                bkitem.lb_info = new Label();
                bkitem.nud = new NumericUpDown();
                bkitem.cb = new CheckBox();


                bkitem.Size = new Size(750, 150);
                bkitem.AutoScroll = true;
                bkitem.FlowDirection = FlowDirection.LeftToRight;
                bkitem.Name = car_Name[i];


                bkitem.pcbcar.Image = Image.FromFile(pcb_path[i]);
                bkitem.pcbcar.SizeMode = PictureBoxSizeMode.StretchImage;
                bkitem.pcbcar.Size = new System.Drawing.Size(200, 130);
                bkitem.car_Path = pcb_path[i];


                bkitem.lb_info.Text = GetCarInfo(car_Name[i]);
                bkitem.lb_info.Size = new System.Drawing.Size(350, 80); bkitem.lb_info.AutoSize = false; bkitem.lb_info.Font = new Font("Times New Roman", 10, FontStyle.Bold);


                quantity[i] = GetQuantity(car_Name[i]);
                bkitem.nud.Maximum = Decimal.Parse(quantity[i].ToString());
                bkitem.nud.Size = new System.Drawing.Size(50, 30);
                bkitem.nud.ValueChanged += (sender, e) => NumericUpDown_ValueChanged(bkitem.nud, e, quantity[i]);


                bkitem.cb.Name = car_Name[i];
                bkitem.cb.Text = "";


                bkitem.Name = car_Name[i];
                bkitem.Controls.Add(bkitem.pcbcar);
                bkitem.Controls.Add(bkitem.lb_info);
                bkitem.Controls.Add(bkitem.nud);
                bkitem.Controls.Add(bkitem.cb);

                lstbk.Add(bkitem);

                foreach (var item in lstbk)
                    fpnlBooking.Controls.Add(item);
            }
        }

        private void btn2_Click(object sender, EventArgs e, double quantity)
        {
            if (nud.Value > Decimal.Parse(quantity.ToString()))
                MessageBox.Show("Quantity error! " + quantity.ToString());
            else nud.Value += 1;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e, double quantity)
        {
            NumericUpDown nd = (NumericUpDown)sender;
            if (nd.Maximum < Decimal.Parse(quantity.ToString()))
            {
                MessageBox.Show("Max quantity is: " + quantity.ToString());
                nd.Value = Decimal.Parse(quantity.ToString());
            }
        }

        private void Booking_Form_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e) // Work!!!!!!!!!!!
        {
            List<string> lstcar = new List<string>();
            List<string> lstpath = new List<string>();
            List<string> soLuong = new List<string>();
            bool check = false;

            foreach (var item in lstbk)
            {
                if (item.cb.Checked == true)
                {
                    payment_Carpath.Add(item.car_Path);
                    if (item.nud.Value != 0)
                    {
                        soLuong.Add(item.nud.Value.ToString());
                        check = true;
                    }
                    else
                        MessageBox.Show("Mời bạn chọn số lượng xe!");
                    lstcar.Add(item.Name);
                }
            }

            if (lstcar.Count() == 0)
                MessageBox.Show("Mời bạn chọn xe cần mua!");
            else if (check == true)
            {
                new Payment(this, member_id, lstcar, payment_Carpath, soLuong).Show();
                this.Hide();
            }
        }

        private void cbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTatCa.Checked == true)
            {
                foreach (var item in lstbk)
                {
                    item.cb.Checked = true;
                }
            }
            else
            {
                foreach (var item in lstbk)
                {
                    item.cb.Checked = false;
                }
            }
        }

        private string GetCarInfo(string car_name)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select car_name, car_class_name, color, energy_type, car_seat, price, intitial_quantity " +
                "from car inner join car_class on car_class = car_class_id " +
                "where car_name = @car_name";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select car_name, car_class_name, color, energy_type, car_seat, price, intitial_quantity " +
            //        "from car inner join car_class on car_class = car_class_id " +
            //        "where car_name = @car_name";
            //command.Connection = conn;

            SqlParameter parCar_name = new SqlParameter("@car_name", SqlDbType.VarChar);
            parCar_name.Value = car_name;
            command.Parameters.Add(parCar_name);

            SqlDataReader reader = command.ExecuteReader();
            string car_info = "";
            if (reader.Read())
            {
                string carname = reader.GetString(0);
                string carclass = reader.GetString(1);
                string carcolor = reader.GetString(2);
                string energytype = reader.GetString(3);
                string seat = reader.GetInt32(4).ToString();
                string price = reader.GetDouble(5).ToString();
                string quantity = reader.GetDouble(6).ToString();
                car_info = "Name: Mercedes-benz " + carname + "           Class: " + carclass +
                    "\n" + "Color: " + carcolor + "                           Seat: " + seat + "\n" + "Energy type: " + energytype +
                    "\nPrice: " + price + "VND               Quantity: " + quantity;
            }
            reader.Close();

            return car_info;
        }

        private double GetPrice(string car_name)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select price from car where car_name = @car_name";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select price from car where car_name = @car_name";
            //command.Connection = conn;

            SqlParameter parCar_name = new SqlParameter("@car_name", SqlDbType.VarChar);
            parCar_name.Value = car_name;
            command.Parameters.Add(parCar_name);

            SqlDataReader reader = command.ExecuteReader();
            double price = 0f;
            if (reader.Read())
                price = reader.GetDouble(0);
            reader.Close();

            return price;
        }

        private double GetQuantity(string car_name)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select intitial_quantity from car where car_name = @car_name";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select intitial_quantity from car where car_name = @car_name";
            //command.Connection = conn;

            SqlParameter parCar_name = new SqlParameter("@car_name", SqlDbType.VarChar);
            parCar_name.Value = car_name;
            command.Parameters.Add(parCar_name);
            
            SqlDataReader reader = command.ExecuteReader();
            double soluong = 0f;
            if (reader.Read())
                soluong = reader.GetDouble(0);
            reader.Close();

            return soluong;
        }
    }
}
