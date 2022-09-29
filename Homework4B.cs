namespace Homework5B;
class Program
{
public static void Main(string[] args)
{
account();
Console.ReadKey(true);
}
public static bool checkAge(int birth_year)
{
int age = 2022 - birth_year;
if(age >= 18)
return true;
else
return false;
}
public static void account()
{
    String userName,password,retypedPassword;
    int birthYear;
    Console.WriteLine("Enter Your Username:");
    userName = Console.ReadLine();
    Console.WriteLine("Enter Your Password:");
    password = Console.ReadLine();
    Console.WriteLine("Enter Your Password Again:");
    retypedPassword = Console.ReadLine();
    Console.WriteLine("Enter Your Birthyear:");
    birthYear = Convert.ToInt32(Console.ReadLine());

    if(checkAge(birthYear))
{
    if(password == retypedPassword)
        Console.WriteLine("Account is created successfully");
    else
        Console.WriteLine("Wrong password");
}
    else
        Console.WriteLine("Could not create an account.");
}
}
