using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByName = new Dictionary<string, List<Employee>>();

            employeesByName.Add("John", new List<Employee>() { new Employee { Name = "John" } });

            employeesByName["John"].Add(new Employee() { Name = "John" });
            
            foreach (var item in employeesByName)
            {
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }

        }
    }
}
