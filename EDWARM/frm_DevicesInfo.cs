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
            dgv_CardInformation.DataSource = dthandle.loadTable(cmd);
            count();
            txt_DeviceID.Text = count().ToString();
        }

        int count()
        {
            SqlCommand cmd = new SqlCommand("countIdDevices", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            int c = dthandle.exScala(cmd);
            return c + 1;
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
    }
}
