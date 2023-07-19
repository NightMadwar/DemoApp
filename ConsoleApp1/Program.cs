using static Math.Math;
using IUST;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 5;
        x = int.Parse(Console.ReadLine()!);
       
        x = Increament(x);
        Console.WriteLine($"x is {x}");
        Student student = new();
    }
}