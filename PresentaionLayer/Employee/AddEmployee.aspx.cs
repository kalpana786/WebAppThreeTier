using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObject;
using BusinessLogicLayer;

namespace PresentaionLayer.Employee
{
    public partial class AddEmployee : System.Web.UI.Page
    {

        BusinessLogicLayer.Employee objBllEmployee = new BusinessLogicLayer.Employee();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessObject.Employee objBoempoyee = new BusinessObject.Employee();
            objBoempoyee.Id = Convert.ToInt32(TextBox1.Text);
            objBoempoyee.Name =TextBox2.Text;
            objBoempoyee.Salary =Convert.ToDouble(TextBox3.Text);
            int i = objBllEmployee.addEmplopyee(objBoempoyee);
            if (i == 1)
            {
                Label1.Text="Added sucseffully";
                Response.Write("<script> alert('Employee added) </script>");
            }
            else
                Response.Write("<script> alert('Employee Not added) </script>");

        }

        //void save(int id,string name, double salary){
        //     string str = ConfigurationManager.ConnectionStrings["ConnectEmployee"].ConnectionString;
        //    SqlConnection con = new SqlConnection(str);
        //    try
        //    { 

        //        SqlCommand cmd = new SqlCommand("Procedure_insertEmployee",con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id",id);
        //        cmd.Parameters.AddWithValue("@ename", name);
        //        cmd.Parameters.AddWithValue("@salary", salary);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        Response.Write("<script> alert('Employee added) </script>");
        //    }
        //    catch (Exception exc)
        //    {
        //        throw exc;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
   
        //}
    }
}