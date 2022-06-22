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
    public partial class Payment : Form
    {
        List<string> lstCar;
        List<string> soluong;
        List<BookingItem> lstbk = new List<BookingItem>();
        string member_id;

        Booking frmBooking;

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(Booking parent, string memberid, List<string> lstcar, List<string> payment_Carpath, List<string> soLuong)
        {
            InitializeComponent();

            member_id = memberid;
            frmBooking = parent;
            lstCar = new List<string>();
            lstCar = lstcar;

            soluong = new List<string>();
            soluong = soLuong;

            MessageBox.Show(member_id);

            for (int i = 0; i < lstCar.Count(); i++)
            {
                BookingItem bkitem = new BookingItem();
                bkitem.pcbcar = new PictureBox();
                bkitem.lb_info = new Label();
                bkitem.nud = new NumericUpDown();
                bkitem.lb_soluong = new Label();
                //bkitem.lstnud = new List<NumericUpDown>();
                bkitem.cb = new CheckBox();
                //bkitem.lstcb = new List<CheckBox>();

                bkitem.Size = new Size(600, 150);
                bkitem.AutoScroll = true;
                bkitem.FlowDirection = FlowDirection.LeftToRight;
                bkitem.Name = lstCar[i];

                bkitem.pcbcar.Image = Image.FromFile(payment_Carpath[i]);
                bkitem.pcbcar.SizeMode = PictureBoxSizeMode.StretchImage;
                bkitem.pcbcar.Size = new System.Drawing.Size(180, 130);


                bkitem.lb_info.Text = GetCarInfo(lstCar[i]);
                bkitem.lb_info.Size = new System.Drawing.Size(300, 80); bkitem.lb_info.AutoSize = false; bkitem.lb_info.Font = new Font("Times New Roman", 9, FontStyle.Bold);
                bkitem.lb_soluong.Text = "Số lượng:  " + soluong[i];
                bkitem.lb_soluong.Font = new Font("Times New Roman", 9, FontStyle.Bold);

                bkitem.Name = lstCar[i];
                bkitem.Controls.Add(bkitem.pcbcar);
                bkitem.Controls.Add(bkitem.lb_info);
                bkitem.Controls.Add(bkitem.lb_soluong);

                lstbk.Add(bkitem);

                fpnlPayment.AutoScroll = true;
                fpnlPayment.FlowDirection = FlowDirection.TopDown;
                foreach (var item in lstbk)
                    fpnlPayment.Controls.Add(item);
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
            command.CommandText = "select car_name, car_class_name, color, energy_type, car_seat " +
                "from car inner join car_class on car_class = car_class_id " +
                "where car_name = @car_name";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select car_name, car_class_name, color, energy_type, car_seat " +
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

                car_info = "Name: Mercedes-benz " + carname + "           " + "Class: " + carclass +
                    "\n" + "Color: " + carcolor + "                     " + "Seat: " + seat + "\n" + "Energy type: " + energytype;
            }
            reader.Close();

            return car_info;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xác nhận thanh toán?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công. Cảm ơn bạn đã mua xe của chúng tôi!");
                InsertBooking(lstCar, soluong);
                UpdateSoLuong(lstCar, soluong);
                this.Close();
                frmBooking.pcb_path.Clear();
                frmBooking.car_Name.Clear();
                frmBooking.Hide();
            }
            else
            {

            }    
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmBooking.Show();
        }

        public int GetCarId(string car_name)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select car_id from car where car_name = " + "'" + car_name + "'";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select car_id from car where car_name = " + "'" + car_name + "'";
            //command.Connection = conn;

            int carid = 0;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                carid = reader.GetInt32(0);
            reader.Close();
            return carid;
        }

        public double GetCarPrice(string car_name)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select price from car where car_name = " + "'" + car_name + "'";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select price from car where car_name = " + "'" + car_name + "'";
            //command.Connection = conn;

            double carprice = 0f;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                carprice = reader.GetDouble(0);
            reader.Close();
            return carprice;
        }

        public double GetCarInititalQuantity(string car_name)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select intitial_quantity from car where car_name = " + "'" + car_name + "'";
            command.Connection = conn;

            //if (conn == null)
            //    conn = new SqlConnection(strConn2);
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "select intitial_quantity from car where car_name = " + "'" + car_name + "'";
            //command.Connection = conn;

            double quantity = 0f;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                quantity = reader.GetDouble(0);
            reader.Close();
            return quantity;
        }

        public void InsertBooking(List<string> car_name, List<string> soluong)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            MessageBox.Show(car_name.Count().ToString());
            for (int i = 0; i < car_name.Count(); i++)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into booking " +
                    "values(@member_id, @car_id, @price, @quantity, @car_total_price)";
                command.Connection = conn;

                //if (conn == null)
                //    conn = new SqlConnection(strConn2);
                //if (conn.State == ConnectionState.Closed)
                //    conn.Open();

                //SqlCommand command = new SqlCommand();
                //command.CommandType = CommandType.Text;
                //command.CommandText = "insert into booking " +
                //"values(@member_id, @car_id, @price, @quantity, @car_total_price)";
                //command.Connection = conn;

                SqlParameter parId = new SqlParameter("@member_id", SqlDbType.Int);
                parId.Value = member_id;
                command.Parameters.Add(parId);
                SqlParameter parCarId = new SqlParameter("@car_id", SqlDbType.Int);
                parCarId.Value = GetCarId(car_name[i]);
                command.Parameters.Add(parCarId);
                SqlParameter parPrice = new SqlParameter("@price", SqlDbType.Float);
                parPrice.Value = GetCarPrice(car_name[i]);
                command.Parameters.Add(parPrice);
                SqlParameter parQuantity = new SqlParameter("@quantity", SqlDbType.Float);
                parQuantity.Value = soluong[i];
                command.Parameters.Add(parQuantity);
                SqlParameter parTotalPrice = new SqlParameter("@car_total_price", SqlDbType.Float);
                parTotalPrice.Value = float.Parse(soluong[i]) * GetCarPrice(car_name[i]);
                command.Parameters.Add(parTotalPrice);

                int ret = command.ExecuteNonQuery();
            }
        }

        public void UpdateSoLuong(List<string> car_name, List<string> soluong)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            for (int i = 0; i < car_name.Count(); i++)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update car set intitial_quantity = @soluong where car_name = @car_name";
                command.Connection = conn;

                //if (conn == null)
                //    conn = new SqlConnection(strConn2);
                //if (conn.State == ConnectionState.Closed)
                //    conn.Open();

                //SqlCommand command = new SqlCommand();
                //command.CommandType = CommandType.Text;
                //command.CommandText = "update car set intitial_quantity = @soluong where car_name = @CarName";
                //command.Connection = conn;

                SqlParameter parSoLuong = new SqlParameter("@soluong", SqlDbType.Float);
                parSoLuong.Value = GetCarInititalQuantity(car_name[i]) - float.Parse(soluong[i]);
                command.Parameters.Add(parSoLuong);
                SqlParameter parCar_name = new SqlParameter("@car_name", SqlDbType.VarChar);
                parCar_name.Value = car_name[i];
                command.Parameters.Add(parCar_name);

                SqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
        }
    }
}
