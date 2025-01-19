using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        public void UpdateCustomer(int customerId, string companyName, string businessContact, string emailAddress, string contactNumber, bool isActive)
        {
            using (CDBContext context = new CDBContext())
            {
                context.UpdateCustomer(customerId, companyName, businessContact, emailAddress, contactNumber, isActive);
            }
        }
    }
}
