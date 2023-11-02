using System;

namespace EmployeeManagement.BLL.DTO
{
    public class CreateEmployeeDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
    }
}
