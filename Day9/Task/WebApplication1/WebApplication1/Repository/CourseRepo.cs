using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class CourseRepo : ICourseRepo
    {
        public Context myContext { get; }
        public CourseRepo(Context context)
        {
            myContext = context;
        }
        public void Create(Course crs)
        {
            try
            {
                myContext.Courses.Add(crs);
                myContext.SaveChanges();
            }catch(Exception err)
            {
                Console.WriteLine("Cannot Create Course", err.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var Crs = myContext.Courses.Find(id);
                myContext.Courses.Remove(Crs);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
            }
        }

        public void Edit(Course crs)
        {
            try
            {
                myContext.Courses.Update(crs);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Update Course", err.Message);
            }
        }

        public IEnumerable<Course> GetAll()
        {
            try
            {
                return myContext.Courses;
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Get All Courses", err.Message);
                return Enumerable.Empty<Course>();
            }
        }

        public Course GetCourseById(int id)
        {
            try
            {
                var Crs = myContext.Courses.Find(id);
                return Crs;
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
                return new Course();
            }
        }
    }
}
