using System.Collections.Generic;
using CDB;
using DataModel;

namespace CustomerManagementSystem.Data
{
    public class DataProvider
    {
        private static CDBWrapper databaseWrapper = new CDBWrapper();

        public List<Customer> GetAllCustomers()
        {
            List<SelectAllCustomers_Result> databaseResult = databaseWrapper.SelectAllCustomers();

            List<Customer> customerList = new List<Customer>();

            foreach (SelectAllCustomers_Result result in databaseResult)
            {
                Customer customer = new Customer(result);
                customerList.Add(customer);
            }

            return customerList;
        }
    }
}
