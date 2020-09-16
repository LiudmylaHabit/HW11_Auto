using System;
using NUnit.Framework;
using Converter_with_tests;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test(Description = "Checking correctness of convertion to dollar amount biggest then zero")]
        public void ConvertionToDollarPositiveNumbers()
        {
            decimal actResult = new ConverterForCurrency().ConvertionToDollar(100, Convert.ToDecimal(0.036));
            Assert.AreEqual(3.6, actResult);
        }

        [Test(Description = "Checking correctness of convertion to dollar zero")]
        public void ConvertionToDollarZero()
        {
            decimal actResult = new ConverterForCurrency().ConvertionToDollar(100, 0);
            Assert.AreEqual(0, actResult);
        }

        [Test]
        public void CheckingCorrectnessOfDollarConvertion()
        {
            decimal actResult = new ConverterForCurrency().DollarConvertion(100, Convert.ToDecimal(0.036));
            Assert.AreEqual(2777.7778, actResult);
        }
    }
}
