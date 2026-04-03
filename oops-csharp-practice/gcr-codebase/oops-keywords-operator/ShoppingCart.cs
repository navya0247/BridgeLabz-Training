using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{
    internal class ShoppingCart
    {
            // static discount shared by all products
            public static double discountPercent = 0;

            // readonly product id 
            public readonly int productId;

            // instance variables
            public string productName;
            public double price;
            public int quantity;

            // constructor using this keyword
            public ShoppingCart(int productId, string productName, double price, int quantity)
            {
                this.productId = productId;
                this.productName = productName;
                this.price = price;
                this.quantity = quantity;
            }

            // static method to update discount
            public static void UpdateDiscount(double newDiscount)
            {
                discountPercent = newDiscount;
            }

            // method to show product details
            public void ShowProduct()
            {
                double total = price * quantity;
                double discountAmount = total * discountPercent / 100;
                double finalAmount = total - discountAmount;

                Console.WriteLine("Product ID     : " + productId);
                Console.WriteLine("Product Name   : " + productName);
                Console.WriteLine("Price          : " + price);
                Console.WriteLine("Quantity       : " + quantity);
                Console.WriteLine("Discount    : " + discountPercent);
                Console.WriteLine("Final Amount   : " + finalAmount);
            }
        }

        class Program
        {
           public static void Main(string[] args)
            {
                // ask discount from user
                Console.WriteLine("Enter discount percentage:");
                double disc = double.Parse(Console.ReadLine());
            ShoppingCart.UpdateDiscount(disc);

                Console.WriteLine();

                // take product details
                Console.WriteLine("Enter Product ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Price:");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Quantity:");
                int qty = int.Parse(Console.ReadLine());

            // create product object
            ShoppingCart p1 = new ShoppingCart(id, name, price, qty);

                Console.WriteLine();

                // check object using is operator
                if (p1 is ShoppingCart)
                {
                    Console.WriteLine("Valid Product Object\n");
                    p1.ShowProduct();
                }
                else
                {
                    Console.WriteLine("Invalid Product");
                }

                Console.ReadLine();
            }
        }
    }


