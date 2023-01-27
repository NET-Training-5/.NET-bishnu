using HumanResources.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class EmployeeRespository: IEmployeeRespository
    {
        private readonly HRDbContext db;

        public EmployeeRespository(HRDbContext _db)
        {
            db = _db;
        }

        public async Task<List<Employee>> GetEmployees(string searchText = "")
        {
            var employees = await db.Employees.Include(e => e.Department).ToListAsync();

            // Filter
            if (!string.IsNullOrEmpty(searchText))
                employees = employees.Where(emp => emp.Name.Contains(searchText, StringComparison.InvariantCultureIgnoreCase)).ToList();

            return employees;
        }

    }
}
