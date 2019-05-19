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
    public partial class Available_Vacant_Vehicles : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Available_Vacant_Vehicles()
        {
            InitializeComponent();
        }
        public void loadAV_vehicles()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select * from tbl_vehicles_info where vehicle_service_status = 'In-service' and vehicle_delivery_status = 'Vacant' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_av_vehicles.DataSource = bSource;
        }
        private void Available_Vacant_Vehicles_Load(object sender, EventArgs e)
        {
            loadAV_vehicles();
        }

        private void dgv_av_vehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Delivery_Management dm = new Delivery_Management();
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_av_vehicles.Rows[indexRow];
            dm.txtvid.Text = row.Cells["vehicle_id"].Value.ToString();
            dm.txtplateno.Text = row.Cells["plate_no"].Value.ToString();
            dm.txtmodel.Text = row.Cells["model"].Value.ToString();
            dm.txtloadcapacity_kg.Text = row.Cells["max_weight_kg"].Value.ToString();

            dm.ShowDialog();
        }
    }
}
