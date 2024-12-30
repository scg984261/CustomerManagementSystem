using System;
using CDB;

namespace DataModel
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastUpdateDateTime { get; set; }

        public Customer(SelectAllCustomers_Result customerResult)
        {
            this.Id = customerResult.Id;
            this.FirstName = customerResult.FirstName;
            this.LastName = customerResult.LastName;
            this.CreatedDateTime = customerResult.CreatedDateTime;
            this.LastUpdateDateTime = customerResult.LastUpdateDateTime;
        }

        public override string ToString()
        {
            string str = $"Id: {this.Id}\r\n";
            str += $"First name: {this.FirstName}\r\n";
            str += $"Last name: {this.LastName}\r\n";
            str += $"Created date time: {this.CreatedDateTime}\r\n";
            str += $"Last update date time: {this.LastUpdateDateTime}\r\n";
            return str;
        }
    }
}
