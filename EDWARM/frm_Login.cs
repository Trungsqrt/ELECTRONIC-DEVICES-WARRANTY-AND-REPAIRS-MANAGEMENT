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
            Random ran = new Random();
            #region random column
            int color1 = ran.Next(0, 255);
            int color2 = ran.Next(0, 255);
            int color3 = ran.Next(0, 255);
            int color4 = ran.Next(0, 255);
            #endregion
            lbl_notify.Text = "UserName: admin, Password: admin";
            lbl_notify.ForeColor = Color.FromArgb(color1, color2, color3, color4);

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            timer_notify.Start();
            timer_notify.Enabled = true;
        }
    }
}
