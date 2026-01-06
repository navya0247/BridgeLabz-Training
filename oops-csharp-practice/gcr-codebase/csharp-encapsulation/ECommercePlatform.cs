using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
        // INTERFACE 
        interface ITaxable
        {
            double CalculateTax();
            string GetTaxDetails();
        }

        //  ABSTRACT CLASS 
        abstract class Product
        {
            // Encapsulation
            private int productId;
            private string name;
            private double price;

            // Setter / Getter 
            public int ProductId
            {
                get { return productId; }
                set { productId = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            // Abstract method
            public abstract double CalculateDiscount();

            // Polymorphic method
            public double GetFinalPrice()
            {
                double tax = 0;

                if (this is ITaxable taxable)
                {
                    tax = taxable.CalculateTax();
                }

                return Price + tax - CalculateDiscount();
            }

            public void DisplayProduct()
            {
                Console.WriteLine("Product ID   : " + ProductId);
                Console.WriteLine("Name         : " + Name);
                Console.WriteLine("Base Price  : " + Price);
                Console.WriteLine("Final Price : " + GetFinalPrice());
            }
        }

        // ELECTRONICS 
        class Electronics : Product, ITaxable
        {
            public override double CalculateDiscount()
            {
                return Price * 0.10; // 10% discount
            }

            public double CalculateTax()
            {
                return Price * 0.18; // 18% tax
            }

            public string GetTaxDetails()
            {
                return "18% GST on Electronics";
            }
        }

        // CLOTHING 
        class Clothing : Product, ITaxable
        {
            public override double CalculateDiscount()
            {
                return Price * 0.20; // 20% discount
            }

            public double CalculateTax()
            {
                return Price * 0.05; // 5% tax
            }

            public string GetTaxDetails()
            {
                return "5% GST on Clothing";
            }
        }

        // GROCERIES 
        class Groceries : Product
        {
            public override double CalculateDiscount()
            {
                return Price * 0.05; // 5% discount
            }
           
        }

        //  MAIN CLASS 
        internal class ECommercePlatform
        {
           public static void Main(string[] args)
            {
                Console.Write("Enter number of products: ");
                int count = int.Parse(Console.ReadLine());

                // Array of Product reference 
                Product[] products = new Product[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter product type (1-Electronics, 2-Clothing, 3-Groceries): ");
                    int type = int.Parse(Console.ReadLine());

                    Product p;

                    if (type == 1)
                    {
                        p = new Electronics();
                    }
                    else if (type == 2)
                    {
                        p = new Clothing();
                    }
                    else
                    {
                        p = new Groceries();
                    }

                    Console.Write("Enter Product ID: ");
                    p.ProductId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Product Name: ");
                    p.Name = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    p.Price = double.Parse(Console.ReadLine());

                    products[i] = p;
                }

                // POLYMORPHISM 
                Console.WriteLine("\n PRODUCT DETAILS");

                for (int i = 0; i < products.Length; i++)
                {
                    products[i].DisplayProduct();

                    if (products[i] is ITaxable tax)
                    {
                        Console.WriteLine("Tax Info    : " + tax.GetTaxDetails());
                    }
                    else
                    {
                        Console.WriteLine("Tax Info    : No tax applicable");
                    }

                  
                }
            }
        }
    }

