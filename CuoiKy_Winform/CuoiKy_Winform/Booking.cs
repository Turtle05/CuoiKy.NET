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
        List<string> pcb_path = new List<string>();
        List<string> car_Name = new List<string>();

        SqlConnection conn = null;
        string strConn = @"SERVER= DESKTOP-9D12B9G\SQLEXPRESS; Database=ShopOTo; User Id = sa; pwd=12345";
        string strConn2 = @"data source=HAUTRI\SQLEXPRESS; Initial Catalog = ShopOTo; Integrated Security = True";

        List<BookingItem> lstbk = new List<BookingItem>();

        PictureBox pcbcar;
        TextBox txt_quantity;
        Label lb_info;
        Button btn1, btn2;
        NumericUpDown nud;
        FlowLayoutPanel fpnl;
        CheckBox cb;

        List<PictureBox> lstpcbcar;
        List<TextBox> lsttxt_quantity;
        List<Label> lstlb_info;
        List<Button> lstbtn1, lstbtn2;
        List<NumericUpDown> lstnud = new List<NumericUpDown>();
        List<FlowLayoutPanel> lstfpnl = new List<FlowLayoutPanel>();
        List<CheckBox> lstcb = new List<CheckBox>();
        List<string> click_fpnl = new List<string>();
        double []quantity = new double[50];

        public Booking()
        {
            InitializeComponent();
        }

        public Booking(List<string> carname,List<string> path)
        {
            InitializeComponent();
            //pcb_path.Add(path);

            //List<PictureBox> pcbCar = new List<PictureBox>();
            //pcbCar.Add(Car); i++;
            //pcbCar[i].Image = Image.FromFile(pcb_path[i]);
            //pcbCar[i].SizeMode = PictureBoxSizeMode.StretchImage;
            //pcbCar[i].Size = new System.Drawing.Size(170, 140);

            ////fpnlBooking.Controls.Add(pcbCar[i]);

            car_Name = carname;
            pcb_path = path;
            fpnlBooking.FlowDirection = FlowDirection.TopDown;

            //string n = "";
            //for (int i = 0;i < car_Name.Count();i++)
            //{
            //    n = n + car_Name[i];
            //}
            //MessageBox.Show(n);

            for (int i = 0; i < pcb_path.Count(); i++)
            {
                BookingItem bkitem = new BookingItem();
                bkitem.pcbcar = new PictureBox();
                bkitem.lb_info = new Label();
                bkitem.nud = new NumericUpDown();
                //bkitem.lstnud = new List<NumericUpDown>();
                bkitem.cb = new CheckBox();
                //bkitem.lstcb = new List<CheckBox>();

                bkitem.Size = new Size(678, 150);
                bkitem.AutoScroll = true;
                bkitem.FlowDirection = FlowDirection.LeftToRight;
                bkitem.Name = car_Name[i];

                bkitem.pcbcar.Image = Image.FromFile(pcb_path[i]);
                bkitem.pcbcar.SizeMode = PictureBoxSizeMode.StretchImage;
                bkitem.pcbcar.Size = new System.Drawing.Size(180, 130);


                bkitem.lb_info.Text = GetCarInfo(car_Name[i]);
                bkitem.lb_info.Size = new System.Drawing.Size(320, 80); bkitem.lb_info.AutoSize = false; bkitem.lb_info.Font = new Font(bkitem.lb_info.Font, FontStyle.Bold);


                quantity[i] = GetQuantity(car_Name[i]);
                bkitem.nud.Maximum = Decimal.Parse(quantity[i].ToString());
                bkitem.nud.Size = new System.Drawing.Size(50, 30);
                bkitem.nud.ValueChanged += (sender, e) => NumericUpDown_ValueChanged(bkitem.nud, e, quantity[i]);
                //bkitem.lstnud.Add(bkitem.nud);
                //bkitem.lstnud[i].Maximum = Decimal.Parse(quantity[i].ToString());
                //bkitem.lstnud[i].Size = new System.Drawing.Size(50, 30);
                //bkitem.lstnud[i].ValueChanged += (sender, e) => NumericUpDown_ValueChanged(bkitem.nud, e, quantity[i], bkitem.lstnud);


                bkitem.cb.Name = car_Name[i];
                bkitem.cb.Text = "";
                //bkitem.lstcb.Add(bkitem.cb);


                bkitem.Name = car_Name[i];
                bkitem.Controls.Add(bkitem.pcbcar);
                bkitem.Controls.Add(bkitem.lb_info);
                bkitem.Controls.Add(bkitem.nud);
                bkitem.Controls.Add(bkitem.cb);

                lstbk.Add(bkitem);

                //    // Initial code
                //    //fpnl = new FlowLayoutPanel();
                //    //fpnl.Size = new Size(678, 150);
                //    //fpnl.AutoScroll = true;
                //    //fpnl.FlowDirection = FlowDirection.LeftToRight;
                //    //fpnl.Name = car_Name[i];
                //    //lstfpnl.Add(fpnl);

                //    //pcbcar = new PictureBox();
                //    //lb_info = new Label();

                //    //pcbcar.Image = Image.FromFile(pcb_path[i]);
                //    //pcbcar.SizeMode = PictureBoxSizeMode.StretchImage;
                //    //pcbcar.Size = new System.Drawing.Size(180, 130);


                //    //quantity[i] = GetQuantity(car_Name[i]);
                //    //nud = new NumericUpDown();
                //    //lstnud.Add(nud);
                //    //lstnud[i].Maximum = Decimal.Parse(quantity[i].ToString());
                //    //lstnud[i].Size = new System.Drawing.Size(50, 30);
                //    //lstnud[i].ValueChanged += (sender, e) => NumericUpDown_ValueChanged(nud, e, quantity[i], lstnud);
                //    ////nud.KeyUp += (sender, e) => KeyUp(nud, e, quantity[i]);

                //    //lb_info.Text = GetCarInfo(car_Name[i]);
                //    //lb_info.Size = new System.Drawing.Size(320, 80); lb_info.AutoSize = false; lb_info.Font = new Font(lb_info.Font, FontStyle.Bold);

                //    //cb = new CheckBox();
                //    //cb.Name = car_Name[i];
                //    //cb.Text = "";
                //    //lstcb.Add(cb);
                //    ////lstcb[i].CheckedChanged += (sender, e) => cb_CheckedChanged(cb, e, cb, cb.Name);


                //    ////lstpcbcar.Add(pcbcar);
                //    ////lstlb_info.Add(lb_info);
                //    ////lsttxt_quantity.Add(txt_quantity);
                //    ////lstbtn1.Add(btn1);
                //    ////lstbtn2.Add(btn2);

                //    //fpnl.Name = car_Name[i];
                //    //fpnl.Controls.Add(pcbcar);
                //    //fpnl.Controls.Add(lb_info);
                //    ////fpnl.Controls.Add(btn1);
                //    ////fpnl.Controls.Add(txt_quantity);
                //    ////fpnl.Controls.Add(btn2);
                //    //fpnl.Controls.Add(lstnud[i]);
                //    //fpnl.Controls.Add(lstcb[i]);

                //    //foreach (var flpnl in lstfpnl)
                //    //{
                //    //    FlowLayoutPanel p = flpnl;
                //    //    p.Click += new EventHandler(flpnl_Click);
                //    //}

                //    //foreach (var item in lstcb)
                //    //{
                //    //    if (item.Checked == true)
                //    //        item.CheckedChanged += (sender, e) => cb_CheckedChanged(item, e, item, item.Name);
                //    //}

                foreach (var item in lstbk)
                    fpnlBooking.Controls.Add(item);


                //    //foreach (var item in lstfpnl)
                //    //{
                //    //    fpnlBooking.Controls.Add(item);
                //    //}
            }
        }

        // Create event click button +/-
        private void btn1_Click(object sender, EventArgs e, double quantity)
        {
            //if (nud.Value < 0)
            //    MessageBox.Show("Quantity error! " + quantity.ToString());
            //else nud.Value -= 1;
        }
        private void cb_CheckedChanged(object sender, EventArgs e, CheckBox cbx, string carname)
        {
            //CheckBox checkb = (CheckBox)sender;
            //foreach (var item in lstcb)
            //    if (checkb.Checked == true && item.Name == checkb.Name)
            //        new Payment(item.Name).Show();
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox checkb = (CheckBox)sender;
            //foreach (var item in lstcb)
            //    if (checkb.Checked == true && item.Name == checkb.Name)
            //        new Payment(item.Name).Show();
        }


        private void fpnl_Click(object sender, EventArgs e, FlowLayoutPanel fpnl)
        {
            fpnl.BackColor = Color.AliceBlue;
        }

        private void flpnl_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel p = (FlowLayoutPanel)sender;
            string n = "";

            if (click_fpnl.Contains(p.Name))
            {
                MessageBox.Show(p.Name);
                p.BackColor = Color.Transparent;
                click_fpnl.Remove(p.Name);
            }
            else
            {
                p.BackColor = Color.AliceBlue;
                click_fpnl.Add(p.Name);
                MessageBox.Show("Add " + p.Name);
            }

            foreach (var name in click_fpnl)
            {
                n = name + " ";
            }
            MessageBox.Show(n);
        }

        private void btn2_Click(object sender, EventArgs e, double quantity)
        {
            if (nud.Value > Decimal.Parse(quantity.ToString()))
                MessageBox.Show("Quantity error! " + quantity.ToString());
            else nud.Value += 1;
        }

        //private void NumericUpDown_ValueChanged(object sender, EventArgs e, double quantity, List<NumericUpDown> lstnud)
        //{
        //    foreach (var item in lstnud)
        //    {
        //        if (nud.Maximum < Decimal.Parse(quantity.ToString()))
        //        {
        //            MessageBox.Show("Max quantity is: " + quantity.ToString());
        //            item.Value = Decimal.Parse(quantity.ToString());
        //        }
        //    }
        //}

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
            foreach (var item in lstbk)
            {
                if (item.cb.Checked == true)
                {
                    lstcar.Add(item.Name);
                }
            }

            new Payment(lstcar).Show();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            foreach (var item in lstcb)
            {
                if (item.Checked == true)
                {
                    MessageBox.Show("This is " + item.Name + " click");
                    item.CheckedChanged += new EventHandler(cb_CheckedChanged);
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
            //command.CommandText = "select car_info from car where car_name = @car_name";
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

                car_info = "Name: Mercedes-benz " + carname + "        " + "Class: " + carclass +
                    "\n" + "Color: " + carcolor + "                " + "Seat: " + seat + "\n" + "Energy type: " + energytype;
            }
            reader.Close();

            return car_info;
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
            //command.CommandText = "select car_info from car where car_name = @car_name";
            //command.Connection = conn;

            SqlParameter parCar_name = new SqlParameter("@car_name", SqlDbType.VarChar);
            parCar_name.Value = car_name;
            command.Parameters.Add(parCar_name);

            SqlDataReader reader = command.ExecuteReader();
            double sl = 0;
            if (reader.Read())
            {
                sl = reader.GetDouble(0);
            }
            reader.Close();

            return sl;
        }
    }
}
