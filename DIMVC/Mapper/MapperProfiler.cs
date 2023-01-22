using AutoMapper;
using DIMVC.DbClasses;
using DIMVC.EFConfig;
using DIMVC.Models;
using System.Drawing;

namespace DIMVC.Mapper
{
    public class MapperProfiler : Profile
    {
        public MapperProfiler()
        {
            CreateMap<UnactivatedAccount, RegistrationForm>()
                .ForMember(dest => dest.ConfirmPassword, opt => opt.MapFrom(src => src.PasswordHash));

            CreateMap<RegistrationForm, UnactivatedAccount>()
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.ConfirmPassword));
        }
    }
}
