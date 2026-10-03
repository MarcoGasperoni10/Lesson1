using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace BlaisePascal.Lesson1.Domain
{
    public class Vehicle
    {

        private int _odometerKm;
        private double _dailyRate;
        private double _fuelPercentage;

        public string LicensePlate { get; private set; }
        public int Km { 
            get
            { return _odometerKm; }
            private set
            { if (value < 0) throw new ArgumentException("illegal value");

                _odometerKm = value;
            } 
        }
        public double DailyRate { get; private set; }
        public double FuelPercentage { get; private set; }


        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate; // Calls private set
        }

        public Vehicle(string licensePlate, int km, double dailyRate, double fuelPercentage)
        {
            LicensePlate = licensePlate;
        }
    }
}
