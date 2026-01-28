
    internal class PaymentGateway
    {
        public static void Main(string[] args)
        {
            //create object
            AccountHandler handler = new AccountHandler();

            Console.WriteLine("Enter amount to pay:");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter the role: vipPerson | normalPerson");

            string role = Console.ReadLine();

            if (handler is AccountHandler)
            {
                if (role == "vipPerson")
                {
                    handler.Payment(amount, true);
                }
                else if (role == "normalPerson")
                {
                    handler.Payment(amount, false);
                }
                else
                {
                    Console.WriteLine("Invalid user");
                }

            }

        }

        sealed class AccountHandler
        {
            public void Payment(double amount, bool isVip)
            {
                if (isVip)
                {
                    double discount = amount * 0.20;  //20 percent discount
                    double finalAmount = amount - discount;
                    Console.WriteLine(" amount to pay " + finalAmount);
                }

                else
                {
                    Console.WriteLine("Amount to pay " + amount);
                }
            }
        }
    }

     
