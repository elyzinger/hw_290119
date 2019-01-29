using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_290119
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;

        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            GetMaxNumOfPassengers();
            GetMaxSpeed();
            return $"Number of Wheels:{_numberOfWheels} Model:{_model} Max Passengers:{GetMaxNumOfPassengers()} Max Speed:{GetMaxSpeed()}";
        }
    }

}
