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

        public string LicensePlate { get; private set; } //TODO: Implementare il set per la validazione della targa
        public int OdometerKm { 
            get
            { return _odometerKm; }
            private set
            { if (value < 0) throw new ArgumentException($"value not allowed {nameof(OdometerKm)}: {OdometerKm}");

                _odometerKm = value;
            } 
        }
        public double DailyRate { get; private set; }
        public double FuelLevelPercentage { get; private set; }


        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate; // Calls private set
        }

        public Vehicle(string licensePlate, int odometerKm, double dailyRate, double fuelLevelPercentage)
        {
            LicensePlate = licensePlate;
            OdometerKm = odometerKm;
            DailyRate = dailyRate;
            FuelLevelPercentage = fuelLevelPercentage;
        }

        public void RegisterData(int consumedKm, double consumedFuel)
        {
            if (consumedKm <= 0)
                throw new ArgumentException($"value not allowed {nameof(consumedKm)}: {consumedKm}");
            if (consumedFuel < 0)
                throw new ArgumentException($"value not allowed {nameof(consumedFuel)}: {consumedFuel}");

            OdometerKm += consumedKm;
            FuelLevelPercentage -= consumedFuel;
        }
    }
}
