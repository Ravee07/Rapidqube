using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedArchitecture
{
    public partial class Form1 : Form
    {
        DataSet ds;
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");

            #region Employee DataTable
            dc = new DataColumn("EmpId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr[0] = 101;
            dr["EmpName"] = "Prasad";
            //dr[2] = 10;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 102;
            dr["EmpName"] = "Vishnu";
            //dr[2] = 20;
            dt.Rows.Add(dr);

            #endregion

            return dt;
            
        }

        DataTable GetDepartmentTable()
        {
            dt = new DataTable("Department");

            #region Department DataTable

            dc = new DataColumn("DeptId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };
            dc = new DataColumn("DataName", typeof(string));
            dt.Columns.Add(dc);

            dr = dt.NewRow();
            dr[0] = 10;
            dr[1] = "Admin";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 20;
            dr[1] = "HR";
            dt.Rows.Add(dr);

            #endregion
            return dt;
        }

        DataSet GenerateDataSet()
        {
            DataTable emp = GetEmployeeTable();
            DataTable dept = GetDepartmentTable();

            ds = new DataSet("MyDS");
            ds.Tables.Add(emp);
            ds.Tables.Add(dept);

            DataColumn col_pk = ds.Tables["Department"].Columns["DeptId"];
            DataColumn col_fk = ds.Tables["Employee"].Columns["DeptId"];
            DataRelation drel = new DataRelation("Emp_Dept_Rel", col_pk, col_fk);

            ds.Relations.Add(drel);

            return ds;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable EmpTable = GetEmployeeTable();
            //dataGridView1.DataSource = EmpTable;

            DataSet MyDS = GenerateDataSet();
            dataGridView1.DataSource = MyDS.Tables[0];        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable emp = GetEmployeeTable();
            dt.WriteXml(@"C:\Users\PrasadAmbokar\source\repos\data.xml");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet MyDS = GenerateDataSet();
            dataGridView2.DataSource = MyDS.Tables[1];
        }
    }
}
