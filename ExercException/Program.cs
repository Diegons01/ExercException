using System;
using System.Globalization;
using ExercException.Entities;
using ExercException.Entities.Exceptions;

namespace ExercException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit:");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, limit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance);

            }
            catch (DomainExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
            }            
        }
    }
}
