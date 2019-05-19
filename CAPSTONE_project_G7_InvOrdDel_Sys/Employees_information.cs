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
    public partial class Employees_information : Form
    {
        
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;


        
        public Employees_information()
        {
            InitializeComponent();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            dtpid.Text = "";
            txtid.Text = dtpid.Text;

        }



        //------------------------------------------------------------
        public void countHelpers()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_employees where emp_position='Helper'";
            cmd = new MySqlCommand(query,con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                lblcounthelpers.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void countDrivers()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_employees where emp_position='Driver'";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                lblcountdrivers.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void countTotalEmp()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from tbl_employees";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while(rdr.Read()==true){
                lblcounttotal.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        public void loademployees()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select emp_id,emp_name,emp_phone,emp_address,emp_position from tbl_employees";
            cmd = new MySqlCommand(query, con);
            dgv_emp.Rows.Clear();
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                dgv_emp.Rows.Add(rdr[0],rdr[1],rdr[2],rdr[3],rdr[4]);
            }
            con.Close();
            countDrivers();
            countHelpers();
            countTotalEmp();
        }
        //------------------------------------------------------------
        private void Employees_information_Load(object sender, EventArgs e)
        {
            loademployees();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtposition.Text == "" || txtaddress.Text == "")
            {
                MessageBox.Show("Please Fill up All Requirements");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(dbconnect.constr);
                    con.Open();
                    query = "insert into tbl_employees(emp_id,emp_name,emp_phone,emp_address,emp_position,dt_emp_reg,emp_status)values('"+txtid.Text+"','"+txtname.Text+"','"+txtphone.Text+"','"+txtaddress.Text+"','"+txtposition.Text+"',now(),'vacant') ;";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();

                    MessageBox.Show("Successfully Submitted.");

                    txtid.Text = "";
                    txtname.Text = "";
                    txtphone.Text = "";
                    txtaddress.Text = "";
                    txtposition.Text = "";
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                loademployees();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select emp_id,emp_name,emp_phone,emp_address,emp_position from tbl_employees where emp_id like '%" + txtsearch.Text + "%' or emp_name like '%" + txtsearch.Text + "%' or emp_phone like '%" + txtsearch.Text + "%' or emp_address like '%" + txtsearch.Text + "%' or emp_position like '%" + txtsearch.Text + "%' or emp_status like '%" + txtsearch.Text + "%' ";
            cmd = new MySqlCommand(query, con);
            dgv_emp.Rows.Clear();
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                dgv_emp.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
            }
            con.Close();
        }

        
    }
}
