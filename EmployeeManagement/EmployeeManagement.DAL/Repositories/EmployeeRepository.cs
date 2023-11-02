using EmployeeManagement.DAL.Modells;
using EmployeeManagement.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Repositories
{
    public class EmployeeRepository : IRepository
    {
        private string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Employee";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (await reader.ReadAsync())
                    {
                        Employee employee = new Employee
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Surname = (string)reader["Surname"],
                            Position = (string)reader["Position"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Salary = (decimal)reader["Salary"],
                        };

                        employees.Add(employee);
                    }
                }

                await command.ExecuteNonQueryAsync();
                return employees;
            }
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            Employee employee = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employee WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //DateTime dateOfBirth = (DateTime)reader["DateOfBirth"];
                        //DateTime dateOnly = new DateTime(dateOfBirth.Year, dateOfBirth.Month, dateOfBirth.Day);
                        employee = new Employee
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Surname = (string)reader["Surname"],
                            Position = (string)reader["Position"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Salary = (decimal)reader["Salary"]
                        };
                    }
                }
            }

            return employee;
        }

        public async Task<List<Employee>> GetEmployeesByPosition(string position)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT * FROM Employee WHERE Position = @Position";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Position", position);

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Employee employee = new Employee
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Surname = (string)reader["Surname"],
                            Position = (string)reader["Position"],

                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Salary = (decimal)reader["Salary"],
                        };
                        employees.Add(employee);
                    }
                }
            }

            return employees;
        }

        public async Task<List<Employee>> GetAverageSalary(string position)
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT Position, AVG(Salary) AS AverageSalary FROM Employee GROUP BY Position";

                if (!string.IsNullOrEmpty(position) && position != "Все должности")
                {
                    query += " HAVING Position = @Position";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(position) && position != "Все должности")
                    {
                        command.Parameters.AddWithValue("@Position", position);
                    }

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Employee employee = new Employee
                            {
                                Position = (string)reader["Position"],
                                Salary = (decimal)reader["AverageSalary"]
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "INSERT INTO Employee (Name, Surname, Position, DateOfBirth, Salary) " +
                "VALUES (@Name, @Surname, @Position, @DateOfBirth, @Salary)";
                SqlCommand command = new SqlCommand(query, connection);


                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Surname", employee.Surname);
                command.Parameters.AddWithValue("@Position", employee.Position);
                command.Parameters.AddWithValue("@DateOfBirth", new DateTime(employee.DateOfBirth.Year, employee.DateOfBirth.Month, employee.DateOfBirth.Day));
                command.Parameters.AddWithValue("@Salary", employee.Salary);

                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task DeleteEmployeeAsync(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "DELETE FROM Employee WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", employeeID);
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
