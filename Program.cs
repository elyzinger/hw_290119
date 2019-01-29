using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_290119
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier myVehicle = new Carrier
            {
                _vehicles = new Vehicle[]
                {
                     new Car { _numberOfWheels = 4, _model = "bmw", _NumOfDoors = 4},
                     new Car { _numberOfWheels = 4, _model = "volvo", _NumOfDoors = 5 },
                     new Motorcycle { _numberOfWheels = 2, _model = "honda", _NumOfHandBreaks = 2 },
                     new Motorcycle { _numberOfWheels = 2, _model = "yamha", _NumOfHandBreaks = 2 }
                }


            };

            Vehicles(myVehicle._vehicles);
            Console.WriteLine();
            PrintVehicle(myVehicle._vehicles);
            Console.WriteLine();
            Console.WriteLine(myVehicle);

            Console.ReadLine();
        }
        static void PrintVehicle(Vehicle[] V)
        {
            Console.WriteLine(V[0]._model);

        }
        static void Vehicles(Vehicle[] V)
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.WriteLine(V[i]);
            }

        }

    }
}
