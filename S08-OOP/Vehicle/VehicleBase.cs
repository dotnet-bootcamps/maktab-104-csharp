namespace S07_OOP.Vehicle
{
    internal abstract class VehicleBase
    {

        #region Data (Fields/Attributes/State/Variables)
        public string _name;
        private string _model;
        protected string _year;
        public int _capacity;
        protected int _speed = 0;

        #endregion


        #region Properties

        public int Speed
        {
            get
            {
                return _speed;

            }
        }

        #endregion


        #region Behavires
        public int GetSpeed()
        {
            return _speed;
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public virtual void Start()
        {
            // _year = "10";
            Console.WriteLine("Starting The Vehicle...");
        }

        public abstract void IncreaseSpeed(int kph);
        public abstract void IncreaseSpeed(int kph, int minSpeed);

        public abstract void DecreaseSpeed(int kph);

        public abstract void Brake();
        #endregion

    }
}
