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
    public partial class Item_Stock_in : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Item_Stock_in()
        {
            InitializeComponent();
        }
        public void countItemStockIn()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from v_stock_logs where stock_in_id = '" + txtstockid.Text + "' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            
            while (rdr.Read() == true)
            {
                label7.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        private void txtstockid_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select item_code,item_name,stock_added,tracecode from v_stock_logs where stock_in_id = '"+txtstockid.Text+"' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_supplier_items.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_supplier_items.Rows.Add(rdr[0],rdr[1],rdr[2],rdr[3]);
            }
            con.Close();

            countItemStockIn();
        }

        private void Item_Stock_in_Load(object sender, EventArgs e)
        {

        }
    }
}
