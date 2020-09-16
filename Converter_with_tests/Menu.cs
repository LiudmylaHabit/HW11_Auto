using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_with_tests
{
    public class Menu
    {
        public bool Game()
        {
            bool answer = false;
            string input = "";
            Console.WriteLine("\n\nWould you like to convert one more time?");
            Console.WriteLine("Yes - 1 \t Cancel - any other key");
            input = Console.ReadLine();
            if (input == "1")
            {
                answer = true;
            }
            return answer;
        }

        public string AskCurrency(List<Currency> currencies, string act)
        {
            int input, count = 1;
            string currency = "";
            do
            {
                Console.WriteLine($"Please, choose currency {act}");
                foreach (var item in currencies)
                {
                    Console.WriteLine($"{count}. {item.Name}");
                    count++;
                }
                count = 1;
            } while (!int.TryParse(Console.ReadLine(), out input)
            || input < 1
            || input > 5);
            switch (input)
            {
                case 1:
                    currency = "USD";
                    break;
                case 2:
                    currency = "EUR";
                    break;
                case 3:
                    currency = "UAH";
                    break;
                case 4:
                    currency = "AUD";
                    break;
                case 5:
                    currency = "CAD";
                    break;
                default:
                    Console.WriteLine("Smth went wrong");
                    break;
            }
            return currency;
        }

        public int AskSum()
        {
            int sum = 0;
            do
            {
                Console.WriteLine("Please, write how much you would like to convert:");
            } while (!int.TryParse(Console.ReadLine(), out sum)
            || sum < 1);
            return sum;
        }

        public void ShowResult(int sum, decimal res, string currencyIn, string currencyOut)
        {
            Console.WriteLine("\nThe result is:");
            Console.WriteLine($"{sum} {currencyIn} = {Math.Round(res, 2)} {currencyOut}");
        }
    }
}
