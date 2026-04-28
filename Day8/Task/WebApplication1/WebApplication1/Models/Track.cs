namespace WebApplication1.Models
{
    public class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Trainee>? Trainees {get;set;}
    }
}
