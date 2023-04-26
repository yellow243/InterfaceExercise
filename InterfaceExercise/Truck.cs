using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public double EngineSize { get; set; } = 5.7;
        public string Model { get; set; } = "RAM";
        public string Make { get; set; } = "1500";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Chrysler";
        public string Motto { get; set; } = "Clean Technology for a New Generation of Families";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
            Console.WriteLine($"Four wheel drive {GetType().Name} is now driving foward. . .");

            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
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
