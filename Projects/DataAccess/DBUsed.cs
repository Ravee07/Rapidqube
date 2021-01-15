using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using FrstProjMVCStored.Models;

namespace FrstProjMVCStored.DataAccess
{
    public class DBUsed
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-JH7JRHH\\SQLEXPRESS;Database=FrstProjMVCStored;integrated security=true");

        public void Add_record(Models.Index emp)
        {
            SqlCommand com = new SqlCommand("Sp_empAdd2", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Emp_Name", emp.Emp_Name); 
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
        public DataSet Show_record()
        {
            SqlCommand com = new SqlCommand("Sp_index", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;       
        }
    }
}
