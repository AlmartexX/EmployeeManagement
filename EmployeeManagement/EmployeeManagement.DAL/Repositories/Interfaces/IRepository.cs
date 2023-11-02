using EmployeeManagement.DAL.Modells;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Repositories.Interfaces
{
    public interface IRepository
    {
        Task<List<Employee>> GetAllEmployeesAsync();
        Task<List<Employee>> GetEmployeesByPosition(string position);
        Task<Employee> GetEmployeeById(int id);
        Task<List<Employee>> GetAverageSalary(string position);
        Task CreateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
