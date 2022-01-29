using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Models
{
    public class Deer : Animal
    {
        public bool Breeding;

        public Deer(Guid Id, string Sex, int Age, string Name, int Weight, string HealthCondition, bool Breeding) : base(Id, Sex, Age, Name, Weight, HealthCondition)
        {
            this.Breeding = Breeding;
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.Breeding;
        }
    }
}
