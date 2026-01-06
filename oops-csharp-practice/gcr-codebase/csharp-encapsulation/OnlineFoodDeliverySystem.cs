using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
      // interface for discount related work
        interface IDiscountable
        {
            double ApplyDiscount();
            string GetDiscountDetails();
        }

        // abstract base class
        abstract class FoodItem
        {
            // encapsulation using private fields
            private string itemName;
            private double price;
            private int quantity;

            public string ItemName
            {
                get { return itemName; }
                set { itemName = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

            // abstract method
            public abstract double CalculateTotalPrice();

            // concrete method
            public void GetItemDetails()
            {
                Console.WriteLine("Item Name  : " + ItemName);
                Console.WriteLine("Price     : " + Price);
                Console.WriteLine("Quantity  : " + Quantity);
                Console.WriteLine("Total Pay : " + CalculateTotalPrice());
            }
        }

        // veg item class
        class VegItem : FoodItem, IDiscountable
        {
            public override double CalculateTotalPrice()
            {
                return Price * Quantity;
            }

            public double ApplyDiscount()
            {
                return CalculateTotalPrice() * 0.10; // 10% discount
            }

            public string GetDiscountDetails()
            {
                return "10% discount on veg items";
            }
        }

        // non-veg item class
        class NonVegItem : FoodItem, IDiscountable
        {
            public override double CalculateTotalPrice()
            {
                double extraCharge = 50; // extra charge per item
                return (Price * Quantity) + (extraCharge * Quantity);
            }

            public double ApplyDiscount()
            {
                return CalculateTotalPrice() * 0.05; // 5% discount
            }

            public string GetDiscountDetails()
            {
                return "5% discount on non-veg items";
            }
        }

        // main class
        internal class OnlineFoodDeliverySystem
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter number of food items: ");
                int count = int.Parse(Console.ReadLine());

                // array of FoodItem reference for polymorphism
                FoodItem[] items = new FoodItem[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter food type (1-Veg, 2-NonVeg): ");
                    int choice = int.Parse(Console.ReadLine());

                    FoodItem item;

                    if (choice == 1)
                        item = new VegItem();
                    else
                        item = new NonVegItem();

                    Console.Write("Enter item name: ");
                    item.ItemName = Console.ReadLine();

                    Console.Write("Enter price: ");
                    item.Price = double.Parse(Console.ReadLine());

                    Console.Write("Enter quantity: ");
                    item.Quantity = int.Parse(Console.ReadLine());

                    items[i] = item;
                }

                Console.WriteLine("\nFood order details");

                for (int i = 0; i < items.Length; i++)
                {
                    items[i].GetItemDetails();

                    if (items[i] is IDiscountable discount)
                    {
                        Console.WriteLine("Discount    : " + discount.ApplyDiscount());
                        Console.WriteLine(discount.GetDiscountDetails());
                    }

                    Console.WriteLine();
                }
            }
        }
    }


