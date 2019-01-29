using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_290119
{
    class Car: Vehicle
    {
        public int _NumOfDoors;

        public override int GetMaxNumOfPassengers()
        {
            return 4;
        }
        public override int GetMaxSpeed()
        {
            return 240;
        }

        public override string ToString()
        {
            return $"Car: Number of doors:{_NumOfDoors} " + base.ToString();
        }
    }
}
