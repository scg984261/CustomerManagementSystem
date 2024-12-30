using System.Linq;
using System.Collections.Generic;

namespace CDB
{
    public class CDBWrapper
    {
        public CDBWrapper()
        {
        }

        public List<SelectAllCustomers_Result> SelectAllCustomers()
        {
            using (CDBContext context = new CDBContext())
            {
                List<SelectAllCustomers_Result> customerList = context.SelectAllCustomers().ToList();
                return customerList;
            }
        }
    }
}
