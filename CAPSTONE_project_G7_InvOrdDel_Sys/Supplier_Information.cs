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
    public partial class Supplier_Information : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Supplier_Information()
        {
            InitializeComponent();
        }
        public void loadsuppinfo()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from tbl_suppliers";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_supplier_info.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_supplier_info.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);

            }
            con.Close();
        }
        private void Supplier_Information_Load(object sender, EventArgs e)
        {
            loadsuppinfo();
        }

        private void btngen_Click(object sender, EventArgs e)
        {
            gencode.Text = "";
            txtid.Text = gencode.Text;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtdesc.Text == "" || txtaddr.Text == "")
            {
                MessageBox.Show("Please Fill Up All Requirements");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    query = "insert into tbl_suppliers(supplier_id,supplier_name,supplier_desc,supplier_addr)values('"+txtid.Text+"','"+txtname.Text+"','"+txtdesc.Text+"','"+txtaddr.Text+"')";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();
                    MessageBox.Show("Supplier Added!");
                    resetF();
                    loadsuppinfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
        public void resetF()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtdesc.Text = "";
            txtaddr.Text = "";

        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            resetF();
        }

        private void dgv_supplier_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_supplier_info.Rows[indexRow];
            panel_update.Visible = true;
            upid.Text = row.Cells[0].Value.ToString();
            upname.Text = row.Cells[1].Value.ToString();
            updesc.Text = row.Cells[2].Value.ToString();
            upaddr.Text = row.Cells[3].Value.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel_update.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "update tbl_suppliers set supplier_name = '" + upname.Text + "',supplier_desc = '" + updesc.Text + "',supplier_addr = '" + upaddr.Text + "' where supplier_id = '" + upid.Text + "' ";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Supplier Updated!");
            panel_update.Visible = false;
            loadsuppinfo();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from tbl_suppliers where supplier_id like '%" + txtsearch.Text + "%' or supplier_name like '%" + txtsearch.Text + "%' or supplier_desc like '%" + txtsearch.Text + "%' or supplier_addr like '%" + txtsearch.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_supplier_info.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_supplier_info.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);

            }
            con.Close();
        }
    }
}
