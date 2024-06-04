using AutoMapper;
using aqrs_media.CatalogAPI.DTOs;
using aqrs_media.CatalogAPI.Entities;
using aqrs_media.CatalogAPI.Refit.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aqrs_media.CatalogAPI.Refit.Interface;

namespace aqrs_media.CatalogAPI.Mappings
{
    public class DomainToDTOAndReverse : Profile
    {
        public DomainToDTOAndReverse()
        {
            CreateMap<Catalog, CatalogDTO>()
                .ForMember(dest => dest.MediaName, opt => opt.MapFrom<MediaNameResolver>())
                .ForMember(dest => dest.Type, opt => opt.MapFrom<MediaTypeNameResolver>())
                .ForMember(dest => dest.Category, opt => opt.MapFrom<CategoryNameResolver>())
                .ForMember(dest => dest.Genre, opt => opt.MapFrom<GenreNameResolver>())
                .ForMember(dest => dest.Rating, opt => opt.MapFrom<RatingNameResolver>())
                .ReverseMap();
                
            

            CreateMap<CatalogInsDTO, Catalog>()
                .ForMember(dest => dest.Participants, opt => opt.MapFrom<ParticipantInsResolver>());

            CreateMap<CatalogPutDTO, Catalog>()
                .ForMember(dest => dest.Participants, opt => opt.MapFrom<ParticipantPutResolver>());


            CreateMap<CatalogParticipant, ParticipantDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom<ParticipantNameResolver>())
                .ReverseMap();
        }
    }

    public class ParticipantInsResolver : IValueResolver<CatalogInsDTO, Catalog, List<CatalogParticipant>>
    {
        public List<CatalogParticipant> Resolve(CatalogInsDTO source, Catalog destination, List<CatalogParticipant> destMember, ResolutionContext context)
        {
            var participants = new List<CatalogParticipant>();

            foreach (var participantId in source.Participants)
            {
                participants.Add(new CatalogParticipant { CatalogId = destination.Id, ParticipantId = participantId });
            }

            return participants;
        }
    }

    public class ParticipantPutResolver : IValueResolver<CatalogPutDTO, Catalog, List<CatalogParticipant>>
    {
        public List<CatalogParticipant> Resolve(CatalogPutDTO source, Catalog destination, List<CatalogParticipant> destMember, ResolutionContext context)
        {
            var participants = new List<CatalogParticipant>();

            foreach (var participantId in source.Participants)
            {
                participants.Add(new CatalogParticipant { CatalogId = destination.Id, ParticipantId = participantId });
            }

            return participants;
        }
    }

    public class ParticipantNameResolver : IValueResolver<CatalogParticipant, ParticipantDTO, string>
    {
        private readonly IParticipantRefitService _participantRefitService;

        public ParticipantNameResolver(IParticipantRefitService participantRefitService)
        {
            _participantRefitService = participantRefitService;
        }

        public string Resolve(CatalogParticipant source, ParticipantDTO destination, string destMember, ResolutionContext context)
        {
            var participantName = _participantRefitService
                                        .GetById(source.ParticipantId)
                                        .Result
                                        .Name;

            return participantName;
        }
    }


    public class MediaNameResolver : IValueResolver<Catalog, CatalogDTO, string>
    {
        private readonly IMediaRefitService _mediaRefitService;

        public MediaNameResolver(IMediaRefitService mediaRefitService)
        {
            _mediaRefitService = mediaRefitService;
        }

        public string Resolve(Catalog source, CatalogDTO destination, string destMember, ResolutionContext context)
        {
            var media = _mediaRefitService.GetById(source.MediaId).Result;

            return media.Name;
        }
    }

    public class MediaTypeNameResolver : IValueResolver<Catalog, CatalogDTO, string>
    {
        private readonly IMediaTypeRefitService _mediaTypeRefitService;

        public MediaTypeNameResolver(IMediaTypeRefitService mediaTypeRefitService)
        {
            _mediaTypeRefitService = mediaTypeRefitService;
        }

        public string Resolve(Catalog source, CatalogDTO destination, string destMember, ResolutionContext context)
        {
            var mediaType = _mediaTypeRefitService.GetById(source.MediaTypeId).Result;

            return mediaType.Name;
        }
    }

    public class CategoryNameResolver : IValueResolver<Catalog, CatalogDTO, string>
    {
        private readonly ICategoryRefitService _categoryRefitService;

        public CategoryNameResolver(ICategoryRefitService categoryRefitService)
        {
            _categoryRefitService = categoryRefitService;
        }

        public string Resolve(Catalog source, CatalogDTO destination, string destMember, ResolutionContext context)
        {
            var category = _categoryRefitService.GetById(source.CategoryId).Result;

            return category.Name;
        }
    }

    public class GenreNameResolver : IValueResolver<Catalog, CatalogDTO, string>
    {
        private readonly IGenreRefitService _genreRefitService;

        public GenreNameResolver(IGenreRefitService genreRefitService)
        {
            _genreRefitService = genreRefitService;
        }

        public string Resolve(Catalog source, CatalogDTO destination, string destMember, ResolutionContext context)
        {
            var genre = _genreRefitService.GetById(source.GenreId).Result;

            return genre.Name;
        }
    }

    public class RatingNameResolver : IValueResolver<Catalog, CatalogDTO, string>
    {
        private readonly IRatingRefitService _ratingRefitService;

        public RatingNameResolver(IRatingRefitService ratingRefitService)
        {
            _ratingRefitService = ratingRefitService;
        }

        public string Resolve(Catalog source, CatalogDTO destination, string destMember, ResolutionContext context)
        {
            var rating = _ratingRefitService.GetById(source.RatingId).Result;

            return rating.Name;
        }
    }
}
