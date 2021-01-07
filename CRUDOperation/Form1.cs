using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDope
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"server=DESKTOP-JH7JRHH\SQLEXPRESS;initial catalog=Prasad;integrated security=SSPI");

        }

        void Reset()
        {
            textBox2.Text = textBox1.Text = textBox3.Text = "";
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            String command = "select max(DeptNo) + 10 from DeptDetails";
            cmd = new SqlCommand(command, con);
            con.Open();
            string id = cmd.ExecuteScalar().ToString();
            con.Close();
            textBox1.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string loc = textBox3.Text;

            string command = string.Format("insert into DeptDetails values({0},'{1}',{2})", id, name, loc);
            cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Submitted");
            con.Close();
            Reset();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string command = "select * from DeptDetails where DeptNo = " + id;
            cmd = new SqlCommand(command, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr["DeptLocNo"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot find record");
                Reset();
            }
            dr.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string loc = textBox3.Text;

            string command = string.Format("Update DeptDetails set DeptName ='{0}',DeptLocNo = {1} where DeptNo = {2}", name, loc, id);
            cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated..");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string command = "Delete from DeptDetails where DeptNo = " + id;
            cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted..");
        }
    }
}
