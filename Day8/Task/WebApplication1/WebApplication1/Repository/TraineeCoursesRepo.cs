using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TraineeCoursesRepo : ITraineeTraineeCoursesRepo
    {
        public Context myContext { get; }
        public TraineeCoursesRepo(Context context) { myContext = context; }
        public void Create(TraineeCourse traineeCourse)
        {
            try
            {
                myContext.TraineeCoursess.Add(traineeCourse);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Create Trainee Course", err.Message);
            }
        }

        public void Delete(int TraineeID,int CourseID)
        {
            try
            {
                var traineeCrs = myContext.TraineeCoursess.Find(new {TraineeID,CourseID});
                myContext.TraineeCoursess.Remove(traineeCrs);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
            }
        }

        public void Edit(TraineeCourse crs)
        {
            try
            {
                myContext.TraineeCoursess.Update(crs);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Update Course", err.Message);
            }
        }

        public IEnumerable<TraineeCourse> GetAll()
        {
            try
            {
                return myContext.TraineeCoursess;
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
                return Enumerable.Empty<TraineeCourse>();
            }
        }

        public TraineeCourse GetTraineeCourseById(int id)
        {
            try
            {
                return myContext.TraineeCoursess.Find(id);
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Find traineeCourses by ID ", err.Message);
                return new TraineeCourse();
            }
        }
    }
}
