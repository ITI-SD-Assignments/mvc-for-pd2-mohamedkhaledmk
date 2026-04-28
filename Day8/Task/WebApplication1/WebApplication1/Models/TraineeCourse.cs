namespace WebApplication1.Models
{
    public class TraineeCourse
    {
        public int TraineeID { get; set; }
        public int CourseID { get; set; }
        public float Grade { get; set; }
        public Trainee? Trainee { get; set; }
        public Course? Course { get; set; }
    }
}
