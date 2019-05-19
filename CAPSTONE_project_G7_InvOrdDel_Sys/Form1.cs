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
    public partial class Form1 : Form
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String query;
        MySqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void productInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Information pi = new Item_Information();
            pi.ShowDialog();
        }

        private void supplierInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Information si = new Supplier_Information();
            si.ShowDialog();

        }

        private void productInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Stocks itis = new Item_Stocks();
            itis.ShowDialog();
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Entry se = new Stock_Entry();
            se.ShowDialog();

        }

        private void stockLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_In_Information sii = new Stock_In_Information();
            sii.ShowDialog();
        }

        private void stockEntryLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Entry_Logs sel = new Stock_Entry_Logs();
            sel.ShowDialog();
        }

        private void orderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Entry so = new Order_Entry();
            so.ShowDialog();
        }

        private void savedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saved_Orders so = new Saved_Orders();
            so.ShowDialog();
        }

        private void vehilceInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle_Information vi = new Vehicle_Information();
            vi.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delivery_Management dm = new Delivery_Management();
            dm.ShowDialog();
            //Available_Vacant_Vehicles avv = new Available_Vacant_Vehicles();
            //avv.ShowDialog();
        }

        public void countPendingTrans()
        {
            con = new MySqlConnection(dbconnect.constr);
            con.Open();
            query = "select count(*) from v_saved_for_delivery_orders where delivery_status = 'Pending' ";
            cmd = new MySqlCommand(query, con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                String countPend = rdr.GetString("count(*)");
                //tsmi2.Text = "("+countPend+") Pending Deliveries";
            }
            con.Close();
        }
        public void testConnect()
        {
            try
            {
                con = new MySqlConnection(dbconnect.constr);
                con.Open();
                label1.ForeColor = Color.Lime;
                label1.Text = "Online";

            }
            catch (Exception ex)
            {
                //label1.Text = ex.Message;
                label1.ForeColor = Color.Red;
                label1.Text = "Offline";
            }
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //countPendingTrans();
            testConnect();
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            countPendingTrans();
        }

        private void tsmi2_Click(object sender, EventArgs e)
        {
            Pending pend = new Pending();
            pend.ShowDialog();
        }

        private void employeesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees_information ei = new Employees_information();
            ei.ShowDialog();
        }

        private void deliveriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deliveries del = new Deliveries();
            del.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any Questions,Clarifications,Corrections,Bugs and Add-on Features,Please contact the Developer:\n\nPhone: +639268070114 (TM)\nEmail: zaide77alternative@gmail.com\n\nGOLDEN SEVEN COMMERCIAL");
        }

       

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is not yet Available. Please Contact the Developer.");
            
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet Available. Please Contact the Developer.");
        }

        private void deliveryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet Available. Please Contact the Developer.");
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Reports isr = new Reports();
            isr.ShowDialog();

        }
    }
}
