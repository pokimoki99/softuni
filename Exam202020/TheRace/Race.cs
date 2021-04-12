using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }


        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Racer racer)
        {
            if (this.Capacity > data.Count)
            {
                this.data.Add(racer);
            }
        }
        public bool Remove(string name)
            => this.data
            .Remove(this.data.Where(x => x.Name == name)
            .FirstOrDefault());
        
        public Racer GetOldestRacer()
        {
            var oldest = this.data.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldest;
        }


        public Racer GetRacer(string name)
        {
            var getName = this.data.FirstOrDefault(x => x.Name == name);

            return getName;
        }
        //	Method GetFastestRacer() – returns the Racer whose car has the highest speed.
        public Racer GetFastestRacer()
        {
            Racer fastCar = data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
            return fastCar;

        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Racers participating at {this.Name}:");

            foreach (var player in data)
            {
                result.AppendLine(player.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
        
