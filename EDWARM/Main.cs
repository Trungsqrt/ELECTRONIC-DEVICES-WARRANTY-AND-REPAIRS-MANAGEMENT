using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDWARM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void danhSáchKháchHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["frm_DevicesInfo"] != null)
            {
                Application.OpenForms["frm_DevicesInfo"].Close();
            }
            
            if(Application.OpenForms["frm_WarrantyCardInfo"] != null)
            {
                Application.OpenForms["frm_WarrantyCardInfo"].Close();
            }

            if (Application.OpenForms["frm_CustomersInfo"] == null )
            {
                frm_CustomersInfo frm = new frm_CustomersInfo();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frm_CustomersInfo"].Activate();
            }
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void devicesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_CustomersInfo"] != null)
            {
                Application.OpenForms["frm_CustomersInfo"].Close();
            }

            if (Application.OpenForms["frm_WarrantyCardInfo"] != null)
            {
                Application.OpenForms["frm_WarrantyCardInfo"].Close();
            }

            if (Application.OpenForms["frm_DevicesInfo"] == null)
            {
                frm_DevicesInfo frm = new frm_DevicesInfo();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frm_DevicesInfo"].Activate();
            }
        }

        private void warrantyCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_CustomersInfo"] != null)
            {
                Application.OpenForms["frm_CustomersInfo"].Close();
            }

            if (Application.OpenForms["frm_DevicesInfo"] != null)
            {
                Application.OpenForms["frm_DevicesInfo"].Close();
            }

            if (Application.OpenForms["frm_WarrantyCardInfo"] == null)
            {
                frm_WarrantyCardInfo frm = new frm_WarrantyCardInfo();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Application.OpenForms["frm_WarrantyCardInfo"].Activate();
            }
        }

        private void thôngTinHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel_Time.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
