using AutoMapper;

namespace ReaderSharp.Client.WebAssembly.Models.MapperProfile
{
    public class ReadingSettingsProfile : Profile
    {
        public ReadingSettingsProfile()
        {
            CreateMap<ReadingSettingsStorage, ReadingSettings>()
                .ReverseMap();
        }
    }
}
