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
    public partial class Item_Information : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Item_Information()
        {
            InitializeComponent();
        }

       
        public void loaditeminfo()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_items";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_item_info.DataSource = bSource;
        }
        private void Item_Information_Load(object sender, EventArgs e)
        {
            loaditeminfo();

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            gencode.Text = "";
            txtcode.Text = gencode.Text;

        }
        public void resetF()
        {
            txtcode.Text = "";
            txtname.Text = "";
            txtdesc.Text = "";
            txtprice.Text = "";
            txtunit.Text = "";
            txtweight.Text = "";
            gencode.Text = "";
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            resetF();
        }

        private void txtweight_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                double d_kg = Convert.ToDouble(txtweight.Text);
                double d_lbs = 2.204623;
                double calc_lbs = d_kg * d_lbs;
                txtlbs.Text = Convert.ToString(calc_lbs);
            }
            catch (Exception ex)
            {
                txtweight.Text = "";
                txtlbs.Text = "";
            }
        }
        public void saveiteminfo()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "insert into tbl_items(item_code,item_name,item_desc,item_weight_kg,item_unit,item_price)values('"+txtcode.Text+"','"+txtname.Text+"','"+txtdesc.Text+"','"+txtweight.Text+"','"+txtunit.Text+"','"+txtprice.Text+"')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }
        public void saveitemzeroinv()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "insert into tbl_items_inv(item_code,no_of_stocks)values('"+txtcode.Text+"','0')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "" || txtname.Text == "" || txtdesc.Text == "" || txtweight.Text == "" || txtunit.Text == "" || txtprice.Text == "")
            {
                MessageBox.Show("Please Fill up All Requirements");
            }
            else
            {
                try
                {
                    saveiteminfo();
                    saveitemzeroinv();
                    loaditeminfo();
                    resetF();
                    MessageBox.Show("Successfully Saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgv_item_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_item_info.Rows[indexRow];
            panel_update.Visible = true;
            upcode.Text = row.Cells[0].Value.ToString();
            upname.Text = row.Cells[1].Value.ToString();
            updesc.Text = row.Cells[2].Value.ToString();
            upweight.Text = row.Cells[3].Value.ToString();
            upunit.Text = row.Cells[4].Value.ToString();
            upprice.Text = row.Cells[5].Value.ToString();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel_update.Visible = false;
            upcode.Text = "";
            upname.Text = "";
            updesc.Text = "";
            upprice.Text = "";
            upunit.Text = "";
            upweight.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "update tbl_items set item_name = '"+upname.Text+"',item_desc = '"+updesc.Text+"',item_weight_kg = '"+upweight.Text+"',item_unit = '"+upunit.Text+"',item_price = '"+upprice.Text+"' where item_code = '"+upcode.Text+"'";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteReader();
                MessageBox.Show("Item Updated!");
                con.Close();
                panel_update.Visible = false;
                upcode.Text = "";
                upname.Text = "";
                updesc.Text = "";
                upprice.Text = "";
                upunit.Text = "";
                upweight.Text = "";
                loaditeminfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void upweight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double d_kg = Convert.ToDouble(upweight.Text);
                double d_lbs = 2.204623;
                double calc_lbs = d_kg * d_lbs;
                uplbs.Text = Convert.ToString(calc_lbs);
            }
            catch (Exception ex)
            {
                upweight.Text = "";
                uplbs.Text = "";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tbl_items where item_code like '%" + txtsearch.Text + "%' or item_name like '%" + txtsearch.Text + "%' or item_desc like '%" + txtsearch.Text + "%' or item_weight_kg like '%" + txtsearch.Text + "%' or item_unit like '%" + txtsearch.Text + "%' or item_price like '%" + txtsearch.Text + "%'";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_item_info.DataSource = bSource;
        }
    }
}
