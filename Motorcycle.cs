using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_290119
{
    class Motorcycle: Vehicle
    {
        public int _NumOfHandBreaks;

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }
        public override int GetMaxSpeed()
        {
            return 180;
        }

        public override string ToString()
        {
            return $"Motorcycle: Number of Handbreaks:{_NumOfHandBreaks}" + base.ToString();
        }
    }
}
