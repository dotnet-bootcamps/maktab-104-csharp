using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_OOP.Codes.Vehicle
{
    internal class Car : VehicleBase
    {
        
        //public override void Start()
        //{
        //    base.Start();
        //    Console.WriteLine("Car Is Starting...");
        //}


        public override void IncreaseSpeed(int kph)
        {
            Stop();
            Start();
            IncreaseSpeed(1);
        }

        public override void IncreaseSpeed(int kph, int minSpeed)
        {
            throw new NotImplementedException();
        }

        public override void DecreaseSpeed(int kph)
        {
        }

        public override void Brake()
        {
        }
    }
}
