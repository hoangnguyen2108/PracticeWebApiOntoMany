using AutoMapper;
using PracticeWebApiOntoMany.Dto;
using PracticeWebApiOntoMany.Model;

namespace PracticeWebApiOntoMany.Cofiguration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ListProductDto>().ReverseMap();
            CreateMap<Product, DetailProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name)).ReverseMap();

            CreateMap<Product, EditProductDto>().ReverseMap();
        }
    }
}
