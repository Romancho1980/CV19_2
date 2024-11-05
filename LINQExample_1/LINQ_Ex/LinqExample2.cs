using LINQExample_1.Models;
using LINQExample_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample_1.LINQ_Ex
{
    public static class LinqExample2
    {
        public static void Run()
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            #region Group example
            //var groupResult = from emp in employeeList
            //                  group emp by emp.DepartamentId;

            //var groupResult = employeeList.OrderByDescending(o=>o.DepartamentId).GroupBy(e => e.DepartamentId);

            //Console.ForegroundColor = ConsoleColor.Cyan; 
            //foreach(var empGroup in groupResult)
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");

            //    foreach(Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\tEmployee FullName: {emp.FirstName} {emp.LastName}");
            //    }
            //}
            #endregion

            #region Quantifier Operators All, Any, Contains
            /// All, Any, Contains Quantifier Operators
            /// Example
            Console.ForegroundColor = ConsoleColor.Cyan;
            //var annualSalaryCompare = 60000;
            //bool isTrueAll = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAll)
            //{
            //    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Not all employee annual salaries are above {annualSalaryCompare}");
            //}

            //bool isTrueAny = employeeList.Any(e => e.AnnualSalary > annualSalaryCompare);
            //if (isTrueAny)
            //{
            //    Console.WriteLine($"At least one employee has salary greater than {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"No employees have an annual salary greater than {annualSalaryCompare}");
            //}

            /// Contains Operator

            //var searchEmployee = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartamentId = 2,
            //};

            //bool containsEmployee = employeeList.Contains(searchEmployee, new EmployeeComparer());
            //if (containsEmployee)
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            //}
            //else
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");
            //}
            ///
            #endregion

            #region Filter Operators ... OfType, Where

            #endregion

            #region Elements Operators

            #endregion

        }
    }
}
