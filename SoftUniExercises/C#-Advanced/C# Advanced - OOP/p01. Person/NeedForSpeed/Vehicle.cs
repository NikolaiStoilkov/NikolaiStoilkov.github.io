using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private double defaultFuelConsumption;

        public Vehicle()
        {
            this.DefaultFuelConsumption = 1.25;
        }
        public double DefaultFuelConsumption
        {
            get
            {
                return this.defaultFuelConsumption;
            }
            set
            {
                this.defaultFuelConsumption = value;
            }
        }
        public virtual double FuelConsumption { get; set; }

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }

        public virtual void Drive(double kilometers)
        {
            for (int i = 0; i < kilometers; i++)
            {
                fuel -= DefaultFuelConsumption;
            }
        }
    }
}
