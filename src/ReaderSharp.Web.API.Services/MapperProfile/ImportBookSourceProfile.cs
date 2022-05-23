using System;
using AutoMapper;
using ReaderSharp.Web.API.Models.Dtos;
using ReaderSharp.Web.API.Models.Entities;

namespace ReaderSharp.Web.API.Services.MapperProfile
{
    public class ImportBookSourceProfile : Profile
    {
        public ImportBookSourceProfile()
        {
            CreateMap<ImportBookInfoRuleDto, SourceBookInfoRule>()
                .ForMember(dest => dest.BookInfoRuleId, opt => opt.MapFrom(src => Guid.NewGuid().ToString()))
                .ForMember(dest => dest.BookSourceId, opt => opt.Ignore())
                .ForMember(dest => dest.BookSource, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ImportCatalogRuleDto, SourceCatalogRule>()
                .ForMember(dest => dest.CatalogRuleId, opt => opt.MapFrom(src => Guid.NewGuid().ToString()))
                .ForMember(dest => dest.BookSourceId, opt => opt.Ignore())
                .ForMember(dest => dest.BookSource, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ImportContentRuleDto, SourceContentRule>()
                .ForMember(dest => dest.ContentRuleId, opt => opt.MapFrom(src => Guid.NewGuid().ToString()))
                .ForMember(dest => dest.BookSourceId, opt => opt.Ignore())
                .ForMember(dest => dest.BookSource, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ImportSearchRuleDto, SourceSearchRule>()
                .ForMember(dest => dest.SearchRuleId, opt => opt.MapFrom(src => Guid.NewGuid().ToString()))
                .ForMember(dest => dest.BookSourceId, opt => opt.Ignore())
                .ForMember(dest => dest.BookSource, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ImportBookSourceDto, BookSource>()
                .ForMember(dest => dest.BookSourceId, opt => opt.MapFrom(src => Guid.NewGuid().ToString()))
                .ForMember(dest => dest.BookSourceName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BookSourceType, opt => opt.MapFrom(src => 0))
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.BookSourceNote, opt => opt.MapFrom(src => src.Note))
                .ForMember(dest => dest.BookInfoRule, opt => opt.MapFrom(src => src.BookInfoRule))
                .ForMember(dest => dest.CatalogRule, opt => opt.MapFrom(src => src.CatalogRule))
                .ForMember(dest => dest.ContentRule, opt => opt.MapFrom(src => src.ContentRule))
                .ForMember(dest => dest.SearchRule, opt => opt.MapFrom(src => src.SearchRule))
                .ReverseMap();
        }
    }
}
