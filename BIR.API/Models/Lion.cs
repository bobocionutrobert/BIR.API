using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Models
{
    public class Lion : Animal
    {
        public bool Leader { get; set; }


        public Lion(Guid Id, string Sex, int Age, string Name, int Weight, string HealthCondition, bool Leader) : base(Id, Sex, Age, Name, Weight, HealthCondition)
        {
            this.Leader = Leader;
        }


        public override string ToString()
        {
            return base.ToString() + "," + this.Leader;
        }
    }
}
