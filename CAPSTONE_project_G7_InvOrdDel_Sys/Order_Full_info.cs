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
    public partial class Order_Full_info : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Order_Full_info()
        {
            InitializeComponent();
        }
        public void loadTransNo_OrderedItems()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT ord_tracecode,item_code,item_name,total_item_weight_kg,ord_qty,item_unit,item_price,total_price from tbl_ordered_items where trans_no = '" + jo_transno.Text + "'";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_job_order.DataSource = bSource;
        }
        public void transdeliverystatus()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select delivery_status from tbl_for_delivery_trans where trans_no = '"+jo_transno.Text+"' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String delstat = rdr.GetString("delivery_status");
                jo_delstatus.Text = delstat;
            }
            con.Close();
        }
        public void loaddeliverystatus_forDelivery()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT dt_pending,dt_delivering,dt_delivered from tbl_for_delivery_trans where trans_no = '"+jo_transno.Text+"' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_fordeltrans_status.DataSource = bSource;

            transdeliverystatus();
        }
        public void changeLabel()
        {
            if (jo_transtype.Text == "For-Delivery")
            {
                label3.Text = "Delivery Destination";
            }else if(jo_transtype.Text == "Non-Delivery"){
                label3.Text = "Address";
                label11.Visible = false;
                jo_route.Visible = false;

            }
        }
        public void changeStatusColor()
        {
            
        }
        private void Order_Full_info_Load(object sender, EventArgs e)
        {
            changeLabel();
            loadTransNo_OrderedItems();

            changeStatusColor();
            
            
            if (jo_transtype.Text == "For-Delivery")
            {
                loaddeliverystatus_forDelivery();
            }
            else if (jo_transtype.Text == "Non-Delivery")
            {
                jo_delstatus.Text = "N/A";
            }
        }
        public void loadorderroute()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_saved_orders_route where trans_no = '" + jo_transno.Text + "' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                jo_route.Text = rdr.GetString("route_name");
            }
            con.Close();

        }
        private void jo_transno_TextChanged(object sender, EventArgs e)
        {
            loadorderroute();
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from tbl_saved_orders where trans_no = '"+jo_transno.Text+"' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String s_soldto = rdr.GetString("sold_to");
                String s_deldest = rdr.GetString("del_destination");
                String s_dtord = rdr.GetString("dt_ordered");
                String s_contno = rdr.GetString("contact_no");
                String s_expctd_dt_delivery = rdr.GetString("expctd_dt_delivery");
                String s_noitems = rdr.GetString("no_of_items");
                String s_tqty = rdr.GetString("total_qty");
                String s_tweight = rdr.GetString("total_weight_kg");
                String s_tamnt = rdr.GetString("total_amount");
                String s_type = rdr.GetString("trans_type");
                jo_soldto.Text = s_soldto;
                jo_destination.Text = s_deldest;
                jo_dtordered.Text = s_dtord;
                jo_contactno.Text = s_contno;
                jo_expctd_dt_delivery.Text = s_expctd_dt_delivery;
                jo_noitems.Text = s_noitems;
                jo_totalqty.Text = s_tqty;
                jo_totalweight.Text = s_tweight;
                jo_totalamount.Text = s_tamnt;
                jo_transtype.Text = s_type;

            }
            con.Close();
        }

        private void jo_dtordered_TextChanged(object sender, EventArgs e)
        {

        }

        private void jo_expctd_dt_delivery_TextChanged(object sender, EventArgs e)
        {

        }

        private void jo_delstatus_TextChanged(object sender, EventArgs e)
        {
            if (jo_delstatus.Text == "Pending")
            {
                jo_delstatus.ForeColor = Color.DarkOrange;

            }
            else if (jo_delstatus.Text == "Delivering")
            {
                jo_delstatus.ForeColor = Color.Blue;
            }
            else if (jo_delstatus.Text == "Delivered")
            {
                jo_delstatus.ForeColor = Color.DarkGreen;
            }
        }
    }
}
