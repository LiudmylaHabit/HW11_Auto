using System;

namespace Converter_with_tests
{
    class ConverterForCurrency
    {
        public decimal ConvertionToDollar(decimal SumToConvert, decimal rate)
        {
            decimal inDollars = SumToConvert * rate;
            return inDollars;
        }

        public decimal DollarConvertion(decimal sumInDollars, decimal rate)
        {
            decimal convertedSum = 0;
            convertedSum = sumInDollars / rate;
            return Math.Round(convertedSum, 4);
        }
    }
}
