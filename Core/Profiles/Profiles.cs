

using AutoMapper;
using Core.Helpers;
using Core.Dtos;
using Core.Entities;

namespace Core.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap < OwnersDtoIn,Owners>();
            //createmap<owners, ownersdto>().formember(
            //    dest => dest.name,
            //    opt => opt.mapfrom(src => $"{src.firstname}{src.lastname}"))
            //    .formember(
            //    dest => dest.age,
            //    opt => opt.mapfrom(src => src.birthday.getcurrentage()));
        }

    }
}
