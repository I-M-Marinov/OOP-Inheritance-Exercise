using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        const double defaultFuelConsumption_ = 1.25;


        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = defaultFuelConsumption_;
        }

        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get; set; }
        public  double Fuel { get; set; }
        public  int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            FuelConsumption = DefaultFuelConsumption;
            Fuel -= FuelConsumption * kilometers;
        }

    }
}
