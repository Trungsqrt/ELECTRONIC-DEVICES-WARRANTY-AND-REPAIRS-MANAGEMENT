
namespace EDWARM
{
    partial class frm_ExportForCus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ExportForCus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PriceOfWarranty = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_DeliveryDate = new System.Windows.Forms.TextBox();
            this.btn_ExportForCus = new System.Windows.Forms.Button();
            this.cb_cusId = new System.Windows.Forms.ComboBox();
            this.cb_cardId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 70);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(124)))), ((int)(((byte)(104)))));
            this.label1.Location = new System.Drawing.Point(128, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "WARRANTY CARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(15, 309);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(132, 22);
            this.lb.TabIndex = 6;
            this.lb.Text = "Price of warranty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Delivery Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(98, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Note:";
            // 
            // txt_PriceOfWarranty
            // 
            this.txt_PriceOfWarranty.Location = new System.Drawing.Point(153, 306);
            this.txt_PriceOfWarranty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PriceOfWarranty.Name = "txt_PriceOfWarranty";
            this.txt_PriceOfWarranty.ReadOnly = true;
            this.txt_PriceOfWarranty.Size = new System.Drawing.Size(255, 26);
            this.txt_PriceOfWarranty.TabIndex = 11;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(153, 378);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(255, 143);
            this.txt_Note.TabIndex = 13;
            // 
            // txt_DeliveryDate
            // 
            this.txt_DeliveryDate.Location = new System.Drawing.Point(153, 245);
            this.txt_DeliveryDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DeliveryDate.Name = "txt_DeliveryDate";
            this.txt_DeliveryDate.ReadOnly = true;
            this.txt_DeliveryDate.Size = new System.Drawing.Size(255, 26);
            this.txt_DeliveryDate.TabIndex = 14;
            // 
            // btn_ExportForCus
            // 
            this.btn_ExportForCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(124)))), ((int)(((byte)(104)))));
            this.btn_ExportForCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExportForCus.ForeColor = System.Drawing.Color.White;
            this.btn_ExportForCus.Location = new System.Drawing.Point(439, 574);
            this.btn_ExportForCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExportForCus.Name = "btn_ExportForCus";
            this.btn_ExportForCus.Size = new System.Drawing.Size(98, 44);
            this.btn_ExportForCus.TabIndex = 16;
            this.btn_ExportForCus.Text = "Export";
            this.btn_ExportForCus.UseVisualStyleBackColor = false;
            // 
            // cb_cusId
            // 
            this.cb_cusId.FormattingEnabled = true;
            this.cb_cusId.Location = new System.Drawing.Point(149, 126);
            this.cb_cusId.Name = "cb_cusId";
            this.cb_cusId.Size = new System.Drawing.Size(259, 28);
            this.cb_cusId.TabIndex = 17;
            // 
            // cb_cardId
            // 
            this.cb_cardId.FormattingEnabled = true;
            this.cb_cardId.Location = new System.Drawing.Point(149, 187);
            this.cb_cardId.Name = "cb_cardId";
            this.cb_cardId.Size = new System.Drawing.Size(259, 28);
            this.cb_cardId.TabIndex = 18;
            // 
            // frm_ExportForCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(565, 632);
            this.Controls.Add(this.cb_cardId);
            this.Controls.Add(this.cb_cusId);
            this.Controls.Add(this.btn_ExportForCus);
            this.Controls.Add(this.txt_DeliveryDate);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_PriceOfWarranty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_ExportForCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PriceOfWarranty;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_DeliveryDate;
        private System.Windows.Forms.Button btn_ExportForCus;
        private System.Windows.Forms.ComboBox cb_cusId;
        private System.Windows.Forms.ComboBox cb_cardId;
    }
}