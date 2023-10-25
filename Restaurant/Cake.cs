using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double grams_ = 250;
        private const double calories_ = 1000;
        private const decimal price_ = 5m;

        public Cake(string name) : base(name, price_, grams_, calories_)
        {
        }

    }
}
