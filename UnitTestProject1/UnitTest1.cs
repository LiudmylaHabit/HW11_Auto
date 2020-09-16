using System;
using NUnit.Framework;
using Converter_with_tests;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        // Parameterized tests
        [TestCase(1, 0.036, 0.036)]
        [TestCase(10, 1, 10)]
        [TestCase(100, 1.18, 118)]
        [TestCase(1000, 0.714, 714)]
        [TestCase(10000, 0.76, 7600)]
        [TestCase(0, 0.036, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 1.18, 0)]
        [TestCase(000, 0.714, 0)]
        [TestCase(0000, 0.76, 0)]
        public void CheckingCorrectnessOfConvertionToDollar(decimal a, decimal b, decimal expectedResult)
        {
            decimal actResult = new ConverterForCurrency().ConvertionToDollar(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }

        [TestCase(100, 1, 100)]
        [TestCase(100, 0.036, 2777.7778)]
        [TestCase(0, 0.036, 0)]
        [TestCase(50, 0, 0)]
        [TestCase(100, 1.18, 84.7458)]
        [TestCase(100, 0.714, 140.056)]
        [TestCase(100, 0.76, 131.5789)]
        [TestCase(100, 1, 100)]
        public void ParamCheckingCorrectnessOfConv(decimal a, decimal b, decimal expectedResult)
        {
            decimal actResult = new ConverterForCurrency().DollarConvertion(a, b);
            Assert.AreEqual(expectedResult, actResult);
        }

        // Separated tests only to show using of nonparametric tests
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
