using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double coffeeMilliliters_ = 50;
        private const decimal coffeePrice_ = 3.50M;

        public Coffee(string name, double caffeine) : base(name, coffeePrice_, coffeeMilliliters_)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; private set; }

    }
}
