using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignExchange
{
    public class CurrencyExchange
    {
        double[] currencies = new double[] { 53.9, 0.4194, 65.9708, 0.0440, 14.6912, 38.1786 };
        string[] currencyCode = new string[] { "USD", "YEN", "PND", "WON", "DIR", "AUD" };
        string[] currencyDescription = new string[] { "US Dollar", "Japanese Yen", "UK Pound", "Korean Won", "UAE Dirham", "Australian Dollar" };

        public void ConvertToSelectedCurrency(string currency)
        {
            double result = 0;
            double amount = 0;

            switch (currency.ToUpper())
            {
                case "USD":
                    Console.Write("Enter amount in dollars: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * currencies[0];
                    DisplayMessage(amount, result, currency);
                    Console.ReadLine();
                    break;
                case "YEN":
                    Console.Write("Enter amount in yen: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * currencies[1];
                    DisplayMessage(amount, result, currency);
                    Console.ReadLine();
                    break;
                case "PND":
                    Console.Write("Enter amount in UK pound: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * currencies[2];
                    DisplayMessage(amount, result, currency);
                    Console.ReadLine();
                    break;
                case "WON":
                    Console.Write("Enter amount in korean won: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * currencies[3];
                    DisplayMessage(amount, result, currency);
                    Console.ReadLine();
                    break;
                case "DIR":
                    Console.Write("Enter amount in dirham: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * currencies[4];
                    DisplayMessage(amount, result, currency);
                    Console.ReadLine();
                    break;
                case "AUD":
                    Console.Write("Enter amount in australian dollars: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    result = amount * currencies[5];
                    DisplayMessage(amount, result, currency);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid currency!");
                    break;

            }
        }

        private void DisplayMessage(double amount, double result, string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    Console.WriteLine("{0} dollars is equal to {1} pesos", amount, result);
                    break;
                case "YEN":
                    Console.WriteLine("{0} yen is equal to {1} pesos", amount, result);
                    break;
                case "PND":
                    Console.WriteLine("{0} pound is equal to {1} pesos", amount, result);
                    break;
                case "WON":
                    Console.WriteLine("{0} won is equal to {1} pesos", amount, result);
                    break;
                case "DIR":
                    Console.WriteLine("{0} dirhams is equal to {1} pesos", amount, result);
                    break;
                case "AUD":
                    Console.WriteLine("{0} australian dollars is equal to {1} pesos", amount, result);
                    break;
            }
        }

        public double[] GetCurrencies()
        {
            return currencies;
        }

        public string[] GetCurrencyCode()
        {
            return currencyCode;
        }

        public string[] GetCurrencyDescription()
        {
            return currencyDescription;
        }
    }
}
