using AutoMapper;
using EmployeeManagement.BLL.DTO;
using EmployeeManagement.DAL.Modells;

namespace EmployeeManagement.BLL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, CreateEmployeeDTO>();
            //CreateMap<EmployeeDTO, Employee>();

        }
    }
}
