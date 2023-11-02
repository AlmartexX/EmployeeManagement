using System;

namespace EmployeeManagement.ViewModell
{
    public class EmployeeViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
    }
}
