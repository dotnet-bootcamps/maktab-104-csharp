//int[] myNumbers = { 1, 2, 3 };
//Console.WriteLine(myNumbers[10]); // error!

using S10_ExceptionHandling;

var execption = new System.IndexOutOfRangeException();

// **** Exception Handling
try
{
    Console.Write("Enter first number: ");
    var number1 = int.Parse(Console.ReadLine());


    Console.Write("Enter second number: ");
    var number2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
}
catch (Exception ex)
{
    // log to database
    // send sms, email



    //throw ex;
    // show a message to user in another layer or it's not my ....
    // Console.WriteLine($"there is an error at operation : " + ex.Message);
}
finally
{
    Console.WriteLine("The 'try catch' is finished.");
}



static void checkAge(int age)
{
    if (age < 18)
    {
        var e = new ArithmeticException("Access denied - You must be at least 18 years old.");
        throw e;
        //throw new MyApplicationException();
    }
    else
    {
        Console.WriteLine("Access granted - You are old enough!");
    }
}



// **** Validation

//if (number2 == 0)
//{
//    Console.WriteLine($"error, second number is 0");
//}
//else
//{
//    Console.WriteLine($"{number1} / {number2} = {number1/number2}");
//}













// 1- syntax error => at compile time

// 2- runtime error ==== try..catch

// 3- logical error
//if (number1 > 5 && number1 < 4)
//{

//}



// Exception ???  Error