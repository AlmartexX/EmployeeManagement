using AutoMapper;
using EmployeeManagement.BLL.DTO;
using EmployeeManagement.BLL.Services.Interfaces;
using EmployeeManagement.ViewModell;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class AddNewEmployeeForm : Form
    {
        private readonly IEmployeeService _service;
        private readonly IMapper _mapper;
        public AddNewEmployeeForm(IEmployeeService service, IMapper mapper)
        {
            InitializeComponent();
            _service = service;
            _mapper = mapper;
        }

        private void FillGenderComboBox()
        {
            PositionComboBox.Items.Add("Менеджер");
            PositionComboBox.Items.Add("Директор");
            PositionComboBox.Items.Add("Разработчик");
            PositionComboBox.Items.Add("Бизнес-аналитик");

        }
        private EmployeeViewModel GetPersonFromFormFields()
        {
            //string dateText = DateOfBirtthDateTimePicker.Value.ToShortDateString();
            //DateTime dateOnly = DateTime.Parse(dateText);
            if (decimal.TryParse(SalaryTextBox.Text, out decimal salaryValue))
            {
                var formData = new EmployeeViewModel
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    DateOfBirth = DateOfBirtthDateTimePicker.Value.Date,
                    Position = PositionComboBox.Text,
                    Salary = salaryValue
                };

                return formData;
            }
            else
            {
                MessageBox.Show("Неверный формат зарплаты. Пожалуйста, введите число с плавающей точкой.");
                return null;
            }

        }

        private async void AddEmplyeeButton_Click(object sender, EventArgs e)
        {
            var formData = GetPersonFromFormFields();
            var person = _mapper.Map<CreateEmployeeDTO>(formData);
            string errorMessage = await _service.CreateEmplyeeAsync(person);
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Пользователь успешно создан");
            }
            else
            {
                MessageBox.Show(errorMessage, "Ошибка валидации");
            }
        }

        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {
            FillGenderComboBox();
        }
    }
}
