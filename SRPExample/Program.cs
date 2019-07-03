using SRPExample.Classes;

namespace SRPExample {
    class Program {
        static void Main(string[] args)
        {
        }

        static void TestAccountv1()
        {
            //Account can be created
            Accountv1 account = new Accountv1()
            {
                AccountNumber = "1234567890",
                AccountName = "Test Account",
                AccountBalance = 100000.00
            };
            //However I can go and make changes to the properties of the class
            account.AccountNumber = "1234567891";
            //This is a further risk as I can now change the amount of the account
            account.AccountBalance = 0; //Someone isn't going to be happy with that
        }

        static void TestAccountv2()
        {
            //Account can be created using the given constructor
            Accountv2 account = new Accountv2("1234567890", "Test Account", 100000.00);
            //Now I cannot make changes to the properties of the account, however nor can anything else as there is no setter declared
            //account.AccountBalance = 100;
            //However I can still go and get the account's balance at anytime, which is a risk in terms of data security
        }

        static void TestAccountv3()
        {
            Accountv3 account = new Accountv3("1234567890", "Test Account", 100000.00);
            //We now want to check the balance
            account.GetBalance();
            //We can now debit and credit the account and the account will handle it's properties
            account.CreditAccount(1000);
            account.DebitAccount(1000);
        }
    }
}
