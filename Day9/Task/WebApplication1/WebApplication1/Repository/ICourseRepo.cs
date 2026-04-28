using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetAll();
        Course GetCourseById(int id);
        void Create(Course crs);
        void Edit(Course crs);
        void Delete(int id);
    }
}
