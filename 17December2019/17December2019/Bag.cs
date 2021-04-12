using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17December2019
{
    public class Bag
    {
        private List<Presents> data;
        public Bag(int capacity, string color)
        {
            Capacity = capacity;
            Color = color;
            data = new List<Presents>();
        }
        public int Capacity { get; set; }

        public string Color { get; set; }
        public int Count => data.Count;

        public void Add(Presents present)
        {
            if (Capacity > Count)
            {
                data.Add(present);
            }
        }
        public bool Remove (string name)
        {
            Presents present = data.FirstOrDefault(x => x.Name == name);
            return data.Remove(present);
        }
        public Presents GetHeaviestPresents()
        {
            Presents heaviestPresents = data.OrderByDescending(x => x.Weight).FirstOrDefault();
            return heaviestPresents;
        }
        public Presents GetPresent (string name)
        {
            Presents currentPresent = data.FirstOrDefault(x => x.Name == name);
            return currentPresent;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
            foreach (var present in data)
            {
                sb.AppendLine(present.ToString());
            }
            return sb.ToString().TrimEnd();
        }    
    }        
}
