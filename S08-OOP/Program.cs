// See https://aka.ms/new-console-template for more information

using S07_OOP.Vehicle;



var age = 5;



Console.WriteLine("Hello, World!");

//var c = new VehicleBase();

var car = new Car();
car._capacity = 5;

var car1 = new Car();
car1._capacity = 4;


var car2 = new Car();
var car3 = new Car();
var car4 = new Car();

Car.MaxSpeed = 200;

car.Start();


//Car.Color = "blue";

var speed1 = car.Speed;

//car.Speed = 100;
//car.Speed = -10;

car.IncreaseSpeed(50);
// car.Speed = 40;

//car.CarSpeed = 50;

//Console.WriteLine($"Car Speed is : {car.Speed}");
Console.WriteLine($"Car Speed is : {car.Speed}");

Console.ForegroundColor= ConsoleColor.Red;
Console.WriteLine($"Car Speed is : {car.GetSpeed()}");
