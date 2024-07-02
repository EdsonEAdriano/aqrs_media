namespace aqrs_media.MediaAPI.DTOs
{
    public class BaseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
