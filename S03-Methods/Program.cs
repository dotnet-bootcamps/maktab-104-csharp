

namespace S03_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
            //        var f = factorial(name: "hasan", number: Convert.ToInt32(userInput));
            //        Console.WriteLine();
            //        Console.WriteLine();
            //    }
            //} while (true);



            //static int factorial(int number, string name)
            //{
            //    var inputNumberToCalcFactorial = number;
            //    var factorial = 1;
            //    int i = 1;
            //    while (i <= inputNumberToCalcFactorial)
            //    {
            //        factorial *= i;
            //        i++;
            //    }
            //    return factorial;
            //}

            //var result = Sum(5, 5);

            //Sum("hasan","5");

            //Console.WriteLine(Sum(5, 5));
            //Console.WriteLine(Sum(5, 5));

            //static void Sum(string name)
            //{
            //    Console.WriteLine(name);
            //}

            static void Sum(string name, string a)
            {
                Console.WriteLine(name);
            }
        }


        static void Sum(string name)
        {
            Console.WriteLine(name);
        }

        static void Sum(string name, string a)
        {
            Console.WriteLine(name);
        }

        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        static double Sum(double n1, double n2)
        {
            return n1 + n2;
        }


    }
}