using System.Collections.Generic;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}