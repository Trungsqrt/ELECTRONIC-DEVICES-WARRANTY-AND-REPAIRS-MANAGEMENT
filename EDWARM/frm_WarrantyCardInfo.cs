using ClosedXML.Excel;
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
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd= new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook= new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.eDWARMDataSet.warcard.CopyToDataTable(), "warcard");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have successfully export your data to an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frm_WarrantyCardInfo_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'eDWARMDataSet1.warcard' table. You can move, or remove it, as needed.
this.warcardTableAdapter.Fill(this.eDWARMDataSet.warcard);
            // TODO: This line of code loads data into the 'eDWARMDataSet.warcard' table. You can move, or remove it, as needed.
            this.warcardTableAdapter.Fill(this.eDWARMDataSet.warcard);
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

        bool isNullorEmpty(string s1, string s2, string s3, string s4, string s5)
        {
            if (s1 == null || s1 == "" ||
                s2 == null || s2 == "" ||
                s3 == null || s3 == "" ||
                s4 == null || s4 == "" ||
                s5 == null || s5 == "")
                return true;
            return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isNullorEmpty(txt_CardID.Text, dtPicker_Delivery.Text,
                nud_pow.Text, txt_Note.Text,
                cb_CusID.Text))
                MessageBox.Show("Không được để trống");
            else
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
            if (isNullorEmpty(txt_CardID.Text, dtPicker_Delivery.Text,
                nud_pow.Text, txt_Note.Text,
                cb_CusID.Text))
                MessageBox.Show("Không được để trống");
            else
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
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("SPDeleteCard", dthandle.getConnectionString());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@card_id", txt_CardID.Text);
                dthandle.exNonQuery(cmd);
                load();
            }
        }

        private void dgv_wc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CardID.Text = dgv_wc.CurrentRow.Cells[0].Value.ToString();
            dtPicker_Delivery.Text = dgv_wc.CurrentRow.Cells[1].Value.ToString();
            nud_pow.Text = dgv_wc.CurrentRow.Cells[2].Value.ToString();
            cb_CusID.Text = dgv_wc.CurrentRow.Cells[3].Value.ToString();
            txt_Note.Text = dgv_wc.CurrentRow.Cells[4].Value.ToString();
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
