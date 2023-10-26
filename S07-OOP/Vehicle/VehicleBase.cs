namespace S06_OOP.Vehicle
{
    internal abstract class VehicleBase
    {
        public string _name;
        private string _model;
        protected string _year;
        public int _capacity;

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public virtual void Start()
        {
            _year = "10";
            Console.WriteLine("Starting The Vehicle...");
        }

        public abstract void IncreaseSpeed(int kph);
        public abstract void IncreaseSpeed(int kph, int minSpeed);

        public abstract void DecreaseSpeed(int kph);

        public abstract void Brake();

    }
}
