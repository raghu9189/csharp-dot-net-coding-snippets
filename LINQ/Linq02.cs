using System.Text.Json;

namespace MyApp2.LINQ;

#nullable disable
file class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public bool IsActive { get; set; }
}

public class Linq02
{
    public static void Run()
    {
        List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "Raghu", Department = "IT", Age = 25, Salary = 60000, IsActive = true },
            new Employee { Id = 2, Name = "John", Department = "HR", Age = 30, Salary = 45000, IsActive = true },
            new Employee { Id = 3, Name = "Sam", Department = "IT", Age = 28, Salary = 75000, IsActive = false },
            new Employee { Id = 4, Name = "David", Department = "Finance", Age = 35, Salary = 90000, IsActive = true },
            new Employee { Id = 5, Name = "Priya", Department = "IT", Age = 24, Salary = 50000, IsActive = true },
            new Employee { Id = 6, Name = "Amit", Department = "HR", Age = 29, Salary = 48000, IsActive = false },
            new Employee { Id = 7, Name = "Sara", Department = "Finance", Age = 31, Salary = 82000, IsActive = true },
            new Employee { Id = 8, Name = "Karan", Department = "IT", Age = 27, Salary = 67000, IsActive = true }
        };
        // First()
        // var employee = employees.First(e => e.Id == 1);
        // System.Console.WriteLine(JsonSerializer.Serialize<Employee>(employee));
        // Throws exception if not found.

        // FirstOrDefault()

        var employee2 =employees.FirstOrDefault(e => e.Department == "ITO");
        System.Console.WriteLine(JsonSerializer.Serialize<Employee>(employee2));
        // Returns default value.
        // Reference type:
            // null  
        
        // Single
        // var emp = employees.Single<Employee>(e => e.Id == 100);
        // System.Console.WriteLine(JsonSerializer.Serialize<Employee>(emp));
        // Exactly one record must exist.
        // Throws if:
        //     No record
        //     Multiple records

        // SingleOrDefault
        // var emp2 = employees.SingleOrDefault<Employee>(e => e.Id == 200);
        // System.Console.WriteLine(JsonSerializer.Serialize<Employee>(emp2));
    }
}

// Important Notes
// LINQ queries are lazily evaluated. Execution occurs only when data is actually requested.
/*
Executes immediately.
Methods causing execution:
    ToList()
    ToArray()
    Count()
    Sum()
    Max()
    Min()
    First()
    Single()

*/

