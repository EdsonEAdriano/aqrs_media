using aqrs_media.WebAPI.DTOs;
using aqrs_media.WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Formatters;

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
            CreateMap<Category, CategoryInsDTO>().ReverseMap();
            CreateMap<Category, CategoryPutDTO>().ReverseMap();
            CreateMap<aqrs_media.WebAPI.Entities.MediaType, MediaTypeInsDTO>().ReverseMap();
            CreateMap<aqrs_media.WebAPI.Entities.MediaType, MediaTypePutDTO>().ReverseMap();
            CreateMap<Participant, ParticipantInsDTO>().ReverseMap();
            CreateMap<Participant, ParticipantPutDTO>().ReverseMap();
            CreateMap<Rating, RatingInsDTO>().ReverseMap();
            CreateMap<Rating, RatingPutDTO>().ReverseMap();
        }
    }
}
