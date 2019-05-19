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
    public partial class Stock_In_Information : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Stock_In_Information()
        {
            InitializeComponent();
        }
        public void loadstockin_info()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select * from v_stock_in order by dt_stock_in desc";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            dgv_stockin_list.Rows.Clear();
            while (rdr.Read() == true)
            {
                dgv_stockin_list.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
            }
            con.Close();
        }
        private void Stock_In_Information_Load(object sender, EventArgs e)
        {
            loadstockin_info();
        }

        private void dgv_stockin_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Item_Stock_in isi = new Item_Stock_in();
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = dgv_stockin_list.Rows[indexRow];
            
            isi.txtstockid.Text = row.Cells[0].Value.ToString();
            isi.txtsuppid.Text = row.Cells[1].Value.ToString();
            isi.txtsuppname.Text = row.Cells[2].Value.ToString();
            isi.txtdtstockin.Text = row.Cells[3].Value.ToString();
            isi.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                loadstockin_info();
            }
            else
            {
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                query = "select * from v_stock_in where stock_in_id like '%" + textBox1.Text + "%' or supplier_id like '%" + textBox1.Text + "%' or supplier_name like '%" + textBox1.Text + "%' or dt_stock_in like '%" + textBox1.Text + "%' order by dt_stock_in desc";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                dgv_stockin_list.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgv_stockin_list.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                }
                con.Close();
            }
        }
    }
}
