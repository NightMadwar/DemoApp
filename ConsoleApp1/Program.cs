using static Math.Helper;
using IUST;
using System.Runtime.CompilerServices;
#nullable disable
public class Program
{
    
    private static void Main()
    {

        //int x = 5;
        //Console.WriteLine("Enter a Num");
        //x = int.Parse(Console.ReadLine()!);
        //int y;
        //Increment(x, out y);
        //Console.WriteLine($"x is {x} ,y is {y}");
        //Console.ReadKey();
        //List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
        //List<string> arr2 = new List<string> { "Maher", "Yousef" };
        //arr.Print();
        //Console.WriteLine();
        //arr2.Filtering(true);

        List<Employee> employees = new List<Employee>()
        {
            new Employee{Id = 1, Name ="Maher",Description="professor",Salary=1000,Dept=Department.FullStack,IsManager=true},
            new Employee{Id = 2, Name ="Yousef",Description="Student",Salary=1000,Dept=Department.BackEnd,IsManager=true},
            new Employee{Id = 3, Name ="Wissam",Description="Worker",Salary=1000,Dept=Department.FrontEnd,IsManager=true},            
            new Employee{Id = 4, Name ="Abd",Description="Intern",Salary=600,Dept=Department.FullStack,IsManager=false},
            new Employee{Id = 5, Name ="Bilal",Description="doctor",IsManager=false},
            new Employee{Id = 6, Name ="Samer",Description="doctor",IsManager=false}
        };
        //List<Employee> FilteredEmp = employees.Filtering(a => a.IsManager == true);
        //foreach (Employee emp in FilteredEmp)
        //{
        //    emp.SetInfo();
        //    Console.WriteLine();
        //}
        employees.Filtering(e => e.Salary> 500 && e.Dept == Department.FullStack);

        //List<Employee> filtered = employees.Filtering(e =>e.IsManager == false);
        //filtered.Print();
    }
    
}
public enum Department
{
    FullStack,
    FrontEnd,
    BackEnd,
    HR
}
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Department Dept { get; set; }
    public int Salary { get; set; }
    public bool IsManager { get; set; }

    public void SetInfo()
    {
        Console.WriteLine($"id = {Id}");
        Console.WriteLine($"Name = {Name}");
        Console.WriteLine($"Description = {Description}");
        Console.WriteLine($"Dept = {Dept}");
        Console.WriteLine($"Salary = {Salary}");
        Console.WriteLine($"Is Manager = {IsManager}");
    }
}
public static class Filter
{
        
    public static List<T> Filtering<T>(this List<T> records,Func<T,bool>  Condition)
    {
        List<T> arr = new List<T>();
        if (typeof(T) == typeof(int))
        {
            for (int i = 0; i < records.Count; i++)
            {
                records[i] = (T)(object)(int.Parse(records[i].ToString()) + 1);
                Console.WriteLine(records[i]);
                arr.Add(records[i]);
            }
        }
        if (typeof(T) == typeof(string))
        {
            foreach (T record in records)
            {
                Console.WriteLine($"Hello {record}");
                arr.Add(record);
            }
        }
        if (typeof(T) == typeof(Employee))
        {
            
            foreach (T record in records)
            {
                if (Condition(record))
                {
                    arr.Add(record);
                }
            }                
        }
        return arr;

    }
    public static void Print<T>(this List<T> records)
    {
        if (typeof(T) == typeof(Employee))
        {
            foreach( T record in records)
            {
                ((Employee) (object)record).SetInfo();
                Console.WriteLine();
            }
        }
        else
        {
            foreach (T record in records)
            {
                Console.WriteLine(record);
            }
        }
    }
}