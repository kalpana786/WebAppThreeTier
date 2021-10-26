using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using BusinessLogicLayer;

namespace PresentaionLayer.Employee
{
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        BusinessLogicLayer.Employee objBllEmployee = new BusinessLogicLayer.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessObject.Employee objBoempoyee = new BusinessObject.Employee();
            objBoempoyee.Id = Convert.ToInt32(TextBox1.Text);
            int i=objBllEmployee.deleteEmplopyee(objBoempoyee);
            if (i == 1)
            {
                Label1.Text = "deleted sucseffully";
               
            }
            else
                Response.Write("<script> alert('Employee Not added) </script>");
        }
    }
}