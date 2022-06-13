using System;

namespace CSharpPractice
{
    public class ATM_Transaction
    {
        public static void Main()
        {
            int balance = 5000;
            string withdraw,deposit; 
            
            while (true)
            {
                Console.WriteLine("Automated Teller Machine");
                Console.WriteLine("Choose 1 for Withdraw");
                Console.WriteLine("Choose 2 for Deposit");
                Console.WriteLine("Choose 3 for Check Balance");
                Console.WriteLine("Choose 4 for EXIT");
                Console.WriteLine("Choose the operation you want to perform:");
                string key = Console.ReadLine();
               int n = Convert.ToInt32(key);
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter money to be withdrawn:");
                        withdraw = Console.ReadLine();
                        int w=Convert.ToInt32(withdraw);
                        if (balance >= w)
                        {
                            balance = balance - w;
                            Console.WriteLine("Please collect your money");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Enter money to be deposited:");
                        deposit = Console.ReadLine();
                        int d=Convert.ToInt32(deposit);
                        balance = balance + d;
                        Console.WriteLine("Your Money has been successfully depsited");
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Balance : " + balance);
                        Console.WriteLine("");
                        break;

                   
                }
            }
        }
    }

}
