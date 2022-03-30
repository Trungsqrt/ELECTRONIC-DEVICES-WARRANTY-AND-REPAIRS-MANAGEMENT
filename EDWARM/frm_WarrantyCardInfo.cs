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
    public partial class frm_WarrantyCardInfo : Form
    {
        public frm_WarrantyCardInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            frm_ExportForCus frm = new frm_ExportForCus();
            frm.ShowDialog();
        }

        private void frm_WarrantyCardInfo_Load(object sender, EventArgs e)
        {
            load();
        }

        DatabaseHandle dthandle = new DatabaseHandle();
        void load()
        {
            SqlCommand cmd = new SqlCommand("SPloadWa", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            dgv_wc.DataSource = dthandle.loadTable(cmd);
            count();
            txt_CardID.Text = count().ToString();
            loadCbBox();
        }
        int count()
        {
            string query = "select max(card_id) from warcard";

            var c = dthandle.exScala(query);
            return 1 + c;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPAddCard", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@card_id", txt_CardID.Text);
            cmd.Parameters.AddWithValue("@delivery_date", dtPicker_Delivery.Value);
            cmd.Parameters.AddWithValue("@price_of_warranty", nud_pow.Value);
            cmd.Parameters.AddWithValue("@note", txt_Note.Text);
            cmd.Parameters.AddWithValue("@customer_id", cb_CusID.Text);
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPUpdateCard", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@card_id", txt_CardID.Text);
            cmd.Parameters.AddWithValue("@delivery_date", dtPicker_Delivery.Value);
            cmd.Parameters.AddWithValue("@price_of_warranty", nud_pow.Value);
            cmd.Parameters.AddWithValue("@note", txt_Note.Text);
            cmd.Parameters.AddWithValue("@customer_id", cb_CusID.Text);
            dthandle.exNonQuery(cmd);
            load();
            clearTb();
            btn_Add.Enabled = true;
            btn_Add.BackColor = Color.FromArgb(235, 124, 104);
        }
        void clearTb()
        {
            txt_Note.Clear();
            nud_pow.Value = 0;
            nud_pow.Value = 0;
            txt_CardID.Text = count().ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPDeleteCard", dthandle.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@card_id", txt_CardID.Text);
            dthandle.exNonQuery(cmd);
            load();
        }

        private void dgv_wc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CardID.Text = dgv_wc.CurrentRow.Cells["card_id"].Value.ToString();
            dtPicker_Delivery.Text = dgv_wc.CurrentRow.Cells["delivery_date"].Value.ToString();
            nud_pow.Text = dgv_wc.CurrentRow.Cells["price_of_warranty"].Value.ToString();
            cb_CusID.Text = dgv_wc.CurrentRow.Cells["customer_id"].Value.ToString();
            txt_Note.Text = dgv_wc.CurrentRow.Cells["note"].Value.ToString();
            btn_Add.Enabled = false;
            btn_Add.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from warcard where card_id like '%" + txt_search.Text + "%'";
            dgv_wc.DataSource = dthandle.LoadBang(sql);
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
            txt_CardID.Text = count().ToString();
        }
    }
}
