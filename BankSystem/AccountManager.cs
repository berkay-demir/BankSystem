using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class AccountManager
    {
        public void Remit(Client client1, Client client2, int amount)
        {
            client1.Budget = client1.Budget - amount;
            client2.Budget = client2.Budget + amount;
            Console.WriteLine("Operation Performed\n");
        }

        public void Withdraw(Client client1, int amount)
        {
            client1.Budget = client1.Budget - amount;
            Console.WriteLine("Operation Performed\n");
        }

    }
}
