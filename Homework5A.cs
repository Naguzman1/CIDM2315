namespace Homework5A;
class Program
{
    static void Main()
{
    int L2 = largest2();
        Console.Write("The largest number is: "+L2);
    int L4 = largest4();
        Console.Write("The largest number is: "+L4);
}
    public static int largest2()
{
    int a, b, large;
    Console.WriteLine("Enter 2 numbers: ");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());

    if(a>b)
        large = a;
    else
        large = b;
    return large;
}

public static int largest2Modified(int a, int b)
{
    int large;

    if(a>b)
        large = a;
    else
        large = b;
    return large;
}

public static int largest4()
{
    int a, b, c, d, large;
    Console.WriteLine("\nEnter 4 numbers: ");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    d = Convert.ToInt32(Console.ReadLine());
    large = largest2Modified(largest2Modified(a, b), largest2Modified(c, d));
    return large;
}
}
