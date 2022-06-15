using AutoMapper;
using WebProject.API.DataModels;
using WebProject.API.DomainModels;

namespace WebProject.API.Profiles;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Student,DoStudent>().ReverseMap();
        CreateMap<Gender, DoGender>().ReverseMap();
        CreateMap<Address, DoAddress>().ReverseMap();
    }
}