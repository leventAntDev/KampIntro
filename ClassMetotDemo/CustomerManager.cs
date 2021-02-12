using System;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Id + "Customer Number Added Successfully.");
            Console.WriteLine("Added Customer Name and Surname :" + customer.CustomerFirstName + " " + customer.CustomerLastName);
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Id + "Customer No Successfully Deleted.");
            Console.WriteLine("Deleted Customer Name and Surname: " + customer.CustomerFirstName + " " + customer.CustomerLastName);
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Id         :" + customer.Id);
            Console.WriteLine("First Name :" + customer.CustomerFirstName );
            Console.WriteLine("Last Name  :" + customer.CustomerLastName);
        }

    }
}
