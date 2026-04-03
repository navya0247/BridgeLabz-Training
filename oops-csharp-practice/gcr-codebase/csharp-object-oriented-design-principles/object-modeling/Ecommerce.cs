using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class Ecommerce
    {
            // Product class 
            public class Product
            {
                public string productName;
                public double price;

                public Product(string productName, double price)
                {
                    this.productName = productName;
                    this.price = price;
                }

                public void DisplayProduct()
                {
                    Console.WriteLine("Product: " + productName + ", Price: " + price);
                }
            }

            // Order class 
            public class Order
            {
                public int orderId;
                public List<Product> products;

                public Order(int orderId)
                {
                    this.orderId = orderId;
                    products = new List<Product>();
                }

                // Add product to order (aggregation)
                public void AddProduct(Product product)
                {
                    products.Add(product);
                }

                // Show order details
                public void DisplayOrder()
                {
                    Console.WriteLine("\nOrder Id: " + orderId);
                    Console.WriteLine("Products in Order:");

                    for (int i = 0; i < products.Count; i++)
                    {
                        products[i].DisplayProduct();
                    }
                }
            }

            //  Customer class 
            public class Customer
            {
                public string customerName;

                public Customer(string customerName)
                {
                    this.customerName = customerName;
                }

                // Customer places an order (communication)
                public void PlaceOrder(Order order)
                {
                    Console.WriteLine("\nCustomer " + customerName +
                                      " placed Order Id: " + order.orderId);
                    order.DisplayOrder();
                }
            }

            public static void Main(string[] args)
            {
             
                Product p1 = new Product("PC", 50000);
                Product p2 = new Product("Mouse", 400);
                Product p3 = new Product("Keyboard", 2500);

                // Create order
                Order order1 = new Order(101);
                order1.AddProduct(p1);
                order1.AddProduct(p2);
                order1.AddProduct(p3);

                // Create customer
                Customer customer = new Customer("Navya");

                customer.PlaceOrder(order1);
            }
        }
    }

