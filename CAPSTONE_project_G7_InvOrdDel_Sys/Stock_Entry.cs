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
    public partial class Stock_Entry : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Stock_Entry()
        {
            InitializeComponent();
        }

        

        

        public void loadselectsupplier()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select supplier_id,supplier_name from tbl_suppliers";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_select_supp.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_select_supp.Rows.Add(rdr[0],rdr[1]);
            }
            con.Close();
        }
        public void loadselectitem()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_select_item.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_select_item.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
            }
            con.Close();
        }

        public void countItems()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "  select count(*) from v_stock_logs where stock_in_id = '" + txtstockinid.Text + "' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String countitems = rdr.GetString("count(*)");
                txtcountitems.Text = countitems;
            }
            con.Close();
        }

        public void countStocks()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "  select sum(stock_added) from v_stock_logs where stock_in_id = '" + txtstockinid.Text + "' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                try
                {
                    String countstocks = rdr.GetString("sum(stock_added)");
                    txtcountstocks.Text = countstocks;
                }
                catch (Exception ex)
                {
                    txtcountstocks.Text = "0";
                }
            }
            con.Close();
        }

        public void loadcurrentStockIn()
        {
            countItems();
            countStocks();

            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "  select * from v_stock_logs where stock_in_id = '"+txtstockinid.Text+"' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_item_stocks.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_item_stocks.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
            }
            con.Close();
        }
        private void Stock_Entry_Load(object sender, EventArgs e)
        {
            loadcurrentStockIn();
            loadselectsupplier();
            loadselectitem();
         

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnsuppselect_Click(object sender, EventArgs e)
        {
            select_supp_panel.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            select_supp_panel.Visible = false;
        }

        private void dgv_select_supp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_select_supp.Rows[indexRow];
            txtsuppid.Text = row.Cells[0].Value.ToString();
            txtsuppname.Text = row.Cells[1].Value.ToString();
            select_supp_panel.Visible = false;
        }

        private void btnitemselect_Click(object sender, EventArgs e)
        {
            select_item_panel.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            select_item_panel.Visible = false;
        }

        private void txtsearchsupp_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select supplier_id,supplier_name from tbl_suppliers where supplier_id like '%"+txtsearchsupp.Text+"%' or supplier_name like '%"+txtsearchsupp.Text+"%' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_select_supp.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_select_supp.Rows.Add(rdr[0], rdr[1]);
            }
            con.Close();
        }

        private void dgv_select_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_select_item.Rows[indexRow];
            txtitemcode.Text = row.Cells[0].Value.ToString();
            txtitemname.Text = row.Cells[1].Value.ToString();
            txtcurrentstock.Text = row.Cells[4].Value.ToString();
            txtunit.Text = row.Cells[5].Value.ToString();
            select_item_panel.Visible = false;
        }
        public void clearItemF()
        {
                txttracecode.Text = "";
                txtitemcode.Text = "";
                txtitemname.Text = "";
                txtcurrentstock.Text = "";
                txtaddstock.Text = "";
                txtunit.Text = ". . .";
        }
        public void saveToStockLogs()
        {       
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "insert into tbl_stock_logs(stock_in_id,item_code,stock_added,dt_stock_logs,tracecode)values('"+txtstockinid.Text+"','"+txtitemcode.Text+"','"+txtaddstock.Text+"',now(),'"+txttracecode.Text+"')";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Stock Saved!");  
        }
        public void updateStockInventory()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "update tbl_items_inv set no_of_stocks = '"+(Convert.ToInt32(txtcurrentstock.Text)+(Convert.ToInt32(txtaddstock.Text)))+"' where item_code = '"+txtitemcode.Text+"'  ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("item Stock Added!");
        }
        private void btnadditem_Click(object sender, EventArgs e)
        {
            if (txtsuppid.Text == "" || txtitemcode.Text == "" || txtaddstock.Text == "")
            {
                MessageBox.Show("Please Select Supplier and Item");
            }
            else
            {
                try
                {
                    saveToStockLogs();
                    updateStockInventory();

                    clearItemF();
                    loadcurrentStockIn();
                    loadselectitem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            remove_panel.Visible = false;
            rmv_curstock.Text = "";
            rmv_itemcode.Text = "";
            rmv_itemname.Text = "";
            rmv_stockadded.Text = "";
            rmv_tracecode.Text = "";
        }

        private void dgv_item_stocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_item_stocks.Rows[indexRow];
            remove_panel.Visible = true;
            rmv_tracecode.Text = row.Cells[5].Value.ToString();
            rmv_itemcode.Text = row.Cells[1].Value.ToString();
            rmv_itemname.Text = row.Cells[2].Value.ToString();
            
            rmv_stockadded.Text = row.Cells[3].Value.ToString();
        }

        private void rmv_itemcode_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select no_of_stocks from tbl_items_inv where item_code = '" + rmv_itemcode.Text + "' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String nostocks = rdr.GetString("no_of_stocks");
                rmv_curstock.Text = nostocks;
            }
            con.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            remove_panel.Visible = false;
            rmv_curstock.Text = "";
            rmv_itemcode.Text = "";
            rmv_itemname.Text = "";
            rmv_stockadded.Text = "";
            rmv_tracecode.Text = "";
        }
        public void updateItemInv()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "update tbl_items_inv set no_of_stocks = '" + ((Convert.ToInt32(rmv_curstock.Text)) - (Convert.ToInt32(rmv_stockadded.Text))) + "' where item_code = '" + rmv_itemcode.Text + "'   ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Stocks back to its original quantity.");
        }
        public void removeStockLogs()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "delete from tbl_stock_logs where tracecode = '"+rmv_tracecode.Text+"' ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Stock Item Removed.");
        }
        private void btnyes_Click(object sender, EventArgs e)
        {
            try
            {
                updateItemInv();
                removeStockLogs();
                loadcurrentStockIn();
                loadselectsupplier();
                loadselectitem();

                rmv_curstock.Text = "";
                rmv_itemcode.Text = "";
                rmv_itemname.Text = "";
                rmv_stockadded.Text = "";
                rmv_tracecode.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            remove_panel.Visible = false;
        }

        private void txtsearchitem_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv where item_code like '%" + txtsearchitem.Text + "%' or item_name like '%" + txtsearchitem.Text + "%' or item_desc like '%" + txtsearchitem.Text + "%' or item_weight_kg like '%" + txtsearchitem.Text + "%' or no_of_stocks like '%" + txtsearchitem.Text + "%' or item_unit like '%" + txtsearchitem.Text + "%' or item_price like '%" + txtsearchitem.Text + "%'  ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_select_item.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_select_item.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
            }
            con.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnsavestockentry_Click(object sender, EventArgs e)
        {
            if (txtcountitems.Text == "0" || txtcountstocks.Text == "0")
            {
                MessageBox.Show("Please Initiate Stock Entry at least One(1) Item.");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    query = " insert into tbl_stock_in(stock_in_id,supplier_id,dt_stock_in)values('" + txtstockinid.Text + "','" + txtsuppid.Text + "',curdate()) ";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Stock Entry Saved!");

                    txtstockinid.Text = "";

                    txtsuppid.Text = "";
                    txtsuppname.Text = "";

                    select_supp_panel.Visible = true;
                    select_item_panel.Visible = true;

                    loadcurrentStockIn();
                    loadselectsupplier();
                    loadselectitem();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        
    }
}
