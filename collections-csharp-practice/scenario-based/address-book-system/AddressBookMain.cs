namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("  WELCOME TO ADDRESS BOOK SYSTEM ---> ");
            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
