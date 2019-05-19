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
    public partial class Pending : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Pending()
        {
            InitializeComponent();
        }
        public void loadPending()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select * from v_saved_for_delivery_orders where delivery_status = 'Pending'";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_pending.DataSource = bSource;
        }
        private void Pending_Load(object sender, EventArgs e)
        {
            loadPending();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Available_Vacant_Vehicles avv = new Available_Vacant_Vehicles();
            avv.ShowDialog();
            this.Close();
        }

        private void dgv_pending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_pending.Rows[indexRow];
            Order_Full_info ofi = new Order_Full_info();
            ofi.jo_transno.Text = row.Cells[0].Value.ToString();
            ofi.ShowDialog();
        }
    }
}
