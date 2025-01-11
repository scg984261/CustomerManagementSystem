using System.Linq;
using System.Collections.Generic;

namespace CDB
{
    public class CDBWrapper
    {
        public CDBWrapper()
        {
        }

        /// <summary>
        /// Create an instance of Database context and invoke the <c><b>SelectAllCustomers</b></c> stored procedure.
        /// </summary>
        /// <returns></returns>
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
