using S05_OOP.Codes.Vehicle;



//var vehicle = new VehicleBase();
//vehicle._name = "";

var car = new Car();
car._model = "";
car._capacity = 5;
car.IncreaseSpeed(1000);
car.Start();

var bicycle=new Bicycle();
bicycle._capacity = 1;
bicycle.Start();
bicycle.Stop();


//Console.WriteLine("Hello, World!");
