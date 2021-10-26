using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObject;


namespace DataAccessLayer
{
    public class Employee
    {
        public int addEmplopyee(BusinessObject.Employee objBoEmployee)
        {
            
                string str = ConfigurationManager.ConnectionStrings["ConnectEmployee"].ConnectionString;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Procedure_insertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", objBoEmployee.Id);
                cmd.Parameters.AddWithValue("@ename", objBoEmployee.Name);
                cmd.Parameters.AddWithValue("@salary", objBoEmployee.Salary);
                con.Open();
                int i=cmd.ExecuteNonQuery();
            // Response.Write("<script> alert('Employee added) </script>");
            con.Close();
            return i;
                
       
        }

        public int deleteEmplopyee(BusinessObject.Employee objBoEmployee)
        {

            string str = ConfigurationManager.ConnectionStrings["ConnectEmployee"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Procedure_deleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objBoEmployee.Id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            // Response.Write("<script> alert('Employee added) </script>");
            con.Close();
            return i;

        }
        public int updateEmplopyee(BusinessObject.Employee objBoEmployee)
        {

            string str = ConfigurationManager.ConnectionStrings["ConnectEmployee"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Procedure_updateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objBoEmployee.Id);
            cmd.Parameters.AddWithValue("@ename", objBoEmployee.Name);
            cmd.Parameters.AddWithValue("@salary", objBoEmployee.Salary);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            // Response.Write("<script> alert('Employee added) </script>");
            con.Close();
            return i;

        }
        public DataSet searchEmplopyee(BusinessObject.Employee objBoEmployee)
        {
            string str = ConfigurationManager.ConnectionStrings["ConnectEmployee"].ConnectionString;
            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand("Procedure_searchEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objBoEmployee.Id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.SelectCommand.Parameters.AddWithValue("@Eno", objBoEmployee.Id);
            DataSet ds=new DataSet();
            sda.Fill(ds,"Employee");
            return ds;

        }
        public DataSet allEmplopyee(BusinessObject.Employee objBoEmployee)
        {

            string str = ConfigurationManager.ConnectionStrings["ConnectEmployee"].ConnectionString;
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter sda = new SqlDataAdapter("Procedure_AllEmployee", con);
          
            DataSet ds = new DataSet();
            sda.Fill(ds, "Employee");
            return ds;

        }
    }
}