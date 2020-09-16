using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_with_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            bool convert = true;
            do
            {
                Menu menu = new Menu();
                ConverterForCurrency converter = new ConverterForCurrency();
                List<Currency> currencies = new List<Currency>()
                {
                    new Currency("USD", 1),
                    new Currency("EUR", Convert.ToDecimal(1.18)),
                    new Currency("UAH", Convert.ToDecimal(0.036)),
                    new Currency("AUD", Convert.ToDecimal(0.714)),
                    new Currency("CAD", Convert.ToDecimal(0.76))
                };

                string currencyToConvert = menu.AskCurrency(currencies, "that you would like to convert");
                string currencyToConvertIn = menu.AskCurrency(currencies, "to convert in:");
                int sumToConvert = menu.AskSum();
                decimal rateIn = 0, rateOut = 0;
                foreach (var item in currencies)
                {
                    if (item.Name == currencyToConvert)
                    {
                        rateIn = item.ToDollarRate;
                    }
                    if (item.Name == currencyToConvertIn)
                    {
                        rateOut = item.ToDollarRate;
                    }
                }
                decimal tpDollar = converter.ConvertionToDollar(sumToConvert, rateIn);
                decimal result = converter.DollarConvertion(tpDollar, rateOut);
                menu.ShowResult(sumToConvert, result, currencyToConvert, currencyToConvertIn);
                convert = menu.Game();
            } while (convert);
        }
    }
}
