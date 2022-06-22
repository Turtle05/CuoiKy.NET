using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using SortOrder = System.Data.SqlClient.SortOrder;
using System.Globalization;

namespace CuoiKy_Winform
{
    public partial class Form_Car : Form
    {
        public Form_Car()
        {
            InitializeComponent();
        }
        string strConn1 = @"data source = MUNKY\SQLEXPRESS; Database = ShopOTo; Integrated Security = True";

        SqlConnection conn = null;

        private void Form_Car_Load(object sender, EventArgs e)
        {
            HienThiToanBoCar();
        }

        // Hàm mở kết nối
        private void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn1);
            }
            if(conn.State == ConnectionState.Closed)
                conn.Open();
        }
        
        // Hàm đóng kết nối 
        private void CloseConnection()
        {
            if(conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void HienThiToanBoCar()
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from car";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                lvCar.Items.Clear();
                while (reader.Read())
                {
                    int car_id = reader.GetInt32(0);
                    string car_name = reader.GetString(1);
                    string car_type = reader.GetString(2);
                    string car_class = reader.GetString(3);
                    string color = reader.GetString(4);
                    int car_seat = reader.GetInt32(5);
                    string energy_type = reader.GetString(6);
                    double price = reader.GetDouble(7);
                    string car_info = reader.GetString(8);
                    double intitial_quantity = reader.GetDouble(9);
                    //ListViewItem lvi = new ListViewItem((lvCar.Items.Count + 1) +"");
                    ListViewItem lvi = new ListViewItem(car_id +"");
                    //lvi.SubItems.Add(car_id + "");
                    lvi.SubItems.Add(car_name);
                    lvi.SubItems.Add(car_type);
                    lvi.SubItems.Add(car_class);
                    lvi.SubItems.Add(color);
                    lvi.SubItems.Add(car_seat + "");
                    lvi.SubItems.Add(energy_type);
                    lvi.SubItems.Add(price + "");
                    lvi.SubItems.Add(intitial_quantity + "");

                    lvCar.Items.Add(lvi);
                    lvi.Tag = car_id;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCar.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvCar.SelectedItems[0];
            int car_id = (int)lvi.Tag;
            HienThiChiTiet(car_id);
        }
        private void HienThiChiTiet(int car_id)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from car where @car_id = car_id";
                command.Connection = conn;
                SqlParameter parCar_id = new SqlParameter("@car_id", SqlDbType.Int);
                parCar_id.Value = car_id;
                command.Parameters.Add(parCar_id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string car_name = reader.GetString(1);
                    string car_type = reader.GetString(2);
                    string car_class = reader.GetString(3);
                    string color = reader.GetString(4);
                    int car_seat = reader.GetInt32(5);
                    string energy_type = reader.GetString(6);
                    double price = reader.GetDouble(7);
                    string car_info = reader.GetString(8);
                    double intitial_quantity = reader.GetDouble(9);

                    txtCarID.Text = car_id + "";
                    txtCarName.Text = car_name;
                    cbCarType.Text = car_type;
                    cbCarClass.Text = car_class;    
                    txtColor.Text = color;
                    txtCarSeat.Text = car_seat + "";
                    cbEnergyType.Text = energy_type;
                    txtPrice.Text = price + "";
                    txtCarInfo.Text = car_info;
                    txtIntitialQuantity.Text = intitial_quantity + "";

                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BUTTON NEW
        private void btNew_Click(object sender, EventArgs e)
        {
            txtCarID.Text = "";
            txtCarInfo.Text = "";
            txtCarName.Text = "";
            txtCarSeat.Text = "";
            txtColor.Text = "";
            txtIntitialQuantity.Text = "";
            txtPrice.Text = "";
            cbCarClass.Text = "";
            cbCarType.Text = "";
            cbEnergyType.Text = "";
            txtCarID.Focus();
        }

        // BUTTON UPDATE
        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "update car set car_name = @car_name, cartype = @car_type, car_class = @car_class, color = @color, car_seat = @car_seat, energy_type = @energy_type, price = @price, car_info = @car_info, intitial_quantity = @intitial_quantity where car_id = @car_id";
                command.CommandText = sql;
                command.Connection = conn;

                command.Parameters.Add("@car_name", SqlDbType.VarChar).Value = txtCarName.Text;
                command.Parameters.Add("@car_type", SqlDbType.NVarChar).Value = cbCarType.Text;
                command.Parameters.Add("@car_class", SqlDbType.NVarChar).Value = cbCarClass.Text;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = txtColor.Text;
                command.Parameters.Add("@car_seat", SqlDbType.Int).Value = Convert.ToInt32(txtCarSeat.Text);
                command.Parameters.Add("@energy_type", SqlDbType.NVarChar).Value = cbEnergyType.Text;
                command.Parameters.Add("@price", SqlDbType.Float).Value = Convert.ToDouble(txtPrice.Text);
                command.Parameters.Add("@car_info", SqlDbType.NVarChar).Value = txtCarInfo.Text;
                command.Parameters.Add("@intitial_quantity", SqlDbType.Float).Value = Convert.ToDouble(txtIntitialQuantity.Text);
                command.Parameters.Add("@car_id", SqlDbType.Int).Value = Convert.ToInt32(txtCarID.Text);


                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    HienThiToanBoCar();
                    MessageBox.Show("Successfully updated");
                    btNew.PerformClick();
                }
                else
                {
                    MessageBox.Show("Update information failed");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BUTTON DELETE
        private void btDelete_Click(object sender, EventArgs e)
        {
            if(lvCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have not selected Car you want to delete!");
                return;
            }
            ListViewItem lvi = lvCar.SelectedItems[0];
            int car_id = (int)lvi.Tag;
            DialogResult ret = MessageBox.Show("Are you sure you want to delete Car_ID ["+ car_id +"]?",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ret == DialogResult.Yes)
            {
                try
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from car where car_id = @car_id";
                    command.Connection = conn;
                    command.Parameters.Add("@car_id", SqlDbType.Int).Value = car_id;

                    int kq = command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        HienThiToanBoCar();
                        MessageBox.Show("Successfully deleted");
                        btNew.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Delete information failed");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // BUTTON EXIT
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // SORT
        private void lvCar_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = lvCar.ListViewItemSorter as ItemComparer;
            
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                lvCar.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if(e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if(sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                }
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            lvCar.Sort();
        }

        // SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string t = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSearch.Text.ToLower());
            if(txtSearch.Text == "")
            {
                MessageBox.Show("You have not entered the information you want to find");
                return;
            }
            for (int i = 0; i < lvCar.Items.Count; i++)
            {
                if (lvCar.Items[i].SubItems[0].Text.ToString() == t
                    || lvCar.Items[i].SubItems[1].Text == t
                    || lvCar.Items[i].SubItems[2].Text == t
                    || lvCar.Items[i].SubItems[3].Text == t
                    || lvCar.Items[i].SubItems[4].Text == t)
                {
                    MessageBox.Show("Founded!");
                    txtSearch.Text = "";
                    return;
                }
            }
            MessageBox.Show("Not found!");
            txtSearch.Text = "";

        }
    }
}
