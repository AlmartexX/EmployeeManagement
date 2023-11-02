using AutoMapper;
using EmployeeManagement.BLL.DTO;
using EmployeeManagement.BLL.Services.Interfaces;
using EmployeeManagement.BLL.Validation;
using EmployeeManagement.DAL.Modells;
using EmployeeManagement.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDTO>> GetAllEmployeesAsync()
        {
            var employee = await _employeeRepository.GetAllEmployeesAsync();
            return _mapper.Map<List<EmployeeDTO>>(employee);
        }

        public async Task<List<EmployeeDTO>> GetEmployeesByPosition(string position)
        {
            var employee = await _employeeRepository.GetEmployeesByPosition(position);
            return _mapper.Map<List<EmployeeDTO>>(employee);
        }

        public async Task<List<EmployeeDTO>> GetAverageSalary(string position)
        {
            var result = await _employeeRepository.GetAverageSalary(position);
            return _mapper.Map<List<EmployeeDTO>>(result);
        }

        public async Task<string> CreateEmplyeeAsync(CreateEmployeeDTO createEmployeeDTO)
        {
            try
            {
                var errorMessage = new EmployeeValidator().GetValidationErrorMessage(createEmployeeDTO);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    return errorMessage;
                }

                var employee = _mapper.Map<Employee>(createEmployeeDTO);
                await _employeeRepository.CreateEmployeeAsync(employee);
                return null;
            }
            catch (Exception ex)
            {
                return "An error occurred";
            }
        }

        public async Task DeleteEmployeeAsync(int? id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id.Value);

            await _employeeRepository.DeleteEmployeeAsync(id.Value);
        }

    }
}
