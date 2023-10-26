
// آقای صادقی پور


using S08_Files_ImportExportCsv;

string filePath = @"E:\MaktabSharif.S08\userInfo.csv";
var a =File.Create(filePath);
a.Close();
bool gettingUserFlag = true;


while (gettingUserFlag)
{
    User user = new User();

    File.AppendAllText(filePath, $"{user._id}, ");

    Console.WriteLine("Name :");
    string name = Console.ReadLine();
    user._name = name;
    File.AppendAllText(filePath, $"{user._name},");

    Console.WriteLine("Last Name : ");
    string lastName = Console.ReadLine();
    user._lastName = lastName;
    File.AppendAllText(filePath, $"{user._lastName}");

    Console.WriteLine("Age : ");
    int age = int.Parse(Console.ReadLine());
    user._age = age;
    File.AppendAllText(filePath, $"{user._age}");
    

    user._registerTime = DateTime.Now;
    File.AppendAllText(filePath, $"{user._registerTime.ToString()}");
    


    Console.WriteLine("Do You Want To Add More ? true?false");
    gettingUserFlag = bool.Parse(Console.ReadLine());

}
