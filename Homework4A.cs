namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("The Largest Number: " + largest(first, second));
    }
    static int largest(int a, int b){
        if(a>b){
            return a;
        }else{
            return b;
        }
    }
}
