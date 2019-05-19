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
    public partial class Vehicle_Information : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Vehicle_Information()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        public void resetF()
        {
            txtvehicleid.Text = "";
            txtplateno.Text = "";
            txtmodel.Text = "";
            txttype.Text = "";
            txtcolor.Text = "";
            txtdescription.Text = "";
            txtmaxweightkg.Text = "";
            txtmaxweightlbs.Text = "";
            txtvehicleweightkg.Text = "";
            txtvehicleweightlbs.Text = "";

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtplateno.Text == "" || txtmodel.Text == "" || txttype.Text == "" || txtcolor.Text == "" || txtdescription.Text == "" ||
                txtmaxweightkg.Text == "" || txtmaxweightlbs.Text == "" || txtvehicleweightkg.Text == "" || txtvehicleweightlbs.Text == "")
            {
                MessageBox.Show("Please Fill up All Requirements");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    query = "insert into tbl_vehicles_info(vehicle_id,plate_no,model,type,color,vehicle_desc,max_weight_kg,vehicle_weight_kg,vehicle_service_status,vehicle_delivery_status,dt_vehicle_reg)values "+
                        "('"+txtvehicleid.Text+"','"+txtplateno.Text+"','"+txtmodel.Text+"','"+txttype.Text+"','"+txtcolor.Text+"','"+txtdescription.Text+"','"+txtmaxweightkg.Text+"','"+txtvehicleweightkg.Text+"','In-service','Vacant',now())";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Vehicle Added!");
                    resetF();
                    loadvehicleinfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void txtmaxweightkg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d_kg = Convert.ToDouble(txtmaxweightkg.Text);
                double d_lbs = 2.204623;
                double calc_lbs = d_kg * d_lbs;
                txtmaxweightlbs.Text = Convert.ToString(calc_lbs);
            }
            catch (Exception ex)
            {
                txtmaxweightkg.Text = "";
                txtmaxweightlbs.Text = "";
            }
        }

        private void txtvehicleweightkg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d_kg = Convert.ToDouble(txtvehicleweightkg.Text);
                double d_lbs = 2.204623;
                double calc_lbs = d_kg * d_lbs;
                txtvehicleweightlbs.Text = Convert.ToString(calc_lbs);
            }
            catch (Exception ex)
            {
                txtvehicleweightkg.Text = "";
                txtvehicleweightlbs.Text = "";
            }
        }
        public void loadvehicleinfo()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from v_vehicle_info_del_route";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_vehicle_info.DataSource = bSource; 
        }
        private void Vehicle_Information_Load(object sender, EventArgs e)
        {
            loadvehicleinfo();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //con = new MySqlConnection(dbconnect.constr);
            //con.Open();
            //query = " select * from tbl_vehicles_info where vehicle_id like '%" + txtsearch.Text + "%' or plate_no like '%" + txtsearch.Text + "%' or model like '%" + txtsearch.Text + "%' or type like '%" + txtsearch.Text + "%' or color like '%" + txtsearch.Text + "%' or vehicle_desc like '%" + txtsearch.Text + "%' or max_weight_kg like '%" + txtsearch.Text + "%' or vehicle_weight_kg like '%" + txtsearch.Text + "%' or vehicle_service_status like '%" + txtsearch.Text + "%' or vehicle_delivery_status like '%" + txtsearch.Text + "%' or dt_vehicle_reg like '%" + txtsearch.Text + "%' ";
            //cmd = new MySqlCommand(query, con);
            //rdr = cmd.ExecuteReader();
            //dgv_vehicle_info.Rows.Clear();
            //while (rdr.Read() == true)
            //{
            //    dgv_vehicle_info.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10]);
            //}
            //con.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetF();
        }

        private void dgv_vehicle_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_vehicle_info.Rows[indexRow];
            panel1.Visible = true;
            up_vid.Text = row.Cells[0].Value.ToString();
            up_plateno.Text = row.Cells[1].Value.ToString();
            up_model.Text = row.Cells[2].Value.ToString();
            up_type.Text = row.Cells[3].Value.ToString();
            up_color.Text = row.Cells[4].Value.ToString();
            up_description.Text = row.Cells[5].Value.ToString();
            up_maxw_kg.Text = row.Cells[6].Value.ToString();
            up_vw_kg.Text = row.Cells[7].Value.ToString();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            up_vid.Text = "";
            up_plateno.Text = "";
            up_model.Text = "";
            up_type.Text = "";
            up_color.Text = "";
            up_description.Text = "";
            up_maxw_kg.Text = "";
            up_vw_kg.Text = "";

            
        }

        private void up_maxw_kg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d_kg = Convert.ToDouble(up_maxw_kg.Text);
                double d_lbs = 2.204623;
                double calc_lbs = d_kg * d_lbs;
                up_maxw_lbs.Text = Convert.ToString(calc_lbs);
            }
            catch (Exception ex)
            {
                up_maxw_kg.Text = "";
                up_maxw_lbs.Text = "";
            }
        }

        private void up_vw_kg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d_kg = Convert.ToDouble(up_vw_kg.Text);
                double d_lbs = 2.204623;
                double calc_lbs = d_kg * d_lbs;
                up_vw_lbs.Text = Convert.ToString(calc_lbs);
            }
            catch (Exception ex)
            {
                up_vw_kg.Text = "";
                up_vw_lbs.Text = "";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (up_vid.Text == "" ||
            up_plateno.Text == "" ||
            up_model.Text == "" ||
            up_type.Text == "" ||
            up_color.Text == "" ||
            up_description.Text == "" ||
            up_maxw_kg.Text == "" ||
            up_vw_kg.Text == "")
            {
                MessageBox.Show("Please Complete all Requirements.");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    query = "update tbl_vehicles_info set plate_no = '"+up_plateno.Text+"',model = '"+up_model.Text+"',type = '"+up_type.Text+"',color = '"+up_color.Text+"',vehicle_desc = '"+up_description.Text+"',max_weight_kg = '"+up_maxw_kg.Text+"',vehicle_weight_kg = '"+up_vw_kg.Text+"' where vehicle_id = '"+up_vid.Text+"'  ";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Vehicle Info Updated!");
                    loadvehicleinfo();

                    up_vid.Text = "" ;
                    up_plateno.Text = "" ;
                    up_model.Text = "" ;
                    up_type.Text = "" ;
                    up_color.Text = "" ;
                    up_description.Text = "" ;
                    up_maxw_kg.Text = "" ;
                    up_vw_kg.Text = "";

                    panel1.Visible = false;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
    }
}
