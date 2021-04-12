using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(List<Car> cars, int capacity)
        {
            this.cars = cars;
            this.capacity = capacity;
        }
        public int Count => this.cars.Count;
        public string AddCar(Car car)
        {
            bool exists = cars.Any(x => x.RegistrationNumber == car.RegistrationNumber);
            if (exists)
            {
                return "Car with that registration number, already exists!";
            }
            if (capacity == cars.Count)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string RegistrationNumber)
        {
            Car car = cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);
            if (car == null)
            {
                return $"Car with that registration number, doesn't exist!";
            }
            cars.Remove(car);
            return $"Successfully removed {RegistrationNumber}";
        }

        public Car GetCar(string RegistrationNumber)
        => cars.FirstOrDefault(x => x.RegistrationNumber == RegistrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var regNumber in RegistrationNumbers)
            {
                var car = cars.FirstOrDefault(x => x.RegistrationNumber == regNumber);
                    cars.Remove(car);
            }
        }
    }
 }
