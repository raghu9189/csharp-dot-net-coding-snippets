using System.Text.Json;

namespace MyApp2.LINQ;

#nullable disable
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public bool IsActive { get; set; }
}

public class Linq01
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

        //==========BEGINER================= 
        // 1. Get all IT employees

        // var AllItEmp = employees.Where<Employee>(emp => emp.Department == "IT");
        // foreach (var item in AllItEmp)
        // {
        //     System.Console.WriteLine(JsonSerializer.Serialize<Employee>(item));
        // }

        // 2. Get employees whose salary > 60000
        // var empSalaryGreaterThan = employees.Where<Employee>(emp => emp.Salary > 60000);
        // foreach (var item in empSalaryGreaterThan)
        // {
        //     System.Console.WriteLine(JsonSerializer.Serialize<Employee>(item));
        // }

        // 3. Get only employee names
        // var empOnlyNames = employees.Select((emp)=>emp.Name);
        // foreach (var name in empOnlyNames)
        // {
        //     System.Console.WriteLine(name);
        // }

        // 4. Sort employees by salary ascending
        // var empSortedAscending = employees.OrderBy(x =>x.Salary);
        // foreach (var item in empSortedAscending)
        // {
        //     System.Console.WriteLine(JsonSerializer.Serialize<Employee>(item));
        // }

        // 5. Sort employees by salary descending
        // var empAgeSortedDescending = employees.OrderByDescending(x =>x.Age);
        // foreach (var item in empAgeSortedDescending)
        // {
        //     System.Console.WriteLine(JsonSerializer.Serialize<Employee>(item));
        // }

        // 6. Get first employee from HR
        // Employee empFirstByHr = employees.FirstOrDefault(x =>x.Department == "HR");
        // System.Console.WriteLine(JsonSerializer.Serialize<Employee>(empFirstByHr));

        // 7. Count active employees
        // var activeEmpCount = employees.Where(x =>x.IsActive == true).Count();
        // System.Console.WriteLine($"Active Emp count : {activeEmpCount}");

        // 8. Check if any employee salary > 100000
        // var anyEmpSalaryGt = employees.Any(x => x.Salary > 100000);
        // System.Console.WriteLine(anyEmpSalaryGt);

        // 9. Check if all employees are active
        // var allEmpActive = employees.All(x => x.IsActive == true);
        // System.Console.WriteLine(allEmpActive);

        // 10. Get highest salary employee

        // Method 1 but Full Sorting not optimized
        // var highestSalaried = employees.OrderByDescending(emp => emp.Salary).FirstOrDefault();
        // System.Console.WriteLine(JsonSerializer.Serialize<Employee>(highestSalaried));

        // Method 2 Optimal 
        // var highestSalaried2 = employees.MaxBy(emp => emp.Salary);
        // System.Console.WriteLine(JsonSerializer.Serialize<Employee>(highestSalaried2));


        //==========Intermediate================= 
        // 11. Group employees by department
        // var groupEmpByDept = employees.GroupBy(x => x.Department);
        // Console.WriteLine(JsonSerializer.Serialize(groupEmpByDept));
        // foreach (var item in groupEmpByDept)
        // {
        //     Console.WriteLine(JsonSerializer.Serialize(item));
        // }

        // 12. Get average salary per department
        // var avgSalaryByDept = employees.GroupBy(emp => emp.Department)
        //     .Select(group => new
        //     {
        //         Department = group.Key,
        //         AverageSalary = group.Average(emp => emp.Salary)
        //     });
        
        // foreach (var item in avgSalaryByDept)
        // {
        //     Console.WriteLine($"{item.Department} - {item.AverageSalary}");
        // }

        // 13. Get total salary of IT department
        // var itDeptTotalSalary = employees
        //     .Where(emp => emp.Department == "IT")
        //     .Sum(salary => salary.Salary);
        // System.Console.WriteLine($"IT Employees Total Salary: {itDeptTotalSalary}");

        // 14. Get top 3 highest paid employees
        // var top3HighestPaid = employees
        //     .OrderByDescending(x => x.Salary)
        //     .Take(3);
        // System.Console.WriteLine($"Top 3 highest paid employees ");
        // foreach(var emp in top3HighestPaid)
        // {
        //     System.Console.WriteLine($"Employee Name: {emp.Name} Salary: {emp.Salary}");
        // }

        // 15. Skip first 2 employees
        // var skipFirst2 = employees
        //     .Skip(2);
        // System.Console.WriteLine($"Skip first 2 employees ");
        // foreach(var emp in skipFirst2)
        // {
        //     System.Console.WriteLine($"Employee Name: {emp.Name} Salary: {emp.Salary}");
        // }

        // 16. Get distinct departments
        // var uniqueDepts = employees.Select(x => x.Department).Distinct();
        // System.Console.WriteLine(JsonSerializer.Serialize(uniqueDepts));

        // 17. Get employees between age 25 and 30
        // var empBwage = employees.Where(x => x.Age is >= 25 and <= 30);
        // foreach(var emp in empBwage)
        // {
        //     System.Console.WriteLine($"Employee Name: {emp.Name} Salary: {emp.Age}");
        // }

        // 18. Get inactive employees
        // var allInactiveEmp = employees.Where(x => !x.IsActive);
        // foreach(var emp in allInactiveEmp)
        // {
        //     System.Console.WriteLine($"Employee Name: {emp.Name} InActive: {emp.IsActive}");
        // }

        // 19. Get employee names in uppercase
        // var empUpperCase = employees.Select(x =>
        // new {
        //     Name = x.Name.ToUpper(),
        //     // put remaining ?
        // });

        // foreach(var item in empUpperCase)
        // {
        //     System.Console.WriteLine(JsonSerializer.Serialize(item));
        // }

        // 20. Find employee by Id
        // var findEmp = employees.SingleOrDefault(x => x.Id == 19);
        // System.Console.WriteLine(JsonSerializer.Serialize(findEmp));

        // =========Advanced======================
        
    }
}