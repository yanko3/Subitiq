namespace Subitiq.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Type { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
