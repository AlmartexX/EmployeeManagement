using AutoMapper;
using EmployeeManagement.BLL.DTO;
using EmployeeManagement.ViewModell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeViewModel, CreateEmployeeDTO>();
            CreateMap<CreateEmployeeDTO, EmployeeViewModel>();

        }
    }
}
