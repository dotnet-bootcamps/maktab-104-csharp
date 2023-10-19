using System.Reflection;

namespace S06_OOP.Vehicle
{
    internal class Car : VehicleBase
    {
        private string nameCar = "";


        /// <summary>
        /// default constructor
        /// </summary>
        public Car()
        {
            nameCar = "pride";
            _model = "pride";
        }

        public Car(string model)
        {
            _model = model;
        }

        public Car(string model, string year)
        {
            _model = model;
            _year = year;
        }


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
