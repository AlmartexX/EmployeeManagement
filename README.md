# EmployeeManagement

Чтобы развернуть приложение распакуйте архив, поменяйте сроку подключения к бд в классе program и EmployeeManagementForm , создайте таблицу по скрипту 
CREATE TABLE Employee
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255),
    Surname NVARCHAR(255),
    Position NVARCHAR(255),
    DateOfBirth DATETIME,
    Salary DECIMAL(18, 2)
);

 
