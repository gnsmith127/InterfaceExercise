using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


    }
}
