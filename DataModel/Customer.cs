using System;
using CDB;

namespace DataModel
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string BusinessContact { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastUpdateDateTime { get; set; }

        public Customer(SelectAllCustomers_Result customerResult)
        {
            this.Id = customerResult.Id;
            this.CompanyName = customerResult.CompanyName;
            this.BusinessContact = customerResult.BusinessContact;
            this.EmailAddress = customerResult.EmailAddress;
            this.ContactNumber = customerResult.ContactNumber;
            this.IsActive = customerResult.IsActive;
            this.CreatedDateTime = customerResult.CreatedDateTime;
            this.LastUpdateDateTime = customerResult.LastUpdateDateTime;
        }

        public override string ToString()
        {
            string str = $"Id: {this.Id}\r\n";
            str += $"Company name: {this.CompanyName}\r\n";
            str += $"Business contact: {this.BusinessContact}\r\n";
            str += $"Email address: {this.EmailAddress}\r\n";
            str += $"Contact number: {this. ContactNumber}\r\n";
            str += $"Active: {this.IsActive}\r\n";
            str += $"Created date time: {this.CreatedDateTime}\r\n";
            str += $"Last update date time: {this.LastUpdateDateTime}\r\n";
            return str;
        }
    }
}
