using System;
namespace InterfaceExercise
{
    public class Car: IVehicle, ICompany
    {
        public Car()
        {
        }

        public int GasMileage { get; set; }
        public bool HasSpareTire { get; set; }


        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


        public string CompanyName { get; set; }
        public string Motto { get; set; }
    }
}
