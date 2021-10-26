using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class Employee
    {
        DataAccessLayer.Employee objDalEmployee = new DataAccessLayer.Employee();
        public int addEmplopyee(BusinessObject.Employee objBoEmployee)
        {
            int i = objDalEmployee.addEmplopyee(objBoEmployee);
            return i;
        }

        public int deleteEmplopyee(BusinessObject.Employee objBoEmployee)
        {
            int i = objDalEmployee.deleteEmplopyee(objBoEmployee);
            return i;
            
        }
        public int updateEmplopyee(BusinessObject.Employee objBoEmployee)
        {
            int i = objDalEmployee.updateEmplopyee(objBoEmployee);
            return i;
            
        }
        public DataSet searchEmplopyee(BusinessObject.Employee objBoEmployee)
        {
             DataSet ds= objDalEmployee.searchEmplopyee(objBoEmployee);
            return ds;
            
        }
        public DataSet allEmplopyee(BusinessObject.Employee objBoEmployee)
        {
            DataSet ds = objDalEmployee.allEmplopyee(objBoEmployee);
            return ds;

        }
    }
}