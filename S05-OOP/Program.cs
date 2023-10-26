
using S04_OOP.SampleClasses;



/*
 * Letter Case
 *
 * camelCase    ===== iAmMahmoud,   tempAgeOfCompany
 * PascalCase   ===== IAmMahmoud,   TempAgeOfCompany
 * kebab-case   ===== i-am-mahmoud,   temp-age-of-company
 * Snake_Case   ===== I_Am_Mahmoud,   Temp_Age_Of_Company
 *
 * Naming Rule
 * Naming Convention
 *
 */

int a = new int();
a = 5;

int age = 5;


string name1 = new string("hasan");
string name = "hasan";


var pride = new Car();
pride.color = "red";
pride.engineNumber = "515215150";
pride.vin = "2510518515";


Console.WriteLine("Car Name " + Car.name);
Car.name = "hasan";
Console.WriteLine("Car Name " + Car.name);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Vin Number " + pride.vin);
pride.vin = "33333333333";
Console.WriteLine("Vin Number " + pride.vin);

/*
 * Types
 *  Primitive   Types (int, string, bool, ...)
 *  Pre-Define  Types (object, ...)
 *  User-Define Types (car, Student, University, ...)
 * 
 * Types (Class, Struct, Interface, Record, ...)
 * 
 * Class Members
 *      Method, Constructor, Fields, Properties, ...
 *
 * Static Members
 *
 * Access Modifiers
 *
 *
 */


/*
 * OOP
 *
 *  Inheritance
 *  Polymophysm
 *  Encapsoulation
 *  Abstraction
 */