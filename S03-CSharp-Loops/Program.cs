using Microsoft.VisualBasic;

namespace S03_CSharp_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // فاکتوریل عدد 5 با استفاده از حلقه فور
            //var factorial5 = 5 * 4 * 3 * 2 * 1;
            //var factorial5 = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    factorial5 *= i;
            //}
            //Console.WriteLine(factorial5);



            // چاپ اعداد 0 تا 999 با حلقه وایل
            //var counter = 0;
            //while (counter<1000)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            // چاپ اعداد 0 تا 999 با حلقه دو/وایل
            //var counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter < 1000);


            // فاکتوریل عدد 5 با استفاده از حلقه وایل
            //var factorial5 = 5 * 4 * 3 * 2 * 1;
            //var factorial5 = 1;
            //int i = 1;
            //while (i <= 5)
            //{
            //    factorial5 *= i;
            //    i++;
            //}
            //Console.WriteLine(factorial5);


            // محاسبه فاکتوریل عدد ورودی
            //Console.WriteLine("enter number");
            //var inputNumber = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //int i = 1;
            //while (i <= inputNumber)
            //{
            //    factorial *= i;
            //    i++;
            //}
            //Console.WriteLine(factorial);


            //Console.WriteLine("Enter Count Of Number To Calc Factorial:");
            //var mainCounterInputNumber = int.Parse(Console.ReadLine());
            //for (int mainCounter = 1; mainCounter <= mainCounterInputNumber; mainCounter++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine($"enter number {mainCounter} to calc factorial:");
            //    var inputNumberToCalcFactorial = Convert.ToInt32(Console.ReadLine());

            //    var factorial = 1;
            //    int i = 1;
            //    while (i <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= i;
            //        i++;
            //    }

            //    Console.WriteLine(factorial);
            //} 



            //Console.WriteLine("Enter Count Of Number To Calc Factorial:");
            //var mainCounterInputNumber=int.Parse(Console.ReadLine());
            //int mainCounter = 1;
            //do
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine($"enter number {mainCounter} to calc factorial:");
            //    var inputNumberToCalcFactorial = Convert.ToInt32(Console.ReadLine());

            //    var factorial = 1;
            //    int i = 1;
            //    while (i <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= i;
            //        i++;
            //    }

            //    Console.WriteLine(factorial);
            //    mainCounter++;
            //} while (mainCounter <= mainCounterInputNumber);




            //do
            //{
            //    Console.WriteLine("Number A To Calc Factorial:");
            //    Console.WriteLine("Enter \"exit\" if you don't want to continue");
            //    var userInput = Console.ReadLine();

            //    if (userInput == "exit")
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        var inputNumberToCalcFactorial = Convert.ToInt32(userInput);
            //        var factorial = 1;
            //        int i = 1;
            //        while (i <= inputNumberToCalcFactorial)
            //        {
            //            factorial *= i;
            //            i++;
            //        }
            //        Console.WriteLine(factorial);
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //} while (true);


            //for (int mainCounter = 1; mainCounter <= mainCounterInputNumber; mainCounter++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine($"enter number {mainCounter} to calc factorial:");
            //    var inputNumberToCalcFactorial = Convert.ToInt32(Console.ReadLine());

            //    var factorial = 1;
            //    int i = 1;
            //    while (i <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= i;
            //        i++;
            //    }

            //    Console.WriteLine(factorial);
            //}


            //// break
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //// continue
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            // اعداد اول
            //var number = 10;
            //var conditionCounter = 0;

            //for (int i = 2; i < number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        conditionCounter++;
            //    }
            //}
            //if (conditionCounter == 0)
            //{
            //    Console.WriteLine($"{number} is a prime number");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number");
            //}



            // آرایه ها
            //int[] ages = { 20, 30, 25, 40, 43, 18, 80, 15 };
            //int[] sortedAges={}

            //int a = 15;
            //Console.WriteLine(a);
            //a = 35;
            //Console.WriteLine(a);


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //foreach (var car in cars)
            //{
            //    Console.WriteLine(car);
            //}


            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //Console.WriteLine();

            //int c = 0;
            //while ( c < cars.Length)
            //{
            //    Console.WriteLine(cars[c]);
            //    c++;
            //}


            int[] myNumbers = { 5, 1, 8, 9 };
            //int *IntPtr = & myNumbers;

            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
    }
}