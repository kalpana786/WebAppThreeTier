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
    public partial class AllEmployee : System.Web.UI.Page
    {
        BusinessLogicLayer.Employee objBllEmployee = new BusinessLogicLayer.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {
            BusinessObject.Employee objBoempoyee = new BusinessObject.Employee();
            DataSet ds = new DataSet();
            ds=objBllEmployee.allEmplopyee(objBoempoyee);
            GridView1.DataSource = ds;
            GridView1.DataBind();
   
        }
    }
}