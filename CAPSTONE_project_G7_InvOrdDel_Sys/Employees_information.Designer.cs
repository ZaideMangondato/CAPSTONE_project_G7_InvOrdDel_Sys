namespace CAPSTONE_project_G7_InvOrdDel_Sys
{
    partial class Employees_information
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.txtposition = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcounttotal = new System.Windows.Forms.Label();
            this.lblcountdrivers = new System.Windows.Forms.Label();
            this.lblcounthelpers = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpid = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtsearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_emp);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(112, 14);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(235, 26);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // dgv_emp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_emp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.empname,
            this.empphone,
            this.empaddress,
            this.empposition});
            this.dgv_emp.Location = new System.Drawing.Point(6, 45);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.ReadOnly = true;
            this.dgv_emp.RowHeadersVisible = false;
            this.dgv_emp.Size = new System.Drawing.Size(764, 231);
            this.dgv_emp.TabIndex = 0;
            // 
            // empid
            // 
            this.empid.HeaderText = "ID";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 51;
            // 
            // empname
            // 
            this.empname.HeaderText = "Name";
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Width = 76;
            // 
            // empphone
            // 
            this.empphone.HeaderText = "Phone Number";
            this.empphone.Name = "empphone";
            this.empphone.ReadOnly = true;
            this.empphone.Width = 140;
            // 
            // empaddress
            // 
            this.empaddress.HeaderText = "Address";
            this.empaddress.Name = "empaddress";
            this.empaddress.ReadOnly = true;
            this.empaddress.Width = 93;
            // 
            // empposition
            // 
            this.empposition.HeaderText = "Position";
            this.empposition.Name = "empposition";
            this.empposition.ReadOnly = true;
            this.empposition.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnsubmit);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtaddress);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtphone);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtname);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btngenerate);
            this.tabPage2.Controls.Add(this.txtposition);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(650, 246);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(123, 33);
            this.btnsubmit.TabIndex = 12;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(242, 128);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(229, 58);
            this.txtaddress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(242, 96);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(195, 26);
            this.txtphone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone No.";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(242, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(328, 26);
            this.txtname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(477, 30);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(93, 30);
            this.btngenerate.TabIndex = 4;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // txtposition
            // 
            this.txtposition.FormattingEnabled = true;
            this.txtposition.Items.AddRange(new object[] {
            "Driver",
            "Helper"});
            this.txtposition.Location = new System.Drawing.Point(242, 192);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(159, 28);
            this.txtposition.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(242, 32);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(229, 26);
            this.txtid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblcounttotal);
            this.panel1.Controls.Add(this.lblcountdrivers);
            this.panel1.Controls.Add(this.lblcounthelpers);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(8, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 47);
            this.panel1.TabIndex = 1;
            // 
            // lblcounttotal
            // 
            this.lblcounttotal.AutoSize = true;
            this.lblcounttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcounttotal.Location = new System.Drawing.Point(382, 5);
            this.lblcounttotal.Name = "lblcounttotal";
            this.lblcounttotal.Size = new System.Drawing.Size(32, 33);
            this.lblcounttotal.TabIndex = 5;
            this.lblcounttotal.Text = "0";
            // 
            // lblcountdrivers
            // 
            this.lblcountdrivers.AutoSize = true;
            this.lblcountdrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountdrivers.Location = new System.Drawing.Point(258, 5);
            this.lblcountdrivers.Name = "lblcountdrivers";
            this.lblcountdrivers.Size = new System.Drawing.Size(32, 33);
            this.lblcountdrivers.TabIndex = 4;
            this.lblcountdrivers.Text = "0";
            // 
            // lblcounthelpers
            // 
            this.lblcounthelpers.AutoSize = true;
            this.lblcounthelpers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcounthelpers.Location = new System.Drawing.Point(99, 5);
            this.lblcounthelpers.Name = "lblcounthelpers";
            this.lblcounthelpers.Size = new System.Drawing.Size(32, 33);
            this.lblcounthelpers.TabIndex = 3;
            this.lblcounthelpers.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Driver(s):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Helper(s):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpid
            // 
            this.dtpid.CustomFormat = "EMPyyssmmhhMMdd";
            this.dtpid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpid.Location = new System.Drawing.Point(398, -4);
            this.dtpid.Name = "dtpid";
            this.dtpid.Size = new System.Drawing.Size(201, 26);
            this.dtpid.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Employees_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employees_information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees_information";
            this.Load += new System.EventHandler(this.Employees_information_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn empposition;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.ComboBox txtposition;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker dtpid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcounttotal;
        private System.Windows.Forms.Label lblcountdrivers;
        private System.Windows.Forms.Label lblcounthelpers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}