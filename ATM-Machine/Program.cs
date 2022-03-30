using ATM_Machine;

Bank SparekassenSjælland = new Bank();

ATM atm = SparekassenSjælland.CreateATM();

Customer Mig = SparekassenSjælland.CreateCustomer("Marcus Jensen");
Customer Dig = SparekassenSjælland.CreateCustomer("Kent");

Mig.CreateAccount("Lommepenge", 100);
Mig.CreateAccount("Sparegris", 200);
Mig.CreateAccount("Snolder", 5);

Dig.CreateAccount("Lommepenge", 100);
Dig.CreateAccount("Sparegris", 200);
Dig.CreateAccount("Snolder", 5);

//try
//{
//    atm.Withdraw(Mig.Accounts[0].Card, 100);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

Gui.bank = SparekassenSjælland;

Gui.ChangeTitle("Sparekassen Sjællands turbo service");

Gui.PrintWelcome();

Gui.PrintMenu();

Console.ReadKey(true);