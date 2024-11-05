using LINQExample_1.LINQ_Ex;
using TCPData;

namespace LINQExample_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region LINQ Example 1
            //    List<Employee> employeeList = Data.GetEmployees();
            //    List<Department> departmentList = Data.GetDepartments();

            //    //var result = employeeList.Where(e => e.AnnualSalary >= 50000)
            //    //                         .Select(e => new
            //    //                            {
            //    //                                FullName = e.FirstName + " " + e.LastName,
            //    //                                AnnualSalary = e.AnnualSalary,
            //    //                            });

            //    var result = departmentList.GroupJoin(employeeList,
            //        dept => dept.Id,
            //        emp => emp.DepartamentId,
            //        (dept, employeesGroup) => new
            //        {
            //            Employees = employeesGroup,
            //            DepartamentName = dept.LongName
            //        }
            //     );

            //    foreach(var item in result)
            //    {
            //        Console.WriteLine($"Department Name: {item.DepartamentName}");
            //        foreach(var emp in item.Employees)
            //        {
            //            Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
            //        }
            //    }
            #endregion
            #region LINQ Example2
            /// LINQ Example 2
            /// 
            LinqExample2.Run();
            #endregion
        }
    }
}
