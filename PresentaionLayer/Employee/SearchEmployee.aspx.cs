using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLogicLayer;
using BusinessObject;

namespace PresentaionLayer.Employee
{
    public partial class SearchEmployee : System.Web.UI.Page
    {
        BusinessLogicLayer.Employee objBllEmployee = new BusinessLogicLayer.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessObject.Employee objBoEmpoyee = new BusinessObject.Employee();
            DataSet ds = new DataSet();

            objBoEmpoyee.Id = Convert.ToInt32(TextBox1.Text);
            ds = objBllEmployee.searchEmplopyee(objBoEmpoyee);
            DetailsView1.DataSource = ds;
            DetailsView1.DataBind();

        }
    }
}