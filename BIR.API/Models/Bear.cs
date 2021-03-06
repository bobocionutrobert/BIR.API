using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Models
{
    public class Bear : Animal
    {

        public string Type { get; set; }

        public Bear(Guid Id, string Sex, int Age, string Name, int Weight, string HealthCondition, string Type) : base(Id, Sex, Age, Name, Weight, HealthCondition)
        {
            this.Type = Type;
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.Type;
        }
    }
}
