using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int Wheels { get; set; } = 4;
        public string Model { get; set; } = "Tacoma";
        public string Make { get; set; } = "Toyota";
        public string Year { get; set; } = "2015";
        public bool HasChangedGears { get; set; } = true;
        public string CompanyName { get; set; } = "Toyota";
        public string CompanyLogo { get; set; } = "Let's Go Places.";
        public bool HasBed { get; set; } = true;
       
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
