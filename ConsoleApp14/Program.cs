using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp14.Animal;

namespace ConsoleApp14
{
    internal abstract class Animal
    {
        static void Main(string[] args)
        {
        }

        class Normal: Animal
        {
            public string Name { get; set; }
        }

        public abstract class VehicleUsage
        {
            public int Tyres { get; set; }

            void ChangeTyres(int tyres)
            {
                Console.WriteLine("Change the faulty tyres");
            }

            public abstract void RepairExhaust();
           // {
             //   Console.WriteLine("Repair from manifold");
            //}

            double Driving(decimal petrolQuantity)
            {
                return 50;
            }
        }
    }

    class MechanicUsage : VehicleUsage
    {
        public override void RepairExhaust()
        {
            Console.WriteLine("I will check and fix from the manifold");
        }
    }

}
