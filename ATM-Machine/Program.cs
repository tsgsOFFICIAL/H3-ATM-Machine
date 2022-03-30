using ATM_Machine;

Bank SparekassenSjælland = new Bank();

ATM atm = SparekassenSjælland.CreateATM();

Customer Mig = SparekassenSjælland.CreateCustomer("Marcus Jensen");

Mig.CreateAccount("Lommepenge", 100);

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