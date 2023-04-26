using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public double EngineSize { get; set; } = 2.7;
        public string Model { get; set; } = "Lincoln";
        public string Make { get; set; } = "Nautilus";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ford Motor Company";
        public string Motto { get; set; } = "Because when everyone is free to move, and free to dream, we do what we do best: we change the world";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        public bool HasAllWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasAllWheelDrive == true)
            {
                Console.WriteLine($"All wheel drive {GetType().Name} is now driving foward. . .");

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
