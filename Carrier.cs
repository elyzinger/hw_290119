using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_290119
{
    class Carrier
    {
        public Vehicle[] _vehicles;
        string result;
        public override string ToString()
        {
            
            for (int i = 0; i < _vehicles.Length; i++)
            {
                 result =result+ _vehicles[i].ToString() + "\n";
            }

            return result;
        }
    }



}
