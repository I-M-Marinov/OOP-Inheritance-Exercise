using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{ 
    public class Car : Vehicle
    {
        const double defaultFuelConsumption_ = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = defaultFuelConsumption_;
        }
    }
}
