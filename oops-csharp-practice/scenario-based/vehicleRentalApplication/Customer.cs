using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.vehicleRentalApplication
{
    internal class Customer
    {
        int customerId;
        string customerName;

        public Customer(int customerId, string customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }
        public void DisplayCustomer()
        {
            Console.WriteLine("Customer ID : " + customerId);
            Console.WriteLine("Customer Name :" + customerName);
        }
    }
}
