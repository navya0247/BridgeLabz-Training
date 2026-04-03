using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class ProductInventory
    {
       
            public string productName;   // instance variable
            public double price;         // instance variable

            public static int totalProducts = 0;   // class variable

            public ProductInventory(string name, double cost)
            {
                productName = name;
                price = cost;
                totalProducts++; // count objects created
            }

            // instance method
            public void DisplayProductDetails()
            {
                Console.WriteLine("Product Name: " + productName);
                Console.WriteLine("Price: " + price);
            }

            // class method
            public static void DisplayTotalProducts()
            {
                Console.WriteLine("Total Products: " + totalProducts);
            }

            public static void Main(string[] args)
            {
            ProductInventory product1 = new ProductInventory("Laptop", 45000);
            ProductInventory product2 = new ProductInventory("Mouse", 500);

                product1.DisplayProductDetails();     
                product2.DisplayProductDetails();    
            ProductInventory.DisplayTotalProducts();
            }
        }
    }



