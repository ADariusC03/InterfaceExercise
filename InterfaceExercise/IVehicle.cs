using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public  interface IVehicle
    {
        public int Wheels { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public bool HasChangedGears { get; set; }


        public void Park();
        public void ChangeGears(bool isChanged);
        public void Reverse();
        public void Drive();
    }

}
