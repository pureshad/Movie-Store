using AutoMapper;
using Vidly001.DTOs;
using Vidly001.Models.Entity;

namespace Vidly001.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();
        }
    }
}