using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
           List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
           (string product, double amount, int quantity) Beer = ("Yngling", 9.99, 2);
           (string product, double amount, int quantity) Cigarettes = ("Camel", 6.99, 1);
           (string product, double amount, int quantity) Liquor = ("Jack Daniels", 15.99, 12);
           (string product, double amount, int quantity) Cheese = ("Swiss", 1.99, 20);
           (string product, double amount, int quantity) Snacks = ("Cheetos", 3.99, 25);

           transactions.Add(Beer);
           transactions.Add(Cigarettes);
           transactions.Add(Liquor);
           transactions.Add(Cheese);
           transactions.Add(Snacks);

           foreach ((string product, double amount, int quantity) t in transactions){
               Console.WriteLine($"{t.product} {t.amount} {t.quantity}");
           }

        }
    }
}
