using aqrs_media.WebAPI.DTOs;
using aqrs_media.WebAPI.Entities;
using AutoMapper;

namespace aqrs_media.WebAPI.Mappings
{
    public class DomainToDTOAndReverseProfile : Profile
    {
        public DomainToDTOAndReverseProfile()
        {
            CreateMap<Media, MediaInsDTO>().ReverseMap();
            CreateMap<Media, MediaPutDTO>().ReverseMap();
            CreateMap<Genre, GenreInsDTO>().ReverseMap();
            CreateMap<Genre, GenrePutDTO>().ReverseMap();
        }
    }
}
