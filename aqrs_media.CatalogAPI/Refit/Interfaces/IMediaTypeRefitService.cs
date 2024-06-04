﻿using aqrs_media.CatalogAPI.Entities;
using Refit;

namespace aqrs_media.CatalogAPI.Refit.Interfaces
{
    public interface IMediaTypeRefitService
    {
        [Get("/api/MediaType/{id}")]
        Task<MediaTypeRefit> GetById(Guid id);
    }
}
