using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public bool FamilyFriendly { get; set; }
        public int TrunkSize { get; set; }


        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


        public string CompanyName { get; set; }
        public string Motto { get; set; }
    }
}
