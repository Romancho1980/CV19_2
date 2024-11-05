using TCPData;
using TCPExtensions;
namespace Linq_101_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList=Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            var filterredEmployee = employeeList.Where(emp => emp.AnnualSalary < 60000);
            foreach (var emp in filterredEmployee)
            {
                Console.WriteLine($"{emp.FirstName, -5}{emp.LastName,10}{emp.AnnualSalary,15}+{emp.IsManager}");
                Console.WriteLine();

            }
        }
    }
}
