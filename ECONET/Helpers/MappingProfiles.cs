using AutoMapper;
using Core.Entities;
using ECONET.DTO;

namespace ECONET.Helpers
{
    public class MappingProfiles : Profile
    {
        protected MappingProfiles()
        {
            CreateMap<Item, ItemToReturnDto>()
            .ForMember(d => d.ItemBrand, o => o.MapFrom(s => s.ItemBrand.Name))
            .ForMember(d => d.ItemCategory, o => o.MapFrom(s => s.ItemBrand.Name))
            .ForMember(d => d.PictureUrl, o => o.MapFrom<ItemUrlResolver>());
           
        }
    }
}
