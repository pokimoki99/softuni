using System;
using System.Collections.Generic;
using System.Text;

namespace _17December2019
{
    public class Presents
    {
        public Presents(string name, double weight, string gender)
        {
           this. Name = name;
           this. Weight = weight;
            this.Gender = gender;
        }

        //•	Name:string,Weight:double,	Gender:string
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Presents {Name} ({Weight}) for a {Gender}";
        }

    }
}
