using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIR.API.Models
{
    public class Tiger : Animal
    {
        public string TypeOfTiger { get; set; }

        public Tiger(int Id, string Sex, int Age, string Name, int Weight, string HealthCondition, string TypeOfTiger) : base(Id, Sex, Age, Name, Weight, HealthCondition)
        {
            this.TypeOfTiger = TypeOfTiger;
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.TypeOfTiger;
        }
    }
}
