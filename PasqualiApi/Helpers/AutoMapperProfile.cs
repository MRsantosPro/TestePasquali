using AutoMapper;
using PasqualiAPI.Entities;
using PasqualiAPI.Models.Pessoa;


namespace PasqualiAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateRequest, Pessoa>();
            CreateMap<UpdateRequest, Pessoa>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));
        }
    }
}
