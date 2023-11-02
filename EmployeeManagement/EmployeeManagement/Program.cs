using AutoMapper;
using EmployeeManagement.BLL.Services.Interfaces;
using EmployeeManagement.BLL.Services;
using EmployeeManagement.DAL.Repositories.Interfaces;
using EmployeeManagement.DAL.Repositories;
using System;
using System.Windows.Forms;
using EmployeeManagement.BLL.AutoMapper;

namespace EmployeeManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = config.CreateMapper();
            IRepository repository = new EmployeeRepository("Data Source=DESKTOP-QR9ROKJ;Initial Catalog=EmployeesManagement;Trusted_Connection=True;");
            IEmployeeService employeeService = new EmployeeService(repository, mapper);
            Application.Run(new EmployeeForm(employeeService, mapper));
        }
    }
}
