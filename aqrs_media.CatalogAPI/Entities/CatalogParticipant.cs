using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aqrs_media.CatalogAPI.Entities
{
    [Table("t_catalog_participant")]
    public class CatalogParticipant
    {
        [Key]
        public int Id { get; set; }
        public Guid CatalogId { get; set; }
        public Guid ParticipantId { get; set; }
    }
}
