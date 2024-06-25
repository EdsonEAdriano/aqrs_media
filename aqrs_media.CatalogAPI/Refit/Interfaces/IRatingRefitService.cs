﻿using aqrs_media.CatalogAPI.Entities;
using Refit;

namespace aqrs_media.CatalogAPI.Refit.Interfaces
{
    public interface IRatingRefitService
    {
        [Get("/api/Rating/{id}")]
        Task<ApiResponse<RatingRefit>> GetById(Guid id);
    }
}
