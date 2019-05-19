namespace CAPSTONE_project_G7_InvOrdDel_Sys
{
    partial class Stock_In_Information
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_stockin_list = new System.Windows.Forms.DataGridView();
            this.dgstockinid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsuppid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsuppname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdtstockin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockin_list)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // dgv_stockin_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_stockin_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stockin_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stockin_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_stockin_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_stockin_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stockin_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgstockinid,
            this.dgsuppid,
            this.dgsuppname,
            this.dgdtstockin});
            this.dgv_stockin_list.Location = new System.Drawing.Point(14, 63);
            this.dgv_stockin_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_stockin_list.Name = "dgv_stockin_list";
            this.dgv_stockin_list.ReadOnly = true;
            this.dgv_stockin_list.Size = new System.Drawing.Size(896, 505);
            this.dgv_stockin_list.TabIndex = 4;
            this.dgv_stockin_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stockin_list_CellContentClick);
            // 
            // dgstockinid
            // 
            this.dgstockinid.HeaderText = "Stock-in ID";
            this.dgstockinid.Name = "dgstockinid";
            this.dgstockinid.ReadOnly = true;
            // 
            // dgsuppid
            // 
            this.dgsuppid.HeaderText = "Supplier ID";
            this.dgsuppid.Name = "dgsuppid";
            this.dgsuppid.ReadOnly = true;
            // 
            // dgsuppname
            // 
            this.dgsuppname.HeaderText = "Supplier Name";
            this.dgsuppname.Name = "dgsuppname";
            this.dgsuppname.ReadOnly = true;
            // 
            // dgdtstockin
            // 
            this.dgdtstockin.HeaderText = "Date Stock-in";
            this.dgdtstockin.Name = "dgdtstockin";
            this.dgdtstockin.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(14, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Click the Table Above to See full Information.\r\n";
            // 
            // Stock_In_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_stockin_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Stock_In_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_In_Information";
            this.Load += new System.EventHandler(this.Stock_In_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockin_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stockin_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgstockinid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsuppid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsuppname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdtstockin;
        private System.Windows.Forms.Label label2;
    }
}