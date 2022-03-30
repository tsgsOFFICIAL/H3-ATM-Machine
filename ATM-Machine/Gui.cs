using System.Reflection;

namespace ATM_Machine
{
    public static class Gui
    {
        internal static Bank? bank;
        public static void ChangeTitle(string title)
        {
            Console.Title = title;
        }

        internal static void PrintWelcome()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the ATM!\n");

            Console.WriteLine("We are trusted by:");

            Console.WriteLine($"\t{bank?.Atms.Count} Atm{(bank?.Atms.Count > 1 || bank?.Atms.Count == 0 ? "s" : "")}");
            Console.WriteLine($"\t{bank?.Customers.Count} Customer{(bank?.Customers.Count > 1 || bank?.Customers.Count == 0 ? "s" : "")}\n");
        }

        internal static void PrintMenu()
        {
            Console.WriteLine("Press '1' to show customers");
            Console.WriteLine("Press 'q' to quit");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    foreach (Customer customer in bank!.Customers)
                    {
                        Console.WriteLine(customer.Name);
                        Console.WriteLine("Accounts:");

                        foreach (Account account in customer.Accounts)
                        {
                            Console.WriteLine($"\t{account.Name}");
                            Console.WriteLine($"\t{account.Balance}");

                            foreach (PropertyInfo propertyInfo in account.Card.GetType().GetProperties())
                            {
                                if (!propertyInfo.Name.Equals("Account"))
                                    Console.WriteLine($"\t\t{propertyInfo.Name} - {propertyInfo.GetValue(account.Card)}");
                            }
                        }
                    }
                    break;
                case 'q':
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    PrintMenu();
                    break;
            }
        }
    }
}
