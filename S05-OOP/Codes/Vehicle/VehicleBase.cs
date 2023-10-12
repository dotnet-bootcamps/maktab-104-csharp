using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_OOP.Codes.Vehicle
{
    internal abstract class VehicleBase
    {
        public string _name;
        public string _model;
        public string _year;
        public int _capacity;

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public virtual void Start()
        {
            Console.WriteLine("Starting The Vehicle...");
        }

        public abstract void IncreaseSpeed(int kph);
        public abstract void IncreaseSpeed(int kph, int minSpeed);

        public abstract void DecreaseSpeed(int kph);

        public abstract void Brake();

    }
}
