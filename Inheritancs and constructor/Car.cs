using System;

namespace Inheritancs_and_constructor
{
    public class Car : Vehicle
    {
        //private readonly string registrationNumber;

        public Car(string registrationNumber)
            : base(registrationNumber + "MEGHLA")
        {
            
            Console.WriteLine($"Car is being initialized. {registrationNumber}");
        }


    }
}
