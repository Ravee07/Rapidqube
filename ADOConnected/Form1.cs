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
using System.Configuration;

namespace ConnectedArchitecture
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"server=DESKTOP-JH7JRHH\SQLEXPRESS;initial catalog=Prasad;integrated security=SSPI");
            //con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].connectionString);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string command = " insert into Student(Fname,Lname) values ('Pallavi','Dhaigude');";
                cmd = new SqlCommand(command, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submitted");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
