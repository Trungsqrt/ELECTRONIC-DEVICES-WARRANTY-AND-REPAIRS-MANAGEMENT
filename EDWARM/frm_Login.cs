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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
                txt_pass.UseSystemPasswordChar = true;
        }

        DatabaseHandle dt = new DatabaseHandle();
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SPlogin", dt.getConnectionString());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txt_pass.Text.Trim());
            int result = (int)dt.Login(cmd);
            if(result == 1)
            {
                MessageBox.Show("Success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main f = new Main();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                loginCount++;
                MessageBox.Show("Fail! "+loginCount+" time(s)", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Text = "";
                txt_pass.Text = "";
            }
            if (loginCount >= 3)
                Application.Exit();
        }
        int loginCount = 0;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
        }

        private void timer_notify_Tick(object sender, EventArgs e)
        {
            timer_notify.Start();
            lbl_notify.Text = "UserName: admin, Password: admin";
            lbl_notify.ForeColor = Color.Red;
            lbl_notify.ForeColor = Color.Yellow;
            lbl_notify.ForeColor = Color.Green;
        }
    }
}
