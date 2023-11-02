using AutoMapper;
using EmployeeManagement.BLL.DTO;
using EmployeeManagement.BLL.Services;
using EmployeeManagement.BLL.Services.Interfaces;
using EmployeeManagement.DAL.Modells;
using EmployeeManagement.DAL.Repositories.Interfaces;
using EmployeeManagement.DAL.Repositories;
using EmployeeManagement.ViewModell;
using System;
using System.Windows.Forms;
using OfficeOpenXml;
using EmployeeManagement.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeService _service;
        private readonly IMapper _mapper;
        public EmployeeForm(IEmployeeService service, IMapper mapper)
        {
            InitializeComponent();
            _service = service;
            _mapper = mapper;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
            FillGenderComboBox();
        }

        private async void LoadData(string position = null)
        {
            var employees = position == null ? await _service.GetAllEmployeesAsync() : await _service.GetEmployeesByPosition(position);

            dataGridView1.DataSource = employees;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["Id"].ValueType = typeof(int);
            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["Surname"].HeaderText = "Фамилия";
            dataGridView1.Columns["DateOfBirth"].HeaderText = "Дата Рождения";
            dataGridView1.Columns["Position"].HeaderText = "Должность";
            dataGridView1.Columns["Salary"].HeaderText = "Зарплата";
        }

        private void FillGenderComboBox()
        {
            PositionFiltercomboBox.Items.Add("Все должности");
            PositionFiltercomboBox.Items.Add("Менеджер");
            PositionFiltercomboBox.Items.Add("Директор");
            PositionFiltercomboBox.Items.Add("Разработчик");
            PositionFiltercomboBox.Items.Add("Бизнес-аналитик");

        }

        private void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeViewModel, CreateEmployeeDTO>();
                cfg.CreateMap<CreateEmployeeDTO, Employee>();
            });
            IMapper mapper = config.CreateMapper();
            IRepository repository = new EmployeeRepository("Data Source=DESKTOP-QR9ROKJ;Initial Catalog=EmployeesManagement;Trusted_Connection=True;");
            IEmployeeService employeeService = new EmployeeService(repository, mapper);
            AddNewEmployeeForm addNewEmployeeForm = new AddNewEmployeeForm(employeeService, mapper);
            addNewEmployeeForm.ShowDialog();
            LoadData();
        }

        private async void DeleteEmpolyeeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedPersonId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                await _service.DeleteEmployeeAsync(selectedPersonId);
                LoadData();
            }
            else
            {
                MessageBox.Show("Выделите строку для удаления.");
            }
        }

        private async void GetReportOfEmpolyeeButton_Click(object sender, EventArgs e)
        {
            string selectedPosition = PositionFiltercomboBox.SelectedItem.ToString();

            var employees = await _service.GetAverageSalary(selectedPosition);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("AverageSalaryReport");

                for (int i = 0; i < employees.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = employees[i].Position;
                    worksheet.Cells[i + 2, 2].Value = employees[i].Salary;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Отчет сохранен успешно.");
                    }
                }
            }
        }

        private void PositionFiltercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = PositionFiltercomboBox.SelectedItem.ToString();

            if (selectedPosition == "Все должности")
            {
                LoadData();
            }
            else
            {
                LoadData(selectedPosition);
            }
        }
    }
}
