using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle,ICompany
    {
        public int Wheels { get; set; } = 4;
        public string Model { get; set; } = "Malibu";
        public string Make { get; set; } = "Chevrolet";
        public string Year { get; set; } = "2000";
        public bool HasChangedGears { get; set; } = true;
        public string CompanyName { get; set; } = "Chevrolet";
        public string CompanyLogo { get; set; } = "The New Standard For The World";
        public bool HasTrunk { get; set; } = true;


      
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now driving...Drive safe and Do the Limit.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't drive if gears not shifted.");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is in park.");
            }
            
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...Make sure to watch out for cars.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we shift gears.");
            }
        }
    }
}
