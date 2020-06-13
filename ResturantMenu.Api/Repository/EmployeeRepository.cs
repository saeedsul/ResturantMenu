using System.Collections.Generic;
using System.Linq;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Api.Models;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _appDbContext.Employees;
        }
    }
}