using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double USD = 53.9;
            const double YEN = 0.4194;
            const double PND = 65.9708;
            const double WON = 0.0440;
            const double DIR = 14.6912;
            const double AUD = 38.1786;

            double result = 0;
            double amount = 0;

            Console.WriteLine("[USD] - US Dollar ({0})", USD);
            Console.WriteLine("[YEN] - Japanese Yen ({0})", YEN);
            Console.WriteLine("[PND] - UK Pound ({0})", PND);
            Console.WriteLine("[WON] - Korean Won ({0})", WON);
            Console.WriteLine("[DIR] - UAE Dirham ({0})", DIR);
            Console.WriteLine("[AUD] - Australian Dollar ({0})", AUD);
            Console.WriteLine("Please select currency");
            string selectedCurrency = Console.ReadLine();

            switch(selectedCurrency)
            {
                case "USD":
                    Console.Write("Enter amount in dollars: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * USD;
                    Console.WriteLine("{0} dollars is equal to {1} pesos", amount, result);
                    Console.ReadLine();
                    break;
                case "YEN":
                    Console.Write("Enter amount in yen: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * YEN;
                    Console.WriteLine("{0} yen is equal to {1} pesos", amount, result);
                    Console.ReadLine();
                    break;
                case "PND":
                    Console.Write("Enter amount in UK pound: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * PND;
                    Console.WriteLine("{0} pound is equal to {1} pesos", amount, result);
                    Console.ReadLine();
                    break;
                case "WON":
                    Console.Write("Enter amount in korean won: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * WON;
                    Console.WriteLine("{0} won is equal to {1} pesos", amount, result);
                    Console.ReadLine();
                    break;
                case "DIR":
                    Console.Write("Enter amount in dirham: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * DIR;
                    Console.WriteLine("{0} dirhams is equal to {1} pesos", amount, result);
                    Console.ReadLine();
                    break;
                case "AUD":
                    Console.Write("Enter amount in australian dollars: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * AUD;
                    Console.WriteLine("{0} australian dollars is equal to {1} pesos", amount, result);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid currency!");
                    break;

            }

            Console.ReadLine();
        }
    }
}
