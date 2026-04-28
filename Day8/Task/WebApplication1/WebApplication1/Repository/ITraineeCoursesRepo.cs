using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface ITraineeTraineeCoursesRepo
    {
        IEnumerable<TraineeCourse> GetAll();
        TraineeCourse GetTraineeCourseById(int id);
        void Create(TraineeCourse crs);
        void Edit(TraineeCourse crs);
        void Delete(int id,int id2);
    }
}
