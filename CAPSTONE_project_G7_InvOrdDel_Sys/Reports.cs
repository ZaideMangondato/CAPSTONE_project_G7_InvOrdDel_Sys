using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CAPSTONE_project_G7_InvOrdDel_Sys
{
    public partial class Reports : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;

        public Reports()
        {
            InitializeComponent();
        }
        //public void loadinv()
        //{
        //    con = new MySqlConnection(dbconnect.constr);
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.Connection = con;
        //    MySqlDataAdapter da = new MySqlDataAdapter();
        //    string sql = "SELECT * from v_full_items_inv";                    // Select Query Statement
        //    da.SelectCommand = new MySqlCommand(sql, con);
        //    DataTable table = new DataTable();
        //    da.Fill(table);
        //    BindingSource bSource = new BindingSource();
        //    bSource.DataSource = table;
        //    dgv_inv.DataSource = bSource;
        //}
        private void Inventory_summary_report_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_full_items_inv";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_inv.DataSource = bSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from  tbl_saved_orders";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_inv.DataSource = bSource;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from  tbl_saved_orders where trans_type = 'For-Delivery' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_inv.DataSource = bSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from  tbl_saved_orders where trans_type = 'Non-Delivery' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_inv.DataSource = bSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from  v_delivery_trans_orders_full ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_inv.DataSource = bSource;
        }
        private void copyAlltoClipboard()
        {
            dgv_inv.SelectAll();
            DataObject dataObj = dgv_inv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            
            object misValue = System.Reflection.Missing.Value;
            
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Columns.AutoFit();
            xlexcel.Visible = true;
            

            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];
            for (int j = 0; j < dgv_inv.Columns.Count; ++j)
                xlWorkSheet.Cells[1, j + 1] = dgv_inv.Columns[j].HeaderText;

            CR.Select();
            
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            xlexcel.Columns.AutoFit();
        }
    }
}
