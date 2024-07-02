using aqrs_media.MediaAPI.DTOs;
using aqrs_media.MediaAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace aqrs_media.MediaAPI.Mappings
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
            CreateMap<aqrs_media.MediaAPI.Entities.MediaType, MediaTypeInsDTO>().ReverseMap();
            CreateMap<aqrs_media.MediaAPI.Entities.MediaType, MediaTypePutDTO>().ReverseMap();
            CreateMap<Participant, ParticipantInsDTO>().ReverseMap();
            CreateMap<Participant, ParticipantPutDTO>().ReverseMap();
            CreateMap<Rating, RatingInsDTO>().ReverseMap();
            CreateMap<Rating, RatingPutDTO>().ReverseMap();

            CreateMap<Media, BaseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<Category, BaseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<Genre, BaseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<aqrs_media.MediaAPI.Entities.MediaType, BaseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<Participant, BaseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<Rating, BaseDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

        }
    }
}
