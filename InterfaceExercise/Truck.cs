using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public bool HasFlatBed { get; set; }
        public bool FourWheelDrive { get; set; }


        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


        public string CompanyName { get; set; }
        public string Motto { get; set; }
    }
}
