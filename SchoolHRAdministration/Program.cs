// See https://aka.ms/new-console-template for more information

using HRAdminstrationAPI;
using SchoolHRAdministration;


decimal totalSalaries = 0.0m;

List<IEmployee> employees = new List<IEmployee>();
SeedData(employees);

//foreach (IEmployee employee in employees)
//{
//    totalSalaries += employee.Salary;
//}

Console.WriteLine($"Total Annual Salaries (including bonus): {employees.Sum(e => e.Salary)}");
Console.ReadLine();
static void SeedData(List<IEmployee> employees)
{

    IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", 40000);
    employees.Add(teacher1);

    IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Alice", "Johnson", 45000);
    employees.Add(teacher2);

    IEmployee teacher3 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Charlie", "Smith", 45000);
    employees.Add(teacher3);

    IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 1, "Emily", "Brown", 55000);
    employees.Add(headOfDepartment);

    IEmployee deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 1, "David", "Garcia", 60000);
    employees.Add(deputyHeadMaster);

    IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 1, "Ethan", "Davis", 75000);
    employees.Add(headMaster);
}

enum EmployeeType
{
    Teacher,
    HeadOfDepartment,
    DeputyHeadMaster,
    HeadMaster
}

static class EmployeeFactory
{
    public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
    {
        IEmployee employee = null;

        switch (employeeType)
        {
            case EmployeeType.Teacher:
                employee = FactoryPattern<IEmployee, Teacher>.GetInstance(); //. new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                break;
            case EmployeeType.HeadOfDepartment:
                employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance(); // new HeadOfDepartment { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance(); // new DeputyHeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                break;
            case EmployeeType.HeadMaster:
                employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance(); // new HeadMaster { Id = id, FirstName = firstName, LastName = lastName, Salary = salary };
                break;
            default:
                break;
        }

        if (employee != null)
        {
            employee.Id = id; 
            employee.FirstName = firstName; 
            employee.LastName = lastName; 
            employee.Salary = salary;
        } else
        {
            throw new NullReferenceException();
        }

        return employee;
    }
}