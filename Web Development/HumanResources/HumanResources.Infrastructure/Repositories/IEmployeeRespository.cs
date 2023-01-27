using HumanResources.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public interface IEmployeeRespository
    {
        public Task<List<Employee>> GetEmployees(string searchText = "");
    }
}
