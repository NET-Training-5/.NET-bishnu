using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        Employee e1 = new Employee()
        {
            FullName = "Biswas Shrestha",
            Sex = Gender.Male,
            JoinDate = new DateTime(2010, 7, 12),
            Designation = "Software Engineer",
            Department = "Research and Development"
        };

        Employee e2 = new Employee()
        {
            FullName = "RamLakhan Mathema",
            Sex = Gender.Male,
            JoinDate = new DateTime(2009, 6, 10),
            Designation = "Sr. Software Engineer",
            Department = "Research and Development"
        };

        Employee e3 = new Employee()
        {
            FullName = "Rekha Mathema",
            Sex = Gender.Female,
            JoinDate = new DateTime(2013, 5, 10),
            Designation = "Sr. Software Engineer",
            Department = "Operations"
        };

        List<Employee> employees = new List<Employee>() { e1, e2, e3 };

        return View(employees);
    }
}
