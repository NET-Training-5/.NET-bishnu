using HumanResources.Web.Models;
using HumanResources.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly HRDbContext dbContext;

        public EmployeesController(HRDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<EmployeeData> GetEmployees()
        {           
            var employees = from e in dbContext.Employees
                            join d in dbContext.Departments
                            on e.DepartmentId equals d.Id
                            select new EmployeeApiModel
                            {
                                Id = e.Id,
                                Name = e.Name,
                                Address = e.Address,
                                Designation = e.Designation,
                                Dob = e.Dob,
                                Email = e.Email,
                                Gender = e.Gender,
                                JoinDate = e.JoinDate,
                                ProfileImagePath = e.ProfileImagePath,
                                DepartmentName = d.Name
                            };

            //var employees = await dbContext.Employees.Include(e => e.Department).ToListAsync();
            var result = await employees.ToListAsync();
            return new EmployeeData { Data = result };
        }

        [HttpGet("{id}")]   //  api/employees/1023
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await dbContext.Employees.FindAsync(id);
            
            if (employee is null)
                return NotFound();
            
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Employee employee)
        {
            if (employee is null)
                return BadRequest();

            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();

            return Created($"api/employees/{employee.Id}", employee.Id);
        }

        [HttpPut]
        public async Task<ActionResult<int>> Put(Employee employee)
        {
            if (employee is null)
                return BadRequest();

            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch]
        public async Task<ActionResult<int>> Patch(Employee employee)
        {
            if (employee is null)
                return BadRequest();

            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if(id is 0)
                return BadRequest();

            var employee = await dbContext.Employees.FindAsync(id);
            if (employee is null)
                return NotFound();

            dbContext.Employees.Remove(employee);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
