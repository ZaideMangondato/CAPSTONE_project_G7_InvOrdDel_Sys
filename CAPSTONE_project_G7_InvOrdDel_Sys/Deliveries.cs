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

    public partial class Deliveries : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Deliveries()
        {
            InitializeComponent();
        }

        public void countDeliveredOrders()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_saved_delivered";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                label16.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void loadDeliveredOrders()
        {
            countDeliveredOrders();

            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_saved_delivered";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_delivered.DataSource = bSource;
            con.Close();
        }
        //-------------
        public void countDeliveringOrders()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_saved_delivery";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                label2.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void loadDeliveringOrders()
        {
            countDeliveringOrders();

            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_saved_delivery";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_delivering.DataSource = bSource;
            con.Close();
        }
        private void Deliveries_Load(object sender, EventArgs e)
        {
            loadDeliveringOrders();
            loadDeliveredOrders();
        }

        private void dgv_delivering_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dd_deliveryid.Text = "";
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_delivering.Rows[indexRow];
            panel2.Visible = true;
            dd_deliveryid.Text = row.Cells[0].Value.ToString();
            button1.Visible = true;
            //txt_code.Text = row.Cells[0].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dd_deliveryid.Text = "";

        }
        public void countOnBoard()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from v_delivery_trans_orders_full where delivery_id = '" + dd_deliveryid.Text + "'";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblonboard.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }

        public void loadcargoinfo()
        {
          
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "select * from tbl_saved_delivery where delivery_id = '" + dd_deliveryid.Text + "'";
                cmd = new MySqlCommand(query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    dd_vehicleid.Text = rdr.GetString("vehicle_id");
                    txtroutecode.Text = rdr.GetString("route_code");
                    txtcapacity.Text = rdr.GetString("load_capacity_kg");
                    txtloaded.Text = rdr.GetString("loaded_kg");
                    txtnooforders.Text = rdr.GetString("no_of_orders");
                    txttotalcost.Text = rdr.GetString("total_cost");
                    txtdistance.Text = rdr.GetString("delivery_distance");
                    txtestimdatetimearrv.Text = rdr.GetString("est_dt_arrival");
                    txtdtdelivery.Text = rdr.GetString("dt_delivery");

                }
                con.Close();
           
        }
        private void dd_deliveryid_TextChanged(object sender, EventArgs e)
        {
            

            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_delivery_trans_orders_full where delivery_id = '"+dd_deliveryid.Text+"' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_delivery_details.DataSource = bSource;
            con.Close();


            countOnBoard();
            loadcargoinfo();
        }

        private void dgv_delivery_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Order_Full_info ofi = new Order_Full_info();
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_delivery_details.Rows[indexRow];
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

        private void txtroutecode_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select route_name from tbl_delivery_route where route_code = '" + txtroutecode.Text + "'  ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                txtroutename.Text = rdr.GetString("route_name");
            }
            con.Close();
        }






        //-------------------------------------------------
        public void updateDeliveryTransToDelivered()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("update tbl_for_delivery_trans set delivery_status = 'Delivered', dt_delivered = now() where delivery_id = '"+dd_deliveryid.Text+"'", con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Delivery Status has been changed to 'Delivered'. ");

        }
        public void updateVehicleStatusToVacant()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("update tbl_vehicles_info set vehicle_delivery_status = 'Vacant' where vehicle_id = '"+dd_vehicleid.Text+"'    ", con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Vehicle's Delivery Status has been changed to 'Vacant'. ");
        }
        public void insertDeliveryToDelivered()
        {
            
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("insert into tbl_saved_delivered select * from tbl_saved_delivery where delivery_id = '" + dd_deliveryid.Text + "' ", con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("All Transactions Has been saved as Delivered. ");
        }
        public void deleteSpecifiedDelivering()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("delete from tbl_saved_delivery where delivery_id = '"+dd_deliveryid.Text+"'    ", con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Delivering Transaction has been removed. ");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                updateDeliveryTransToDelivered();
                updateVehicleStatusToVacant();
                
                insertDeliveryToDelivered();
                
                deleteSpecifiedDelivering();


                loadDeliveringOrders();
                loadDeliveredOrders();
                panel2.Visible = false;
                dd_deliveryid.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_delivered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dd_deliveryid.Text = "";
            
            
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow rows = dgv_delivered.Rows[indexRow];
            panel2.Visible = true;
            dd_deliveryid.Text = rows.Cells[0].Value.ToString();
            button1.Visible = false;
            label13.Text = "Order(s) Delivered";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
