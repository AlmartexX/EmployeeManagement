using EmployeeManagement.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> GetAllEmployeesAsync();
        Task<List<EmployeeDTO>> GetEmployeesByPosition(string position);
        Task<List<EmployeeDTO>> GetAverageSalary(string position);
        Task<string> CreateEmplyeeAsync(CreateEmployeeDTO employee);
        Task DeleteEmployeeAsync(int? id);
    }
}
