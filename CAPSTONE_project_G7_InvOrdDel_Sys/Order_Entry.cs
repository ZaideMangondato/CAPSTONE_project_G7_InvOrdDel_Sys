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
    public partial class Order_Entry : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;

        public Order_Entry()
        {
            InitializeComponent();
        }
        public void nameDGV()
        {
            if (dgv_current_ordered_items.Columns.Count > 2)
            {
                //your code
                dgv_current_ordered_items.Columns[0].HeaderText = "Transaction No.";
                dgv_current_ordered_items.Columns[1].HeaderText = "Item Code";
                dgv_current_ordered_items.Columns[2].HeaderText = "Item Name";
                dgv_current_ordered_items.Columns[3].HeaderText = "Weight (kg.)";
                dgv_current_ordered_items.Columns[4].HeaderText = "Quantity";
                dgv_current_ordered_items.Columns[5].HeaderText = "Item Unit";
                dgv_current_ordered_items.Columns[6].HeaderText = "Item Price";
                dgv_current_ordered_items.Columns[7].HeaderText = "Total Price";
                dgv_current_ordered_items.Columns[8].HeaderText = "Date Ordered";
            }
        }


        //public void countnoitems()
        //{
        //}
        //public void totalqty()
        //{
        //}
        //public void totalweight()
        //{
        //}

        public void ctt()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*),sum(ord_qty),sum(total_item_weight_kg),sum(total_price) from tbl_ordered_items where trans_no = '"+txttransno.Text+"' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                try
                {
                    String countnoitems = rdr.GetString("count(*)");
                    String stotalqty = rdr.GetString("sum(ord_qty)");
                    String stotalweight = rdr.GetString("sum(total_item_weight_kg)");
                    String stotalprice = rdr.GetString("sum(total_price)");

                    double dou_stotalprice = Convert.ToDouble(stotalprice);

                    noitems.Text = countnoitems;
                    totalqty.Text = stotalqty;
                    totalweight.Text = stotalweight;
                    txttotalamount.Text = dou_stotalprice.ToString();
                }
                catch (Exception ex)
                {
                    noitems.Text = "0";
                    totalqty.Text = "0";
                    totalweight.Text = "0.0";
                    txttotalamount.Text = "0.0";
                }
            }
            con.Close();
        }
        public void loadcurrent_ordered_items()
        {
            

            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT ord_tracecode,item_code,item_name,total_item_weight_kg,ord_qty,item_unit,item_price,total_price from tbl_ordered_items where trans_no = '"+txttransno.Text+"'  ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_current_ordered_items.DataSource = bSource;

            ctt();
        }
        public void loadorderlogs()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_ordered_items";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_order_logs.DataSource = bSource;
        }
        public void loadsavedOrders()
        {
            con = new MySqlConnection(dbconnect.constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        MySqlDataAdapter da = new MySqlDataAdapter();
        string sql = "SELECT * from tbl_saved_orders";                    // Select Query Statement
        da.SelectCommand = new MySqlCommand(sql, con);
        DataTable table = new DataTable();
        da.Fill(table);
        BindingSource bSource = new BindingSource();
        bSource.DataSource = table;
        dgv_saved_orders.DataSource = bSource;
        }

        public void loadcbxroute()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select route_name from tbl_delivery_route order by route_name desc";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                cbxroute.Items.Add(rdr.GetString("route_name"));
            }
            con.Close();
        }
        private void Point_of_sale_Load(object sender, EventArgs e)
        {
            loadcbxroute();
            loadorderlogs();
            loadsavedOrders();
            loadcurrent_ordered_items();
            //nameDGV();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            type1.Checked = false;



        }

        private void label17_Click(object sender, EventArgs e)
        {

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
                dgv_select_item.Rows.Add(rdr[0],rdr[1],rdr[2],rdr[3],rdr[4],rdr[5],rdr[6]);
            }
            con.Close();

        }
        private void btnselectitem_Click(object sender, EventArgs e)
        {
            select_item.Visible = true;
            loadselectitem();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            select_item.Visible = false;
            loadselectitem();
        }

        private void txtsearchitem_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv where item_code like '%" + txtsearchitem.Text + "%' or item_name like '%" + txtsearchitem.Text + "%' or item_desc like '%" + txtsearchitem.Text + "%' or item_weight_kg like '%" + txtsearchitem.Text + "%' or no_of_stocks like '%" + txtsearchitem.Text + "%' or item_unit like '%" + txtsearchitem.Text + "%' or item_price like '%" + txtsearchitem.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_select_item.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_select_item.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
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
            txtweight.Text = row.Cells[3].Value.ToString();
            txtunit.Text = row.Cells[5].Value.ToString();
            txtitemprice.Text = row.Cells[6].Value.ToString();
            txtcurstock.Text = row.Cells[4].Value.ToString();
            select_item.Visible = false;
            loadselectitem();
        }

        private void txtqty_ValueChanged(object sender, EventArgs e)
        {
            
        }

        

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtcurstock.Text) <= 0)
                {
                    MessageBox.Show("The Item you selected is Out of Stock.");
                }
                else if (Convert.ToInt32(txtcurstock.Text) < (Convert.ToInt32(txtqty.Text)))
                {
                    MessageBox.Show("The Item stocks are not enough for your ordered quantity.");
                }
                else
                {
                    try
                    {
                        int i_qty = Convert.ToInt32(txtqty.Text);
                        double d_price = Convert.ToDouble(txtitemprice.Text);

                        double d_totalprice = i_qty * d_price;
                        txttotalprice.Text = d_totalprice.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txttotalprice.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
        }
        public void resetEntry()
        {
            txtqty.Text = "0";

            txttracecode.Text = "";
            txtitemcode.Text = "";
            txtitemname.Text = "";
            txtweight.Text = "";
            txtitemprice.Text = "0.0";
            txtcurstock.Text = "";
            txtunit.Text = ". . .";
            txttotalprice.Text = "";

        }

        public void updateItemInv()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "update tbl_items_inv set no_of_stocks = '" + ((Convert.ToInt32(txtcurstock.Text)) - (Convert.ToInt32(txtqty.Text))) + "' where item_code = '" + txtitemcode.Text + "' ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Item Inventory Deducted");
        }

        public void addToOrdItems()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "insert into tbl_ordered_items(trans_no,item_code,item_name,item_weight_kg,total_item_weight_kg,ord_qty,item_unit,item_price,total_price,dt_ordered,ord_tracecode)values('"+txttransno.Text+"','"+txtitemcode.Text+"','"+txtitemname.Text+"','"+txtweight.Text+"','"+((Convert.ToDouble(txtweight.Text))*(Convert.ToInt32(txtqty.Text)))+"','"+txtqty.Text+"','"+txtunit.Text+"','"+txtitemprice.Text+"','"+txttotalprice.Text+"',curdate(),'"+txttracecode.Text+"')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Ordered Item Added.");
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtsoldto.Text ==""|| txtdestination.Text == ""||txtcontactno.Text ==""||   txtitemcode.Text == "" || txtqty.Text == "0" || txtqty.Text == "")
            {
                MessageBox.Show("Please complete All Fields.");
            }
            else
            {
                try
                {
                    addToOrdItems();
                    updateItemInv();
                    loadcurrent_ordered_items();
                    loadselectitem();
                    resetEntry();
                    loadorderlogs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The error is here");
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            remove_panel.Visible = false;

        }

        private void dgv_current_ordered_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_current_ordered_items.Rows[indexRow];
            re_tracecode.Text = row.Cells[0].Value.ToString();
            re_itemcode.Text = row.Cells[1].Value.ToString();
            re_itemname.Text = row.Cells[2].Value.ToString();
            re_ordstock.Text = row.Cells[4].Value.ToString();
            remove_panel.Visible = true;

        }

        private void txtcurstock_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(txtcurstock.Text) <= 0)
            //{
            //    MessageBox.Show("The Item you select is Out of Stock.");
            //}
            //else
            //{
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetEntry();
        }

        private void re_itemcode_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_full_items_inv where item_code = '" + re_itemcode.Text + "' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String sno_of_stocks = rdr.GetString("no_of_stocks");
                re_curstock.Text = sno_of_stocks;
            }
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            remove_panel.Visible = false;
        }


        public void updateRE_ItemInv()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "  update tbl_items_inv set no_of_stocks = '"+((Convert.ToInt32(re_curstock.Text))+(Convert.ToInt32(re_ordstock.Text)))+"' where item_code = '"+re_itemcode.Text+"'  ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Item back to its original stock.");
        }
        public void removeRE_ItemEntry()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "delete from tbl_ordered_items where ord_tracecode = '"+re_tracecode.Text+"' ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Item has been Removed");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                removeRE_ItemEntry();
                updateRE_ItemInv();

                loadcurrent_ordered_items();
                loadselectitem();

                remove_panel.Visible = false;

                re_tracecode.Text = "";
                re_itemcode.Text = "";
                re_itemname.Text = "";
                re_curstock.Text = "";
                re_ordstock.Text = "";

                loadorderlogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void saveOrderRoute()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "insert into tbl_saved_orders_route(trans_no,route_code)values('"+txttransno.Text+"','"+txtroute.Text+"')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        public void saveOrderTransaction()
        {
            saveOrderRoute();
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "insert into tbl_saved_orders(trans_no,sold_to,contact_no,del_destination,expctd_dt_delivery,no_of_items,total_qty,total_weight_kg,total_amount,dt_ordered,trans_type)values('" + txttransno.Text + "','" + txtsoldto.Text + "','" + txtcontactno.Text + "','" + txtdestination.Text + "','"+txtexpctd_dt.Text+"','" + noitems.Text + "','" + totalqty.Text + "','" + totalweight.Text + "','" + txttotalamount.Text + "',curdate(),'" + type1.Text + "')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        public void saveAsForDeliveryTrans()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "insert into tbl_for_delivery_trans(trans_no,trans_type,delivery_status,dt_pending,dt_delivering,dt_delivered)values('"+txttransno.Text+"','"+type1.Text+"','Pending',now(),'---','---')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Transaction has been Saved as: For-Delivery.");
        }
        private void btnsaveorder_Click(object sender, EventArgs e)
        {
            
              if (txtsoldto.Text == "" || txtdestination.Text == "" || txtcontactno.Text == "" ||
                noitems.Text == "0" || totalqty.Text == "0" || totalweight.Text == "0.0")
                {
                    MessageBox.Show("Please Complete all Requirements.");
                }
                else
                {

                  if (type1.Checked == true)
                  {
                      try
                      {
                          saveOrderTransaction();
                          MessageBox.Show("Order Saved!");
                          saveAsForDeliveryTrans();

                          txttransno.Text = "";
                          txtsoldto.Text = "";
                          txtdestination.Text = "";
                          txtcontactno.Text = "";
                          txtexpctd_dt.Text = "";
                          loadcurrent_ordered_items();
                          type1.Checked = false;
                          type2.Checked = false;
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                          con.Close();
                      }
                  }
                  else if (type2.Checked == true)
                  {
                      try
                      {

                          con = new MySqlConnection(dbconnect.constr);
                          con.Open();
                          query = "insert into tbl_saved_orders(trans_no,sold_to,contact_no,del_destination,no_of_items,total_qty,total_weight_kg,total_amount,dt_ordered,trans_type)values('"+txttransno.Text+"','"+txtsoldto.Text+"','"+txtcontactno.Text+"','"+txtdestination.Text+"','"+noitems.Text+"','"+totalqty.Text+"','"+totalweight.Text+"','"+txttotalamount.Text+"',curdate(),'"+type2.Text+"')";
                          cmd = new MySqlCommand(query, con);
                          cmd.ExecuteReader();
                          con.Close();
                          MessageBox.Show("Transaction has been Saved as: Non-Delivery.");
                          txttransno.Text = "";
                          txtsoldto.Text = "";
                          txtdestination.Text = "";
                          txtcontactno.Text = "";
                          loadcurrent_ordered_items();
                          type1.Checked = false;
                          type2.Checked = false;

                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                          con.Close();
                      }
                  }
                  else 
                  {
                      MessageBox.Show("Please Check a Transaction type..");
                  }
                    //test
                   // MessageBox.Show("Completed.");
                }


              loadsavedOrders();


            
        }

        private void dgv_saved_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Order_Full_info ofi = new Order_Full_info();
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_saved_orders.Rows[indexRow];
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

        private void type1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxroute_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            string query = "select * from tbl_delivery_route where route_name = '"+cbxroute.Text+"' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            while(rdr.Read() == true){
                txtroute.Text = rdr.GetString("route_code");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               con = new MySqlConnection(dbconnect.constr);
        con.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        MySqlDataAdapter da = new MySqlDataAdapter();
        string sql = "SELECT * from tbl_saved_orders where trans_no like '%" + textBox1.Text + "%' or sold_to like '%" + textBox1.Text + "%' or contact_no like '%" + textBox1.Text + "%' or del_destination like '%" + textBox1.Text + "%' or expctd_dt_delivery like '%" + textBox1.Text + "%' or no_of_items like '%" + textBox1.Text + "%' or total_qty like '%" + textBox1.Text + "%' or total_weight_kg like '%" + textBox1.Text + "%' or total_amount like '%" + textBox1.Text + "%' or dt_ordered like '%" + textBox1.Text + "%' or trans_type like '%" + textBox1.Text + "%' ";                    // Select Query Statement
        da.SelectCommand = new MySqlCommand(sql, con);
        DataTable table = new DataTable();
        da.Fill(table);
        BindingSource bSource = new BindingSource();
        bSource.DataSource = table;
        dgv_saved_orders.DataSource = bSource;
        }
        
    }
}
