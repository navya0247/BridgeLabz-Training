using System;
class AccessModifier
{                                                                         
    internal class ParentInfo                                                // Internal base class
    {
        public string personName = "navya";                                 // public
        private int securityCode = 8800;                                    // private
        protected double monthlyIncome = 45000;                            // protected
        internal string location = "Agra";                                // internal
        protected internal string organization = "BridgeLabz";            // protected internal

        
        public void ShowPrivateInfo()                                // Method to access private member
        {
            Console.WriteLine("Security Code: " + securityCode);     // securityCode not accessible (private)
        }
    }

    class ChildInfo : ParentInfo                                  // Child class
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Person Name: " + personName);
            Console.WriteLine("Monthly Income: " + monthlyIncome);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Organization: " + organization);         
        }
    }
    class ProgramStart                                                         // Main execution class
    {
        public static void Main(String[] args)
        {
            ParentInfo a = new ParentInfo();
            Console.WriteLine("Name: " + a.personName);
           Console.WriteLine("Location: " + a.location);
            Console.WriteLine("Organization: " + a.organization);
            a.ShowPrivateInfo();
            ChildInfo childObj = new ChildInfo();
            childObj.DisplayDetails();
             
        }
    }
}
