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
    public partial class Saved_Orders : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Saved_Orders()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadcountfordelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_saved_orders where trans_type = 'For-Delivery' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String scountfd = rdr.GetString("count(*)");
                txttotal_fd.Text = scountfd;
            }
            con.Close();
        }

        public void loadfordelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_saved_orders where trans_type = 'For-Delivery' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_for_delivery.DataSource = bSource;

            loadcountfordelivery();
        }


        public void loadcountnondelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_saved_orders where trans_type = 'Non-Delivery' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String scountnd = rdr.GetString("count(*)");
                txttotal_nd.Text = scountnd;
            }
            con.Close();
        }
        public void loadnondelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_saved_orders where trans_type = 'Non-Delivery' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_non_delivery.DataSource = bSource;

            loadcountnondelivery();
        }
        public void countAllSavedTrans()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_saved_orders";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String total = rdr.GetString("count(*)");
                txttotal_trans.Text = total;
            }
            con.Close();
        }
        private void Saved_Orders_Load(object sender, EventArgs e)
        {
            countAllSavedTrans();
            loadfordelivery();
            loadnondelivery();
        }


        public void searchForDelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_saved_orders where trans_type = 'For-Delivery' and (trans_no like '%" + textBox1.Text + "%' or sold_to like '%" + textBox1.Text + "%' or contact_no like '%" + textBox1.Text + "%' or del_destination like '%" + textBox1.Text + "%' or no_of_items like '%" + textBox1.Text + "%' or total_qty like '%" + textBox1.Text + "%' or total_weight_kg like '%" + textBox1.Text + "%' or total_amount like '%" + textBox1.Text + "%' or dt_ordered like '%" + textBox1.Text + "%' ) ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_for_delivery.DataSource = bSource;
        }
        public void searchNonDelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_saved_orders where trans_type = 'Non-Delivery' and (trans_no like '%" + textBox1.Text + "%' or sold_to like '%" + textBox1.Text + "%' or contact_no like '%" + textBox1.Text + "%' or del_destination like '%" + textBox1.Text + "%' or no_of_items like '%" + textBox1.Text + "%' or total_qty like '%" + textBox1.Text + "%' or total_weight_kg like '%" + textBox1.Text + "%' or total_amount like '%" + textBox1.Text + "%' or dt_ordered like '%" + textBox1.Text + "%' ) ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_non_delivery.DataSource = bSource;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchForDelivery();
            searchNonDelivery();
        }

        private void dgv_for_delivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Order_Full_info ofi = new Order_Full_info();
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_for_delivery.Rows[indexRow];
            ofi.jo_transno.Text = row.Cells[0].Value.ToString();
            ofi.jo_soldto.Text = row.Cells[1].Value.ToString();
            ofi.jo_destination.Text = row.Cells[3].Value.ToString();

            ofi.jo_contactno.Text = row.Cells[2].Value.ToString();
            ofi.jo_noitems.Text = row.Cells[5].Value.ToString();
            ofi.jo_totalqty.Text = row.Cells[6].Value.ToString();
            ofi.jo_totalweight.Text = row.Cells[7].Value.ToString();
            ofi.jo_totalamount.Text = row.Cells[8].Value.ToString();
            ofi.jo_dtordered.Text = row.Cells[9].Value.ToString();
            ofi.jo_transtype.Text = row.Cells[10].Value.ToString();
            ofi.ShowDialog();
        }

        private void dgv_non_delivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Order_Full_info ofi = new Order_Full_info();
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_non_delivery.Rows[indexRow];
            ofi.jo_transno.Text = row.Cells[0].Value.ToString();
            ofi.jo_soldto.Text = row.Cells[1].Value.ToString();
            ofi.jo_destination.Text = row.Cells[3].Value.ToString();

            ofi.jo_contactno.Text = row.Cells[2].Value.ToString();
            ofi.jo_noitems.Text = row.Cells[5].Value.ToString();
            ofi.jo_totalqty.Text = row.Cells[6].Value.ToString();
            ofi.jo_totalweight.Text = row.Cells[7].Value.ToString();
            ofi.jo_totalamount.Text = row.Cells[8].Value.ToString();
            ofi.jo_dtordered.Text = row.Cells[9].Value.ToString();
            ofi.jo_transtype.Text = row.Cells[10].Value.ToString();
            ofi.ShowDialog();
        }
    }
}
