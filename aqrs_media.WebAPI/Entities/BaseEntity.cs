using System.ComponentModel.DataAnnotations.Schema;

namespace aqrs_media.WebAPI.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("inactivated_date")]
        public DateTime? InactivatedDate { get; set; }
    }
}
