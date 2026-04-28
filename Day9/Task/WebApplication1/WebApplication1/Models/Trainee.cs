using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace WebApplication1.Models
{
    public enum Gender { Male,Female}
    public class Trainee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public DateTime Birthdate { get; set; }
        [ForeignKey("Trk")]
        public int TrackID { get; set; }
        public Track Trk { get; set; }
    }
}