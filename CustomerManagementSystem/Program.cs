﻿using System;
using System.Collections.Generic;
// using Presentation;
using CDB;
using UserInterface;

namespace CustomerManagementSystem
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MainWindow window = new MainWindow();
            window.Show();

            CDBWrapper cdb = new CDBWrapper();
            Console.WriteLine(GetMessage());
            List<SelectAllCustomers_Result> customers = cdb.SelectAllCustomers();
            List<DataModel.Customer> customerList = ConvertCustomers(customers);

            foreach (DataModel.Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }
        }

        public static string GetMessage()
        {
            return "Hello, from CMS!";
        } 

        public static List<DataModel.Customer> ConvertCustomers(List<SelectAllCustomers_Result> resultSet)
        {
            List<DataModel.Customer> customerList = new List<DataModel.Customer>();

            foreach (SelectAllCustomers_Result result in resultSet)
            {
                DataModel.Customer customer = new DataModel.Customer(result);
                customerList.Add(customer);
            }

            return customerList;
        }
    }
}
