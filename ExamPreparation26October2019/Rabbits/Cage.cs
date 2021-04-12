using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private readonly List<Rabbit> data;

        public Cage(List<Rabbit> data)
        {
            this.data = data;
        }

        public Cage(string name, int capacity)
            
        {
           this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;
       
        public void Add(Rabbit rabbit)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }
        public bool RemoveRabbits(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(r => r.Name == name);
            if (rabbit != null)
            {
                this.data.Remove(rabbit);
                return true;
            }
            return false;
        }
        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(r => r.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(rabbit => rabbit.Name == name);
            if (rabbit!=null)
            {
                rabbit.Available = false;
            }
            return rabbit;
        }
        public Rabbit[] SellRabbitBySpecies(string species)
        {
            Rabbit[] rabbits = this.data.Where(r => r.Species == species).ToArray();
            foreach (var rabbit in rabbits)
            {
                rabbit.Available = false;
            }
            return rabbits;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits availble at {this.Name}:");
            foreach (var rabbit in this.data.Where(r=> r.Available))
            {
                sb.AppendLine(rabbit.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
