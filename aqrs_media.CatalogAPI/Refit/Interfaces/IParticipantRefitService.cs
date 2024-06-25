using aqrs_media.CatalogAPI.Entities;
using Refit;

namespace aqrs_media.CatalogAPI.Refit.Interfaces
{
    public interface IParticipantRefitService
    {
        [Get("/api/Participant/{id}")]
        Task<ApiResponse<ParticipantRefit>> GetById(Guid id);
    }
}
