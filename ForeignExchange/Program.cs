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
            CurrencyExchange currencyExchange = new CurrencyExchange();
            
            string answer = string.Empty;

            do
            {
                for (int i = 0; i < currencyExchange.GetCurrencies().Length; i++)
                {
                    Console.WriteLine("[{0}] - {1} ({2})", currencyExchange.GetCurrencyCode()[i], currencyExchange.GetCurrencyDescription()[i], currencyExchange.GetCurrencies()[i]);
                }

                Console.WriteLine("Please select currency");
                string selectedCurrency = Console.ReadLine();

                currencyExchange.ConvertToSelectedCurrency(selectedCurrency);

                Console.Write("Would you like transact again?");
                answer = Console.ReadLine();
            }
            while (answer == "Yes");

            Console.ReadLine();
        }
    }
}
