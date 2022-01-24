using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Models
{
    public class Animal
    {

        public int Id { get; set; }

        public string Sex { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public string HealthCondition { get; set; }

        public Animal (int Id, string Sex, int Age, string Name, int Weight, string HealthCondition)
        {
            this.Id = Id;
            this.Sex = Sex;
            this.Age = Age;
            this.Name = Name;
            this.Weight = Weight;
            this.HealthCondition = HealthCondition;
        }

        public Animal()
        {

        }

        public override string ToString()
        {
            return this.Id + "," + this.Sex + "," + this.Age + "," + this.Name + "," + this.Weight + "," + this.HealthCondition;
        }
    }
}
