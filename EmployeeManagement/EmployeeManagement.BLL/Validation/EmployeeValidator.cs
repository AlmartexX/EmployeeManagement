using EmployeeManagement.BLL.DTO;
using FluentValidation;
using System;

namespace EmployeeManagement.BLL.Validation
{
    public class EmployeeValidator : AbstractValidator<CreateEmployeeDTO>
    {
        public EmployeeValidator()
        {
            RuleFor(p => p.Surname)
                 .NotEmpty()
                 .Length(1, 20)
                 .Matches(@"^[А-Яа-я]+$")
                 .WithMessage("Фамилия должна содержать только буквы кириллицы")
                 .InclusiveBetween("А", "Я")
                 .WithMessage("Фамилия должна начинаться с буквы кириллицы");

            RuleFor(p => p.Name)
                .NotEmpty()
                .Length(1, 20)
                .Matches(@"^[А-Яа-я]+$")
                .WithMessage("Имя должно содержать только буквы кириллицы")
                .InclusiveBetween("А", "Я")
                .WithMessage("Имя должно начинаться с буквы кириллицы");

            RuleFor(e => e.Salary)
                .NotNull().WithMessage("Зарплата не может быть пустой.")
                .GreaterThanOrEqualTo(0).WithMessage("Зарплата должна быть больше или равна нулю.")
                .LessThanOrEqualTo(1000000).WithMessage("Зарплата не может превышать 1 000 000.");

            RuleFor(e => e.Position)
                .NotEmpty();


        }
        public string GetValidationErrorMessage(CreateEmployeeDTO employee)
        {
            var result = Validate(employee);
            return result.IsValid ? null : string.Join(Environment.NewLine, result.Errors);
        }

    }
}
