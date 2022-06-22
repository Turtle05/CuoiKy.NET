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
using SortOrder = System.Data.SqlClient.SortOrder;

namespace CuoiKy_Winform
{
    public partial class Form_UserAccount : Form
    {
        public Form_UserAccount()
        {
            InitializeComponent();
        }

        string strConn1 = @"data source = MUNKY\SQLEXPRESS; Database = ShopOTo; Integrated Security = True";
        
        SqlConnection conn = null;

        // Hàm mở kết nối
        private void OpenConnection()
        {
            if (conn == null)
            {
                // Ngo
                conn = new SqlConnection(strConn1);
                //
                //
            }
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        // Hàm đóng kết nối 
        private void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void Form_UserAccount_Load(object sender, EventArgs e)
        {
            HienThiToanBoUser();
        }

        private void HienThiToanBoUser()
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from member";
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                lvUserAccount.Items.Clear();
                while (reader.Read())
                {
                    int member_id = reader.GetInt32(0);
                    string member_name = reader.GetString(1);
                    string gender = reader.GetString(2);
                    string nationality = reader.GetString(3);
                    string addr = reader.GetString(4);
                    string phone = reader.GetString(5);
                    string role = reader.GetString(8);
                    ListViewItem lvi = new ListViewItem((lvUserAccount.Items.Count + 1) + "");
                    lvi.SubItems.Add(member_id + "");
                    lvi.SubItems.Add(member_name);
                    lvi.SubItems.Add(gender);
                    lvi.SubItems.Add(nationality);
                    lvi.SubItems.Add(addr);
                    lvi.SubItems.Add(phone);
                    lvi.SubItems.Add(role);

                    lvUserAccount.Items.Add(lvi);
                    lvi.Tag = member_id;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvUserAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUserAccount.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvUserAccount.SelectedItems[0];
            int member_id = (int)lvi.Tag;
            HienThiChiTiet(member_id);
        }

        private void HienThiChiTiet(int member_id)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from member where @member_id = member_id";
                command.Connection = conn;
                SqlParameter parMember_id = new SqlParameter("@member_id", SqlDbType.Int);
                parMember_id.Value = member_id;
                command.Parameters.Add(parMember_id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string member_name = reader.GetString(1);
                    string gender = reader.GetString(2);
                    string nationality = reader.GetString(3);
                    string addr = reader.GetString(4);
                    string phone = reader.GetString(5);
                    string email = reader.GetString(6);
                    string role = reader.GetString(8);

                    txtMemberID.Text = member_id + "";
                    txtMemberName.Text = member_name;
                    txtGender.Text = gender;
                    txtNationality.Text = nationality;
                    txtAddress.Text = addr;
                    txtPhone.Text = phone;
                    txtEmail.Text = email;
                    cbRole.Text = role;

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BUTTON NEW
        private void btNew_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = "";
            txtMemberName.Text = "";
            txtGender.Text = "";
            txtNationality.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbRole.Text = "";
            txtMemberID.Focus();
        }

        // BUTTON SAVE
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "insert into member values (@member_name, @gender, @nationality, @addr, @phone, @email, @pass, @role)";
                command.CommandText = sql;
                command.Connection = conn;

                command.Parameters.Add("@member_name", SqlDbType.NVarChar).Value = txtMemberName.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = txtGender.Text;
                command.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = txtNationality.Text;
                command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = txtAddress.Text;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = "";
                command.Parameters.Add("@role", SqlDbType.VarChar).Value = cbRole.Text;

                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    HienThiToanBoUser();
                    MessageBox.Show("Successfully saved");
                    btNew.PerformClick();
                }
                else
                {
                    MessageBox.Show("Save information failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BUTTON UPDATE
        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "update member set member_name = @member_name, gender = @gender, nationality = @nationality, addr = @addr, phone = @phone, email = @email, pass = @pass, role = @role where member_id = @member_id";
                command.CommandText = sql;
                command.Connection = conn;

                command.Parameters.Add("@member_name", SqlDbType.NVarChar).Value = txtMemberName.Text;
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = txtGender.Text;
                command.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = txtNationality.Text;
                command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = txtAddress.Text;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhone.Text;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = "";
                command.Parameters.Add("@role", SqlDbType.VarChar).Value = cbRole.Text;
                command.Parameters.Add("@member_id", SqlDbType.Int).Value = Convert.ToInt32(txtMemberID.Text);


                int kq = command.ExecuteNonQuery();
                if (kq > 0)
                {
                    HienThiToanBoUser();
                    MessageBox.Show("Successfully updated");
                    btNew.PerformClick();
                }
                else
                {
                    MessageBox.Show("Update information failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BUTTON DELETE
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvUserAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have not selected User you want to delete!");
                return;
            }
            ListViewItem lvi = lvUserAccount.SelectedItems[0];
            int member_id = (int)lvi.Tag;
            DialogResult ret = MessageBox.Show("Are you sure you want to delete Member_ID [" + member_id + "]?",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    OpenConnection();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "delete from member where member_id = @member_id";
                    command.Connection = conn;
                    command.Parameters.Add("@member_id", SqlDbType.Int).Value = member_id;

                    int kq = command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        HienThiToanBoUser();
                        MessageBox.Show("Successfully deleted");
                        btNew.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Delete information failed");
                    }

                }
                catch (Exception ex)
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
        private void lvUserAccount_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = lvUserAccount.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                lvUserAccount.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
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
            lvUserAccount.Sort();
        }
    }
}
