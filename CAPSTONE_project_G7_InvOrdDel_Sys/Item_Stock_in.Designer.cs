namespace CAPSTONE_project_G7_InvOrdDel_Sys
{
    partial class Item_Stock_in
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsuppname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsuppid = new System.Windows.Forms.TextBox();
            this.txtstockid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_supplier_items = new System.Windows.Forms.DataGridView();
            this.dgitemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgstockadded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtracecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdtstockin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier_items)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Supplier\'s Name";
            // 
            // txtsuppname
            // 
            this.txtsuppname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsuppname.Location = new System.Drawing.Point(138, 67);
            this.txtsuppname.Name = "txtsuppname";
            this.txtsuppname.ReadOnly = true;
            this.txtsuppname.Size = new System.Drawing.Size(222, 22);
            this.txtsuppname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Supplier ID";
            // 
            // txtsuppid
            // 
            this.txtsuppid.Location = new System.Drawing.Point(138, 39);
            this.txtsuppid.Name = "txtsuppid";
            this.txtsuppid.ReadOnly = true;
            this.txtsuppid.Size = new System.Drawing.Size(157, 22);
            this.txtsuppid.TabIndex = 12;
            // 
            // txtstockid
            // 
            this.txtstockid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstockid.Location = new System.Drawing.Point(138, 11);
            this.txtstockid.Name = "txtstockid";
            this.txtstockid.ReadOnly = true;
            this.txtstockid.Size = new System.Drawing.Size(157, 22);
            this.txtstockid.TabIndex = 16;
            this.txtstockid.TextChanged += new System.EventHandler(this.txtstockid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stock-in ID/No.";
            // 
            // dgv_supplier_items
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_supplier_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_supplier_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplier_items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_supplier_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_supplier_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplier_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgitemcode,
            this.dgitemname,
            this.dgstockadded,
            this.dgtracecode});
            this.dgv_supplier_items.Location = new System.Drawing.Point(12, 119);
            this.dgv_supplier_items.Name = "dgv_supplier_items";
            this.dgv_supplier_items.ReadOnly = true;
            this.dgv_supplier_items.RowHeadersVisible = false;
            this.dgv_supplier_items.Size = new System.Drawing.Size(584, 296);
            this.dgv_supplier_items.TabIndex = 18;
            // 
            // dgitemcode
            // 
            this.dgitemcode.HeaderText = "Item Code";
            this.dgitemcode.Name = "dgitemcode";
            this.dgitemcode.ReadOnly = true;
            // 
            // dgitemname
            // 
            this.dgitemname.HeaderText = "Item Name";
            this.dgitemname.Name = "dgitemname";
            this.dgitemname.ReadOnly = true;
            // 
            // dgstockadded
            // 
            this.dgstockadded.HeaderText = "Stock Added";
            this.dgstockadded.Name = "dgstockadded";
            this.dgstockadded.ReadOnly = true;
            // 
            // dgtracecode
            // 
            this.dgtracecode.HeaderText = "Tracecode";
            this.dgtracecode.Name = "dgtracecode";
            this.dgtracecode.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Stock-in";
            // 
            // txtdtstockin
            // 
            this.txtdtstockin.Location = new System.Drawing.Point(467, 11);
            this.txtdtstockin.Name = "txtdtstockin";
            this.txtdtstockin.ReadOnly = true;
            this.txtdtstockin.Size = new System.Drawing.Size(129, 22);
            this.txtdtstockin.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Stock Entries and Particulars";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 41);
            this.panel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total\r\nItems";
            // 
            // Item_Stock_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdtstockin);
            this.Controls.Add(this.dgv_supplier_items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstockid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsuppname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsuppid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Item_Stock_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_Stock_in";
            this.Load += new System.EventHandler(this.Item_Stock_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplier_items)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_supplier_items;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtsuppname;
        public System.Windows.Forms.TextBox txtsuppid;
        public System.Windows.Forms.TextBox txtstockid;
        public System.Windows.Forms.TextBox txtdtstockin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgitemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgstockadded;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtracecode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}