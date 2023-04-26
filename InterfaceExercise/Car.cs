using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 5.2;
        public string Model { get; set; } = "Aston Martin";
        public string Make { get; set; } = "DBS";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Prodrive";
        public string Motto { get; set; } = "Quality above quantity";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving foward. . .");
        }
        public void Reverse()
        {
            if ( HasChangedGears == true )
            {
            Console.WriteLine($"{GetType().Name} is now in reverse. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until the gear has been changed. . .");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now parked. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot park until the gear has been changed. . .");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
