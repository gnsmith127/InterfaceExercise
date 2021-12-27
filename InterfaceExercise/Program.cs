using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - done

            //Create 3 classes called Car , Truck , & SUV - done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. - done
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company - done
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class - done 
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size - done
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - done
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car()
            {
                GasMileage = 40,
                HasSpareTire = true,
                Wheels = 4,
                Doors = 4,
                Make = "Toyota",
                Model = "Camry",
                CompanyName = "Toyota Group",
                Motto = "Let's Go Places."

            };


            var suv = new SUV()
            {
                FamilyFriendly = true,
                TrunkSize = 5,
                Wheels = 4,
                Doors = 4,
                Make = "Mazda",
                Model = "CX-5",
                CompanyName = "Mazda USA",
                Motto = "Celebrate Driving."

            };

            var truck = new Truck()
            {
                HasFlatBed = true,
                FourWheelDrive = true,
                Wheels = 4,
                Doors = 2,
                Make = "GMC",
                Model = "Sierra",
                CompanyName = "General Motors",
                Motto = "We stand together to drive the world forward. Everybody in."
            };

            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Doors);
            }

        }
    }
}
