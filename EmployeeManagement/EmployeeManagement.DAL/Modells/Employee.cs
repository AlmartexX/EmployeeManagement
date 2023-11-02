using System;

namespace EmployeeManagement.DAL.Modells
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
    }
}
