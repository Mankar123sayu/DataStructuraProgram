using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStuctureProgram
{
    public class BankingCash
    {
        LinkedListQueue<string> queue = new LinkedListQueue<string>();
        int amount = 10000;
        public BankingCash()
        {
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Display();
        }
        public void Operation()
        {
            int count = queue.Size();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter an option: \n 1. Withdraw \n 2. Deposit \n 3. Check Balance");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Withdraw();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        CheckBalance();
                        break;
                }
                queue.Dequeue();
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine(amount);
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter amount to withdraw: ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (amount >= withdrawAmount)
                amount -= withdrawAmount;
            else
                Console.WriteLine("Insufficient Balance");
        }
        public void Deposit()
        {
            Console.WriteLine("Enter amount to deposit: ");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            amount += depositAmount;
        }
    }
}
    

