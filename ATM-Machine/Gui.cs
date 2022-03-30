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
                    Console.Clear();
                    Console.WriteLine("All customers: \n");

                    foreach (Customer customer in bank!.Customers)
                    {
                        Console.WriteLine($"Customer: {customer.Name}");
                        Console.WriteLine("Accounts:");

                        foreach (Account account in customer.Accounts)
                        {
                            foreach (PropertyInfo pi in account.GetType().GetProperties())
                            {
                                if (!pi.Name.Equals("Card"))
                                    Console.WriteLine($"\t{pi.Name}: {pi.GetValue(account)}");
                            }

                            Console.WriteLine("\tCard:");
                            
                            foreach (PropertyInfo pi in account.Card.GetType().GetProperties())
                            {
                                if (!pi.Name.Equals("Account"))
                                    Console.WriteLine($"\t\t{pi.Name}: {pi.GetValue(account.Card)}");
                            }
                            Console.WriteLine();
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
