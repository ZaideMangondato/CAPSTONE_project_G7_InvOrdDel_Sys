namespace CAPSTONE_project_G7_InvOrdDel_Sys
{
    partial class Order_Full_info
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jo_transno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jo_soldto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jo_destination = new System.Windows.Forms.TextBox();
            this.dgv_job_order = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.jo_expctd_dt_delivery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.jo_delstatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jo_transtype = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.jo_totalamount = new System.Windows.Forms.TextBox();
            this.jo_totalweight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.jo_totalqty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.jo_noitems = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_fordeltrans_status = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.jo_contactno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.jo_dtordered = new System.Windows.Forms.TextBox();
            this.jo_route = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_job_order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fordeltrans_status)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // jo_transno
            // 
            this.jo_transno.BackColor = System.Drawing.Color.White;
            this.jo_transno.Location = new System.Drawing.Point(162, 60);
            this.jo_transno.Name = "jo_transno";
            this.jo_transno.ReadOnly = true;
            this.jo_transno.Size = new System.Drawing.Size(180, 22);
            this.jo_transno.TabIndex = 1;
            this.jo_transno.TextChanged += new System.EventHandler(this.jo_transno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sold To:";
            // 
            // jo_soldto
            // 
            this.jo_soldto.BackColor = System.Drawing.Color.White;
            this.jo_soldto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_soldto.Location = new System.Drawing.Point(162, 88);
            this.jo_soldto.Name = "jo_soldto";
            this.jo_soldto.ReadOnly = true;
            this.jo_soldto.Size = new System.Drawing.Size(288, 22);
            this.jo_soldto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivery Destination /\r\nAddress";
            // 
            // jo_destination
            // 
            this.jo_destination.BackColor = System.Drawing.Color.White;
            this.jo_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_destination.Location = new System.Drawing.Point(162, 116);
            this.jo_destination.Multiline = true;
            this.jo_destination.Name = "jo_destination";
            this.jo_destination.ReadOnly = true;
            this.jo_destination.Size = new System.Drawing.Size(288, 53);
            this.jo_destination.TabIndex = 5;
            // 
            // dgv_job_order
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_job_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_job_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_job_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_job_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_job_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_job_order.Location = new System.Drawing.Point(11, 237);
            this.dgv_job_order.Name = "dgv_job_order";
            this.dgv_job_order.ReadOnly = true;
            this.dgv_job_order.RowHeadersVisible = false;
            this.dgv_job_order.Size = new System.Drawing.Size(672, 199);
            this.dgv_job_order.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(8, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Items Ordered and Particulars";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(269, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Job Order Full Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.jo_expctd_dt_delivery);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.jo_delstatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.jo_transtype);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.jo_totalamount);
            this.panel1.Controls.Add(this.jo_totalweight);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.jo_totalqty);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.jo_noitems);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dgv_fordeltrans_status);
            this.panel1.Location = new System.Drawing.Point(11, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 173);
            this.panel1.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Expected Date of Delivery";
            // 
            // jo_expctd_dt_delivery
            // 
            this.jo_expctd_dt_delivery.BackColor = System.Drawing.Color.White;
            this.jo_expctd_dt_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_expctd_dt_delivery.Location = new System.Drawing.Point(489, 86);
            this.jo_expctd_dt_delivery.Name = "jo_expctd_dt_delivery";
            this.jo_expctd_dt_delivery.ReadOnly = true;
            this.jo_expctd_dt_delivery.Size = new System.Drawing.Size(176, 22);
            this.jo_expctd_dt_delivery.TabIndex = 23;
            this.jo_expctd_dt_delivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jo_expctd_dt_delivery.TextChanged += new System.EventHandler(this.jo_expctd_dt_delivery_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Delivery Status";
            // 
            // jo_delstatus
            // 
            this.jo_delstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_delstatus.ForeColor = System.Drawing.Color.Black;
            this.jo_delstatus.Location = new System.Drawing.Point(119, 86);
            this.jo_delstatus.Name = "jo_delstatus";
            this.jo_delstatus.Size = new System.Drawing.Size(149, 22);
            this.jo_delstatus.TabIndex = 21;
            this.jo_delstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jo_delstatus.TextChanged += new System.EventHandler(this.jo_delstatus_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Transaction Type";
            // 
            // jo_transtype
            // 
            this.jo_transtype.BackColor = System.Drawing.Color.White;
            this.jo_transtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_transtype.Location = new System.Drawing.Point(119, 58);
            this.jo_transtype.Name = "jo_transtype";
            this.jo_transtype.ReadOnly = true;
            this.jo_transtype.Size = new System.Drawing.Size(148, 22);
            this.jo_transtype.TabIndex = 19;
            this.jo_transtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(446, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 31);
            this.label16.TabIndex = 18;
            this.label16.Text = "₱";
            // 
            // jo_totalamount
            // 
            this.jo_totalamount.BackColor = System.Drawing.Color.White;
            this.jo_totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_totalamount.Location = new System.Drawing.Point(489, 3);
            this.jo_totalamount.Name = "jo_totalamount";
            this.jo_totalamount.ReadOnly = true;
            this.jo_totalamount.Size = new System.Drawing.Size(176, 38);
            this.jo_totalamount.TabIndex = 17;
            // 
            // jo_totalweight
            // 
            this.jo_totalweight.BackColor = System.Drawing.Color.White;
            this.jo_totalweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_totalweight.Location = new System.Drawing.Point(232, 26);
            this.jo_totalweight.Name = "jo_totalweight";
            this.jo_totalweight.ReadOnly = true;
            this.jo_totalweight.Size = new System.Drawing.Size(110, 22);
            this.jo_totalweight.TabIndex = 16;
            this.jo_totalweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(229, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Total Weight (kg,)";
            // 
            // jo_totalqty
            // 
            this.jo_totalqty.BackColor = System.Drawing.Color.White;
            this.jo_totalqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_totalqty.Location = new System.Drawing.Point(120, 26);
            this.jo_totalqty.Name = "jo_totalqty";
            this.jo_totalqty.ReadOnly = true;
            this.jo_totalqty.Size = new System.Drawing.Size(106, 22);
            this.jo_totalqty.TabIndex = 14;
            this.jo_totalqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total Quantity";
            // 
            // jo_noitems
            // 
            this.jo_noitems.BackColor = System.Drawing.Color.White;
            this.jo_noitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_noitems.Location = new System.Drawing.Point(5, 26);
            this.jo_noitems.Name = "jo_noitems";
            this.jo_noitems.ReadOnly = true;
            this.jo_noitems.Size = new System.Drawing.Size(108, 22);
            this.jo_noitems.TabIndex = 12;
            this.jo_noitems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "No. of items";
            // 
            // dgv_fordeltrans_status
            // 
            this.dgv_fordeltrans_status.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fordeltrans_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_fordeltrans_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fordeltrans_status.Enabled = false;
            this.dgv_fordeltrans_status.Location = new System.Drawing.Point(3, 114);
            this.dgv_fordeltrans_status.Name = "dgv_fordeltrans_status";
            this.dgv_fordeltrans_status.ReadOnly = true;
            this.dgv_fordeltrans_status.RowHeadersVisible = false;
            this.dgv_fordeltrans_status.Size = new System.Drawing.Size(662, 51);
            this.dgv_fordeltrans_status.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Contact No.";
            // 
            // jo_contactno
            // 
            this.jo_contactno.BackColor = System.Drawing.Color.White;
            this.jo_contactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_contactno.Location = new System.Drawing.Point(502, 138);
            this.jo_contactno.Name = "jo_contactno";
            this.jo_contactno.ReadOnly = true;
            this.jo_contactno.Size = new System.Drawing.Size(180, 22);
            this.jo_contactno.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Date Ordered";
            // 
            // jo_dtordered
            // 
            this.jo_dtordered.BackColor = System.Drawing.Color.White;
            this.jo_dtordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_dtordered.Location = new System.Drawing.Point(502, 88);
            this.jo_dtordered.Name = "jo_dtordered";
            this.jo_dtordered.ReadOnly = true;
            this.jo_dtordered.Size = new System.Drawing.Size(180, 22);
            this.jo_dtordered.TabIndex = 55;
            this.jo_dtordered.TextChanged += new System.EventHandler(this.jo_dtordered_TextChanged);
            // 
            // jo_route
            // 
            this.jo_route.BackColor = System.Drawing.Color.White;
            this.jo_route.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jo_route.Location = new System.Drawing.Point(162, 175);
            this.jo_route.Name = "jo_route";
            this.jo_route.ReadOnly = true;
            this.jo_route.Size = new System.Drawing.Size(288, 22);
            this.jo_route.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Route";
            // 
            // Order_Full_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 624);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.jo_route);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jo_dtordered);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jo_contactno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_job_order);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jo_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jo_soldto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jo_transno);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order_Full_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Full_info";
            this.Load += new System.EventHandler(this.Order_Full_info_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_job_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fordeltrans_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_job_order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_fordeltrans_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox jo_delstatus;
        public System.Windows.Forms.TextBox jo_transtype;
        public System.Windows.Forms.TextBox jo_transno;
        public System.Windows.Forms.TextBox jo_soldto;
        public System.Windows.Forms.TextBox jo_destination;
        public System.Windows.Forms.TextBox jo_contactno;
        public System.Windows.Forms.TextBox jo_totalamount;
        public System.Windows.Forms.TextBox jo_totalweight;
        public System.Windows.Forms.TextBox jo_totalqty;
        public System.Windows.Forms.TextBox jo_noitems;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox jo_dtordered;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox jo_expctd_dt_delivery;
        public System.Windows.Forms.TextBox jo_route;
        private System.Windows.Forms.Label label11;
    }
}