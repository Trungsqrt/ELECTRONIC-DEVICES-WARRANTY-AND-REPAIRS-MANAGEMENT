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

namespace EDWARM
{
    public partial class frm_CustomersInfo : Form
    {
        public frm_CustomersInfo()
        {
            InitializeComponent();
        }

        #region event not use
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_CusInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void txt_CUSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {

        }
        #endregion
        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_CustomersInfo_Load(object sender, EventArgs e)
        {
            load();
        }
        DatabaseHandle dthandle = new DatabaseHandle();
        void load()
        {
            SqlCommand cmd = new SqlCommand("SPload", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            dgv_CusInformation.DataSource =  dthandle.loadTable(cmd);
            count();
            txt_CusID.Text = count().ToString();
        }

        private void dgv_CusInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CusID.ReadOnly = true;
            txt_Name.Text = dgv_CusInformation.CurrentRow.Cells["name"].Value.ToString();
            dateTimePicker_DoB.Text = dgv_CusInformation.CurrentRow.Cells["dob"].Value.ToString();
            txt_Phone.Text = dgv_CusInformation.CurrentRow.Cells["phone"].Value.ToString();
            txt_Email.Text = dgv_CusInformation.CurrentRow.Cells["email"].Value.ToString();
            txt_Adress.Text = dgv_CusInformation.CurrentRow.Cells["address"].Value.ToString();
            txt_CusID.Text = dgv_CusInformation.CurrentRow.Cells["customer_id"].Value.ToString();
            btn_Add.Enabled = false;
            btn_Add.BackColor = Color.FromArgb(220, 220, 220);
        }
        bool isNullorEmpty(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            if (s1 == null || s1 == "" ||
                s2 == null || s2 == "" ||
                s3 == null || s3 == "" ||
                s4 == null || s4 == "" ||
                s5 == null || s5 == "" ||
                s6 == null || s6 == "")
                return true;
            return false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isNullorEmpty(txt_CusID.Text, txt_Name.Text,
                dateTimePicker_DoB.Text, txt_Phone.Text,
                txt_Email.Text, txt_Adress.Text))
                MessageBox.Show("Không được để trống");
            else if (txt_Phone.Text.All(Char.IsLetter))
                MessageBox.Show("Số điện thoại phải là số");
            else
            {
                SqlCommand cmd = new SqlCommand("SPAdd", dthandle.getConnectionString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", txt_CusID.Text);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker_DoB.Value);
                cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@address", txt_Adress.Text);
                dthandle.exNonQuery(cmd);
                load();
            }
        }

        int count()
        {
            string query = "select max(customer_id) from customer";

            var c = dthandle.exScala(query);
            return 1 + c;
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            if (isNullorEmpty(txt_CusID.Text, txt_Name.Text,
                dateTimePicker_DoB.Text, txt_Phone.Text,
                txt_Email.Text, txt_Adress.Text))
                MessageBox.Show("Không được để trống");
            else if (txt_Phone.Text.All(Char.IsLetter))
                MessageBox.Show("Số điện thoại phải là số");
            else
            {
                SqlCommand cmd = new SqlCommand("SPUpdate", dthandle.getConnectionString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", txt_CusID.Text);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker_DoB.Value);
                cmd.Parameters.AddWithValue("@phone", txt_Phone.Text);
                cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@address", txt_Adress.Text);
                dthandle.exNonQuery(cmd);
                load();
                clearTb();
                btn_Add.Enabled = true;
                btn_Add.BackColor = Color.FromArgb(235, 124, 104);
            }
        }

        void clearTb()
        {
            txt_Email.Clear();
            txt_Name.Clear();
            txt_Phone.Clear();
            txt_Adress.Clear();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("SPDelete", dthandle.getConnectionString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customer_id", txt_CusID.Text);
                dthandle.exNonQuery(cmd);
                load();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from customer where customer_id like '%" + txt_search.Text + "%'";
            dgv_CusInformation.DataSource = dthandle.LoadBang(sql);
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clearTb();
            btn_Add.Enabled = true;
            btn_Add.BackColor = Color.FromArgb(235, 124, 104);
            count();
            txt_CusID.Text = count().ToString();
        }
    }
}
