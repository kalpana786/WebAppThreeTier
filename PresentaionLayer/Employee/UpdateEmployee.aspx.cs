using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using BusinessLogicLayer;
using System.Data;


namespace PresentaionLayer.Employee
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        BusinessLogicLayer.Employee objBllEmployee = new BusinessLogicLayer.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BusinessObject.Employee objBoEmpoyee = new BusinessObject.Employee();
            DataSet ds = new DataSet();
            objBoEmpoyee.Id = Convert.ToInt32(TextBox1.Text);
            ds = objBllEmployee.searchEmplopyee(objBoEmpoyee);
            TextBox2.Text = ds.Tables["Employee"].Rows[0].Field<string>("Ename");
            TextBox3.Text  = ds.Tables["Employee"].Rows[0].Field<decimal>("Salary").ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessObject.Employee objBoempoyee = new BusinessObject.Employee();
            objBoempoyee.Id = Convert.ToInt32(TextBox1.Text);
            objBoempoyee.Name = TextBox2.Text;
            objBoempoyee.Salary = Convert.ToDouble(TextBox3.Text);
            int i = objBllEmployee.updateEmplopyee(objBoempoyee);
            if (i == 1)
            {
                Label1.Text = "update sucseffully";
                Response.Write("<script> alert('Employee added) </script>");
            }
            else
                Response.Write("<script> alert('Employee Not added) </script>");
        }
    }
}