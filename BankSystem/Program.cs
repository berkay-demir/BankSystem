using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            Client client2 = new Client();
            start:
            Console.WriteLine("Your ID");
            client1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID of other client");
            client2.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amount to be Sent: ");
            int amount1 = Convert.ToInt32(Console.ReadLine());
            if (client1.Id == 1000 && client2.Id == 1001)
            {
                client1.Name = "Steve Jackson";
                client2.Name = "Emma West";
            }
            else
            {
                Console.WriteLine("There is no client for this ID");
                goto start;
            }
           
            client1.Budget = 10250;
            client2.Budget = 30020;

            AccountManager accountManager = new AccountManager();
            accountManager.Remit(client1, client2, amount1);
            Console.WriteLine(client1.Name+ "'s Budget is " + client1.Budget);
            Console.WriteLine(client2.Name+"'s Budget is " + client2.Budget);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Amount to be Withdraw from "+ client2.Name);
            int amount2 = Convert.ToInt32(Console.ReadLine());
            accountManager.Withdraw(client2, amount2);
            Console.WriteLine(client2.Name + "'s Budget is " + client2.Budget);
            
            
        }
    }
}
