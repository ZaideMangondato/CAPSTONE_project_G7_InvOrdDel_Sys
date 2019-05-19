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
    public partial class Item_Stocks : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Item_Stocks()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        public void loaditemstocks()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_item_stocks.Rows.Clear();
            while(rdr.Read() == true){
                dgv_item_stocks.Rows.Add(rdr[0],rdr[1],rdr[2],rdr[3],rdr[4],rdr[5],rdr[6]);
            }
            con.Close();

            countNumberOfStocks();
        }
        public void loadlowitemstocks()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv where no_of_stocks < 10";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_low_item_stocks.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_low_item_stocks.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
            }
            con.Close();
        }
        public void countNumberOfStocks()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from v_full_items_inv";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                label2.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        private void Item_Stocks_Load(object sender, EventArgs e)
        {
            loaditemstocks();
            loadlowitemstocks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv where item_code like '%" + txtsearch.Text + "%' or item_name like '%" + txtsearch.Text + "%' or item_desc like '%" + txtsearch.Text + "%' or item_weight_kg like '%" + txtsearch.Text + "%' or no_of_stocks like '%" + txtsearch.Text + "%' or item_unit like '%" + txtsearch.Text + "%' or item_price like '%" + txtsearch.Text + "%'  ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_item_stocks.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_item_stocks.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
            }
            con.Close();
        }

        private void dgv_item_stocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_item_stocks.Rows[indexRow];
            Item_Stock_Card_Info isci = new Item_Stock_Card_Info();
            isci.is_itemcode.Text = row.Cells[0].Value.ToString();
            isci.is_itemname.Text = row.Cells[1].Value.ToString();
            isci.is_desc.Text = row.Cells[2].Value.ToString();
            isci.is_weight.Text = row.Cells[3].Value.ToString();
            isci.is_nostock.Text = row.Cells[4].Value.ToString();
            isci.is_unit.Text = row.Cells[5].Value.ToString();
            isci.is_itemprice.Text = row.Cells[6].Value.ToString();
            isci.ShowDialog();

            
        }

        private void dgv_low_item_stocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_low_item_stocks.Rows[indexRow];
            Item_Stock_Card_Info isci = new Item_Stock_Card_Info();
            isci.is_itemcode.Text = row.Cells[0].Value.ToString();
            isci.is_itemname.Text = row.Cells[1].Value.ToString();
            isci.is_desc.Text = row.Cells[2].Value.ToString();
            isci.is_weight.Text = row.Cells[3].Value.ToString();
            isci.is_nostock.Text = row.Cells[4].Value.ToString();
            isci.is_unit.Text = row.Cells[5].Value.ToString();
            isci.is_itemprice.Text = row.Cells[6].Value.ToString();
            isci.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv where (item_code like '%" + txtsearch.Text + "%' or item_name like '%" + txtsearch.Text + "%' or item_desc like '%" + txtsearch.Text + "%' or item_weight_kg like '%" + txtsearch.Text + "%' or no_of_stocks like '%" + txtsearch.Text + "%' or item_unit like '%" + txtsearch.Text + "%' or item_price like '%" + txtsearch.Text + "%' ) and (no_of_stocks < 10)";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_low_item_stocks.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_low_item_stocks.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
            }
            con.Close();
        }
    }
}
