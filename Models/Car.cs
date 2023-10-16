using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK12.Models
{
    internal class Car:IVehicle
    {
        private double MileAge { get; set; }
        private double Fuel { get; set; }
        private double FuelConsumption { get; set; }
        private double TankCapacity { get; set; }

        public Car(double fuel,double fuelconsumption,double tankcapacity)
        {
            MileAge = 0;
            Fuel = fuel=20;
            FuelConsumption = fuelconsumption=10;
            TankCapacity = tankcapacity=40;
        }

        public bool Drive(double kilometr)
        {
            double fuelneed = kilometr * FuelConsumption / 100;
            if(kilometr >=0 && fuelneed<=Fuel)
            {
                return true;
            }
            else
            {
                return false;
            }
  
        }

        public bool Refuel(double amount)
        {
            if(amount<0)
            {
                return false;
            }
            if(Fuel+amount>TankCapacity)
            {
                Fuel = TankCapacity;
            }
            else
            {
                Fuel += amount;
            }
            return true;
        }
    }
}
