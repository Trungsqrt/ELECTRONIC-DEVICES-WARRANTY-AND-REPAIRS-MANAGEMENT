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

namespace EDWARM
{
    public partial class frm_DevicesInfo : Form
    {
        public frm_DevicesInfo()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DevicesInfo_Load(object sender, EventArgs e)
        {
            load();
            loadCbBox();
        }
        DatabaseHandle dthandle = new DatabaseHandle();
        void load()
        {
            SqlCommand cmd = new SqlCommand("SPloadDevices", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            dgv_devices.DataSource = dthandle.loadTable(cmd);
            count();
            txt_DeviceID.Text = count().ToString();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPAddDevices", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@device_id", txt_DeviceID.Text);
            cmd.Parameters.AddWithValue("@serial", txt_Serial.Text);
            cmd.Parameters.AddWithValue("@dayPurchase", dateTimePicker_DoPurchase.Value);
            cmd.Parameters.AddWithValue("@periodWarranty", int.Parse(nud_pow.Text));
            cmd.Parameters.AddWithValue("@customer_id", cb_CusID.Text);
            cmd.Parameters.AddWithValue("@price", nud_p.Text);
            cmd.Parameters.AddWithValue("@description", txt_des.Text);
            dthandle.exNonQuery(cmd);
            load();
        }
        void loadCbBox()
        {
            SqlCommand cmd = new SqlCommand("SPLoadCB", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cb_CusID.DisplayMember = "customer_id";
            cb_CusID.ValueMember = "customer_id";
            cb_CusID.DataSource = dthandle.loadTable(cmd);
        }

        private void dgv_CardInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_DeviceID.Text = dgv_devices.CurrentRow.Cells["device_id"].Value.ToString();
            txt_Serial.Text = dgv_devices.CurrentRow.Cells["serial"].Value.ToString();
            dateTimePicker_DoPurchase.Text = dgv_devices.CurrentRow.Cells["dayPurchase"].Value.ToString();
            nud_pow.Text = dgv_devices.CurrentRow.Cells["periodWarranty"].Value.ToString();
            cb_CusID.Text = dgv_devices.CurrentRow.Cells["customer_id"].Value.ToString();
            nud_p.Text = dgv_devices.CurrentRow.Cells["price"].Value.ToString();
            txt_des.Text = dgv_devices.CurrentRow.Cells["description"].Value.ToString();
            btn_Add.Enabled = false;
            btn_Add.BackColor = Color.FromArgb(220, 220, 220);
        }

        int count()
        {
            string query = "select max(device_id) from electronic";

            var c = dthandle.exScala(query);
            return 1 + c;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPDeleteDevices", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@device_id", txt_DeviceID.Text);
            dthandle.exNonQuery(cmd);
            load();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPUpdateDevices", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@device_id", txt_DeviceID.Text);
            cmd.Parameters.AddWithValue("@serial", txt_Serial.Text);
            cmd.Parameters.AddWithValue("@dayPurchase", dateTimePicker_DoPurchase.Value);
            cmd.Parameters.AddWithValue("@periodWarranty", nud_pow.Text);
            cmd.Parameters.AddWithValue("@price", nud_p.Text);
            cmd.Parameters.AddWithValue("@description", txt_des.Text);
            cmd.Parameters.AddWithValue("@customer_id", cb_CusID.Text);
            dthandle.exNonQuery(cmd);
            load();
            clearTb();
            btn_Add.Enabled = true;
            btn_Add.BackColor = Color.FromArgb(235, 124, 104);
        }

        void clearTb()
        {
            txt_Serial.Clear();
            nud_pow.Value = 0;
            txt_des.Clear();
            nud_p.Value = 0;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from electronic where device_id like '%" + txt_search.Text + "%'";
            dgv_devices.DataSource = dthandle.LoadBang(sql);
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
            txt_DeviceID.Text = count().ToString();
        }
    }
}
