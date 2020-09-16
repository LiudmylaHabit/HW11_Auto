using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_with_tests
{
    class Currency
    {
        public string Name;
        public decimal ToDollarRate;

        public Currency(string Name, decimal ToDollarRate)
        {
            this.Name = Name;
            this.ToDollarRate = ToDollarRate;
        }
    }
}
