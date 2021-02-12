using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Id = 1;
            customer1.CustomerFirstName = "Levent";
            customer1.CustomerLastName = "Ant";

            Customer customer2 = new Customer();

            customer2.Id = 2;
            customer2.CustomerFirstName = "Cemre Su";
            customer2.CustomerLastName = "Ant";


            CustomerManager customerManager1 = new CustomerManager();
            
            customerManager1.CustomerAdd(customer1);
            customerManager1.CustomerAdd(customer2);
            customerManager1.CustomerDelete(customer1);
            customerManager1.CustomerDelete(customer2);
            customerManager1.CustomerList(customer1);
            customerManager1.CustomerList(customer2);
        }
    }
}
