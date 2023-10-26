namespace S07_OOP.Vehicle
{
    internal class Car : VehicleBase
    {
        public static int MaxSpeed = 250;
        public static string Color = "Yellow";
        private string nameCar = "";


        /// <summary>
        /// default constructor
        /// </summary>
        public Car()
        {
            nameCar = "pride";
            //_model = "pride";
        }

        public Car(string model)
        {
            //_model = model;
        }

        public Car(string model, string year)
        {
            //_model = model;
            _year = year;
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car Started");
        }


        public override void IncreaseSpeed(int kph)
        {
            if (kph <= 0)
            {
                throw new Exception("سرعت خودرو نمی تواند منفی باشد");
            }

            if (kph >= 100)
            {
                throw new Exception("سرعت خودرو نمی تواند بیشتر از 100 کیلومتر بر سشاعت شود");
            }

            if (kph > _speed)
                _speed = kph;
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
