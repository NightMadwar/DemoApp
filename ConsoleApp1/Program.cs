using static Math.Helper;
using IUST;
internal class Program
{
    private static void Main()
    {
        int x = 5;
        Console.WriteLine("Enter a Num");
        x = int.Parse(Console.ReadLine()!);
       
        x = Increment(ref x);
        Console.WriteLine($"x is {x}");
        Console.ReadKey(); 
    }
}