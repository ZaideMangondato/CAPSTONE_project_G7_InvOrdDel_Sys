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
    public partial class Stock_Entry_Logs : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Stock_Entry_Logs()
        {
            InitializeComponent();
        }
        public void loadentrylogs()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_stock_logs";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_entry_logs.DataSource = bSource;
        }
        private void Stock_Entry_Logs_Load(object sender, EventArgs e)
        {
            loadentrylogs();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_stock_logs where stock_in_id like '%" + txtsearch.Text + "%' or item_code like '%" + txtsearch.Text + "%' or item_name like '%" + txtsearch.Text + "%' or stock_added like '%" + txtsearch.Text + "%' or dt_stock_logs like '%" + txtsearch.Text + "%' or tracecode like '%" + txtsearch.Text + "%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_entry_logs.DataSource = bSource;
        }
    }
}
