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
    public partial class Delivery_Management : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Delivery_Management()
        {
            InitializeComponent();
        }
        public void loadcountpendingdeltrans()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("select count(*) from v_saved_for_delivery_orders,v_saved_orders_route where (v_saved_for_delivery_orders.trans_no = v_saved_orders_route.trans_no and v_saved_orders_route.route_name='" + txtroutename.Text + "') and (trans_type = 'For-Delivery' and delivery_status = 'Pending')", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblcountpending.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void loadpendingdeltrans()
        {
            
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            //string sql = "SELECT * from v_saved_for_delivery_orders where trans_type = 'For-Delivery' and delivery_status = 'Pending' ";  
            string sql = "select * from v_saved_for_delivery_orders,v_saved_orders_route where (v_saved_for_delivery_orders.trans_no = v_saved_orders_route.trans_no and v_saved_orders_route.route_name='"+txtroutename.Text+"') and (trans_type = 'For-Delivery' and delivery_status = 'Pending') "; // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_pending_deltrans.DataSource = bSource;
        }

        //----------------------------------------------------------------------------------
        public void countwtm()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "SELECT count(*) from v_vehicle_selection where route_code = 'wtm' and vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                lblwtm.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void countotm()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "SELECT count(*) from v_vehicle_selection where route_code = 'otm' and vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblotm.Text = rdr.GetString("count(*)");
            }
            con.Close();

        }
        public void countotp()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "SELECT count(*) from v_vehicle_selection where route_code = 'otp' and vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblotp.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void loadwtm()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_vehicle_selection where route_code = 'wtm' and vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_wtm.DataSource = bSource;
            countwtm();
        }
        public void loadotm()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_vehicle_selection where route_code = 'otm'  and vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_otm.DataSource = bSource;
            countotm();
        }
        public void loadotp()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_vehicle_selection where route_code = 'otp'  and vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_otp.DataSource = bSource;
            countotp();
        }
        public void loadallvehicles()
        {
            loadwtm();
            loadotm();
            loadotp();
        }
        //----------------------------------------------------------------------------------
        private void Delivery_Management_Load(object sender, EventArgs e)
        {
            loadallvehicles();
            //loadpendingdeltrans();

        }

        private void dgv_av_vehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtloadedtrans_kg.Text == "0.0" || txtloadedtrans_kg.Text == "0")
            {
                txtdelivery_id.Text = "";
                txtvid.Text = "";
                txtplateno.Text = "";
                txtmodel.Text = "";
                txtloadcapacity_kg.Text = "";
      
            }
            else
            {
                MessageBox.Show("You need to empty the Vehicle before Deselecting.");
            }


            
        }
        public void sumloadedtranskg_sumTotalCost()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select sum(total_weight_kg),sum(total_amount) from v_delivery_entries where delivery_id = '"+txtdelivery_id.Text+"'";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                try
                {
                    String tw = rdr.GetString("sum(total_weight_kg)");
                    String tc = rdr.GetString("sum(total_amount)");
                    txtloadedtrans_kg.Text = tw;
                    txttotalcost.Text = tc;
                }
                catch (Exception ex)
                {
                    txtloadedtrans_kg.Text = "0.0";
                    txttotalcost.Text = "0.0";
                }
            }
            con.Close();
        }
        public void countenteredorders()
        {
            
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "select count(*) from v_delivery_entries where delivery_id = '" + txtdelivery_id.Text + "' and vehicle_id = '" + txtvid.Text + "' ";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    String count = rdr.GetString("count(*)");
                    txtcountorders.Text = count;
                }
                con.Close();
            
            
        }
        public void loaddeliveryentries()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT trans_no,sold_to,contact_no,del_destination,no_of_items,total_qty,total_weight_kg,total_amount,dt_ordered from v_delivery_entries where delivery_id = '" + txtdelivery_id.Text + "' and vehicle_id = '" + txtvid.Text + "' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_delivery_vehicle.DataSource = bSource;

            sumloadedtranskg_sumTotalCost();
            countenteredorders();
        }
        private void txtvid_TextChanged(object sender, EventArgs e)
        {

            loaddeliveryentries();
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_pending_deltrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //0,6
            if (txtvid.Text == "")
            {
                MessageBox.Show("Please Select a Delivery Vehicle first.");
            }
            else
            {
                int indexRow;
                indexRow = e.RowIndex;
                DataGridViewRow row = dgv_pending_deltrans.Rows[indexRow];
                panel3.Visible = true;
                pdt_transno.Text = row.Cells[0].Value.ToString();
                pdt_tw.Text = row.Cells[6].Value.ToString();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pdt_transno.Text = "";
            pdt_tw.Text = "";
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pdt_transno.Text = "";
            pdt_tw.Text = "";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Order_Full_info ofi = new Order_Full_info();
            ofi.jo_transno.Text = pdt_transno.Text;
            ofi.ShowDialog();
        }
        //-------------------------------------------------------------------------------------------------
        public void addDeliveryIDToDeliveryTransUPDT()
        {
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    query = "update tbl_for_delivery_trans set delivery_id = '"+txtdelivery_id.Text+"' where trans_no='"+pdt_transno.Text+"' ";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
        public void addTodeliveryvehicle()
        {
            try
            {
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "insert into tbl_delivery_entries(delivery_id,vehicle_id,trans_no)values('"+txtdelivery_id.Text+"','"+txtvid.Text+"','"+pdt_transno.Text+"')";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            addDeliveryIDToDeliveryTransUPDT();
        }
        public void updateDeliveryTrans()
        {
            try
            {
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "update tbl_for_delivery_trans set delivery_status = 'Delivering', dt_delivering = now() where trans_no = '"+pdt_transno.Text+"'  ";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        //-------------------------------------------------------------------------------------------------
        private void btnconf_Click(object sender, EventArgs e)
        {
            
            try
            {
                double selectedtranskg = Convert.ToDouble(pdt_tw.Text);
                double loadedtranskg = Convert.ToDouble(txtloadedtrans_kg.Text);
                double loadcapacitykg = Convert.ToDouble(txtloadcapacity_kg.Text);
                //MessageBox.Show((selectedtranskg + loadedtranskg)+"..");
                if ((selectedtranskg + loadedtranskg) > loadcapacitykg)
                {
                    MessageBox.Show("The transaction you selected is over weight for the Allotted load capacity");
                    panel3.Visible = false;
                    pdt_transno.Text = "";
                    pdt_tw.Text = "";

                }
                else if ((selectedtranskg + loadedtranskg) < loadcapacitykg)
                {
                    MessageBox.Show("The Vehicle can still carry more.");
                    addTodeliveryvehicle();
                    updateDeliveryTrans();

                    loaddeliveryentries();
                    loadpendingdeltrans();
                    countenteredorders();
                    loadcountpendingdeltrans();

                    panel3.Visible = false;
                    pdt_transno.Text = "";
                    pdt_tw.Text = "";

                }
                else if ((selectedtranskg + loadedtranskg) == loadcapacitykg)
                {
                    MessageBox.Show("The Vehicle will be fully loaded after adding this transaction to the selected vehicle.");
                    addTodeliveryvehicle();
                    updateDeliveryTrans();

                    loaddeliveryentries();
                    loadpendingdeltrans();
                    countenteredorders();
                    loadcountpendingdeltrans();

                    panel3.Visible = false;
                    pdt_transno.Text = "";
                    pdt_tw.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtdelivery_id_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_delivery_vehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel4.Visible = true;
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_delivery_vehicle.Rows[indexRow];
            rmv_transno.Text = row.Cells[0].Value.ToString();


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtloadedtrans_kg.Text == "0" || txtloadedtrans_kg.Text == "0.0" || txtloadedtrans_kg.Text == "")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("You must Close the selected Vehicle.");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            rmv_transno.Text = "";
            panel4.Visible = false;

        }

        private void rmv_transno_TextChanged(object sender, EventArgs e)
        {

        }
        public void removeDeliveryIDfromDeliveryTrans()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "  update tbl_for_delivery_trans set delivery_id = '' where trans_no='" + rmv_transno.Text + "' ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
        }
        public void removeFromDeliveryVehicle()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "  delete from tbl_delivery_entries where delivery_id = '"+txtdelivery_id.Text+"' and vehicle_id = '"+txtvid.Text+"' and trans_no = '"+rmv_transno.Text+"'  ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            removeDeliveryIDfromDeliveryTrans();
        }
        public void updateToPending_Trans()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = " update tbl_for_delivery_trans set delivery_status = 'Pending', dt_delivering = '---' where trans_no = '"+rmv_transno.Text+"'  ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
        }
        private void btn_rmvconf_Click(object sender, EventArgs e)
        {
            try
            {
                removeFromDeliveryVehicle();
                updateToPending_Trans();

                loaddeliveryentries();
                loadpendingdeltrans();
                countenteredorders();
                loadcountpendingdeltrans();

                rmv_transno.Text = "";
                panel4.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btn_rmvcanc_Click(object sender, EventArgs e)
        {
            rmv_transno.Text = "";
            panel4.Visible = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Order_Full_info ofi = new Order_Full_info();
            ofi.jo_transno.Text = rmv_transno.Text;
            ofi.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadpendingwtm()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("select count(*) from v_saved_for_delivery_orders,v_saved_orders_route where v_saved_for_delivery_orders.trans_no = v_saved_orders_route.trans_no and v_saved_orders_route.route_name='Within the municipality'  and v_saved_for_delivery_orders.delivery_status = 'pending'", con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                lblpendingorders.Text = rdr.GetString("count(*)");

            }
            con.Close();
        }
        private void dgv_wtm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadpendingwtm();
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgv_wtm.Rows[indexRow];
            vi_vid.Text = row.Cells["vehicle_id"].Value.ToString();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            

        }

        private void selectVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            vi_vid.Text = "";
            lblpendingorders.Text = ".";
            loadallvehicles();
        }

        private void vi_vid_TextChanged(object sender, EventArgs e)
        {
            if (vi_vid.Text == "")
            {
                vi_plateno.Text = ". . . .";
                vi_model.Text = ". . . .";
                vi_type.Text = ". . . .";
                vi_maxw.Text = ". . . .";
                vi_servstat.Text = ". . . .";
                vi_delstat.Text = ". . . .";
                vi_routename.Text = ". . . .";
            }
            else
            {

                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "select * from v_vehicle_selection where vehicle_id = '" + vi_vid.Text + "' ";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    vi_plateno.Text = rdr.GetString("plate_no");
                    vi_model.Text = rdr.GetString("model");
                    vi_type.Text = rdr.GetString("type");
                    vi_maxw.Text = rdr.GetString("max_weight_kg");
                    vi_servstat.Text = rdr.GetString("vehicle_service_status");
                    vi_delstat.Text = rdr.GetString("vehicle_delivery_status");
                    vi_routename.Text = rdr.GetString("route_name");
                }
                con.Close();
            }
        }
        public void loadpendingotm()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("select count(*) from v_saved_for_delivery_orders,v_saved_orders_route where v_saved_for_delivery_orders.trans_no = v_saved_orders_route.trans_no and v_saved_orders_route.route_name='Outside the municipality'  and v_saved_for_delivery_orders.delivery_status = 'pending'", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblpendingorders.Text = rdr.GetString("count(*)");

            }
            con.Close();
        }
        private void dgv_otm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadpendingotm();
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgv_otm.Rows[indexRow];
            vi_vid.Text = row.Cells["vehicle_id"].Value.ToString();
        }
        public void loadpendingotp()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("select count(*) from v_saved_for_delivery_orders,v_saved_orders_route where v_saved_for_delivery_orders.trans_no = v_saved_orders_route.trans_no and v_saved_orders_route.route_name='Outside the Province'  and v_saved_for_delivery_orders.delivery_status = 'pending'", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblpendingorders.Text = rdr.GetString("count(*)");

            }
            con.Close();
        }
        private void dgv_otp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadpendingotp();
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgv_otp.Rows[indexRow];
            vi_vid.Text = row.Cells["vehicle_id"].Value.ToString();
        }


        public void countEmp()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "SELECT count(*) from tbl_assigned_emp where delivery_id = '" + txtdelivery_id.Text + "'  ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                lblcountemp.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void loadassignedemp()
        {
            countEmp();
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_assigned_emp where delivery_id = '"+txtdelivery_id.Text+"' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_assigned_emp.DataSource = bSource;
        }
        private void btnselect_Click(object sender, EventArgs e)
        {
            if (txtloadedtrans_kg.Text == "0" || txtloadedtrans_kg.Text == "0.0" || txtloadedtrans_kg.Text == "")
            {
                if (vi_vid.Text == "")
                {
                    //codes for selecting vehicle.
                    MessageBox.Show("You must select a Delivery Vehicle.");

                }
                else
                {
                    txtvid.Text = vi_vid.Text;
                    txtmodel.Text = vi_model.Text;
                    txtplateno.Text = vi_plateno.Text;
                    txtloadcapacity_kg.Text = vi_maxw.Text;
                    txtroutename.Text = vi_routename.Text;

                    panel1.Visible = false;

                    expensesTab.Visible = true;
                    loadassignedemp();
                  

                    loadcountpendingdeltrans();

                 

                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    string sql = "select * from v_saved_for_delivery_orders,v_saved_orders_route where v_saved_for_delivery_orders.trans_no =  v_saved_orders_route.trans_no and v_saved_orders_route.route_name='" + vi_routename.Text + "' and delivery_status = 'pending'";                    // Select Query Statement
                    da.SelectCommand = new MySqlCommand(sql, con);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;
                    dgv_pending_deltrans.DataSource = bSource;
                }
            }
            else
            {
                MessageBox.Show("Current Vehicle should be Empty.");
            }
        }

        private void txtroutename_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select route_code from tbl_delivery_route where route_name = '"+txtroutename.Text+"' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                txtroutecode.Text = rdr.GetString("route_code");
            }
            con.Close();
        }

        private void txtroutecode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_select_emp.Visible = true;
            btncloseselect.Visible = true;
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_employees where emp_status='vacant' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_select_emp.DataSource = bSource;
        }

        private void dgv_select_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_select_emp.Rows[indexRow];

            txtemp_id.Text = row.Cells[0].Value.ToString();
            txtemp_name.Text = row.Cells[1].Value.ToString();
            dgv_select_emp.Visible = false;
            btncloseselect.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv_select_emp.Visible = false;
            btncloseselect.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtemp_id.Text == "")
            {
                MessageBox.Show("Please Select an Empoyee");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    cmd = new MySqlCommand("insert into tbl_assigned_emp(delivery_id,emp_id)values('" + txtdelivery_id.Text + "','" + txtemp_id.Text + "')", con);
                    cmd.ExecuteReader();
                    con.Close();
                    txtemp_id.Text = "";
                    txtemp_name.Text = "";
                    loadassignedemp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                
            }
        }
        public void updateVehicleToInUse()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            cmd = new MySqlCommand("update tbl_vehicles_info set vehicle_delivery_status = 'In-use' where vehicle_id = '"+txtvid.Text+"' ",con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Vehicle delivery status has been set to 'In-use' ");
        }
        private void btnconfdelivery_Click(object sender, EventArgs e)
        {
            if (lblcountemp.Text == "0" || lblcountemp.Text == "1" || txtcountorders.Text == "" || txtcountorders.Text == "0")
            {
                MessageBox.Show("Please Add Atleast 2 Employees");
            }
            else
            {
                // MessageBox.Show("Ready for Saving Delivery Transactions");
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    String values = "('" + txtdelivery_id.Text + "','" + txtvid.Text + "','" + txtroutecode.Text + "','" + txtloadcapacity_kg.Text + "','" + txtloadedtrans_kg.Text + "','" + txtcountorders.Text + "','" + txttotalcost.Text + "','" + txtfuel_cost.Text + "','" + txtother_charges.Text + "','" + txtothers_cost.Text + "','" + txtdistance.Text + "','" + txtestimated_dt_arr.Text + "',now())";
                    query = "insert into tbl_saved_delivery(delivery_id,vehicle_id,route_code,load_capacity_kg,loaded_kg,no_of_orders,total_cost,est_fuel_cost,extra_charges,extra_chrgs_total_cost,delivery_distance,est_dt_arrival,dt_delivery)values" + values;
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Delivery Entry Successfully Saved.");
                    updateVehicleToInUse();
                    txtdelivery_id.Text = "";
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtplateno_TextChanged(object sender, EventArgs e)
        {

        }

       

       

       
    }
}
