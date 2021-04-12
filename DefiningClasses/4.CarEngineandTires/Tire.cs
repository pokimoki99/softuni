using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
        //•	Year: int Pressure: double

    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year  { get; set; }
        public double Pressure { get; set; }
    }
}
