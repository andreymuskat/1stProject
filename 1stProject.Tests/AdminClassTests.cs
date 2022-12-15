using System.Xml;
using _1stProject;
using _1stProject.Options;
using NUnit.Framework;

namespace _1stProject.Tests
{
    public class AdminClassTests
    {
        [Test]
        public void DeleteEmployeeTest()
        {
            List<Employee> employees1 = new List<Employee>()
            {
                new Employee(1, "Andrey", "88005553535", TimeTable.Shift5x2),
            };

            Database.Employees = new List<Employee>()
            {
              new Employee(1, "Andrey", "88005553535", TimeTable.Shift5x2),
              new Employee(2, "Stepan", "88005553535", TimeTable.Shift2x2),
            };

            AdminClass admin = new AdminClass(4, "Darya", "89301654545", TimeTable.Shift1x3);

            admin.DeleteEmployee(2);

            List<Employee> expectedEmployees = employees1;
            List<Employee> actualEmployees = Database.Employees;
            CollectionAssert.AreEqual(expectedEmployees, actualEmployees);
        }
    }
}