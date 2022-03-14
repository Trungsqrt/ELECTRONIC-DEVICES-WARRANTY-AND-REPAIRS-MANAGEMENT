
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CardID = new System.Windows.Forms.TextBox();
            this.txt_PriceOfWarranty = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_DeliveryDate = new System.Windows.Forms.TextBox();
            this.txt_CusID = new System.Windows.Forms.TextBox();
            this.btn_ExportForCus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 56);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WARRANTY CARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(12, 248);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(118, 17);
            this.lb.TabIndex = 6;
            this.lb.Text = "Price of warranty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Delivery Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Customer ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Note:";
            // 
            // txt_CardID
            // 
            this.txt_CardID.Location = new System.Drawing.Point(136, 96);
            this.txt_CardID.Name = "txt_CardID";
            this.txt_CardID.Size = new System.Drawing.Size(227, 22);
            this.txt_CardID.TabIndex = 10;
            // 
            // txt_PriceOfWarranty
            // 
            this.txt_PriceOfWarranty.Location = new System.Drawing.Point(136, 245);
            this.txt_PriceOfWarranty.Name = "txt_PriceOfWarranty";
            this.txt_PriceOfWarranty.Size = new System.Drawing.Size(227, 22);
            this.txt_PriceOfWarranty.TabIndex = 11;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(136, 302);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(227, 115);
            this.txt_Note.TabIndex = 13;
            // 
            // txt_DeliveryDate
            // 
            this.txt_DeliveryDate.Location = new System.Drawing.Point(136, 196);
            this.txt_DeliveryDate.Name = "txt_DeliveryDate";
            this.txt_DeliveryDate.Size = new System.Drawing.Size(227, 22);
            this.txt_DeliveryDate.TabIndex = 14;
            // 
            // txt_CusID
            // 
            this.txt_CusID.Location = new System.Drawing.Point(136, 147);
            this.txt_CusID.Name = "txt_CusID";
            this.txt_CusID.Size = new System.Drawing.Size(227, 22);
            this.txt_CusID.TabIndex = 15;
            // 
            // btn_ExportForCus
            // 
            this.btn_ExportForCus.Location = new System.Drawing.Point(390, 459);
            this.btn_ExportForCus.Name = "btn_ExportForCus";
            this.btn_ExportForCus.Size = new System.Drawing.Size(87, 35);
            this.btn_ExportForCus.TabIndex = 16;
            this.btn_ExportForCus.Text = "Export";
            this.btn_ExportForCus.UseVisualStyleBackColor = true;
            // 
            // frm_ExportForCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 506);
            this.Controls.Add(this.btn_ExportForCus);
            this.Controls.Add(this.txt_CusID);
            this.Controls.Add(this.txt_DeliveryDate);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_PriceOfWarranty);
            this.Controls.Add(this.txt_CardID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ExportForCus";
            this.Text = "frm_Export";
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
        private System.Windows.Forms.TextBox txt_CardID;
        private System.Windows.Forms.TextBox txt_PriceOfWarranty;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_DeliveryDate;
        private System.Windows.Forms.TextBox txt_CusID;
        private System.Windows.Forms.Button btn_ExportForCus;
    }
}