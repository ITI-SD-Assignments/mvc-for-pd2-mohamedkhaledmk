using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TraineeRepo:ITraineeRepo
    {
        public Context myContext { get; }

        public TraineeRepo(Context context) 
        {
            myContext = context;
        }

        public IEnumerable<Trainee> GetAll()
        {
            try
            {
                return myContext.Trainees;
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Get All Trainees", err.Message);
                return Enumerable.Empty<Trainee>();
            }
        }

        public Trainee GetTraineeById(int id)
        {
            try
            {
                return myContext.Trainees.Find(id);
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Get Trainee By Id", err.Message);
                return new Trainee();
            }
        }

        public void Create(Trainee trainee)
        {
            try
            {
                myContext.Trainees.Add(trainee);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Add Trainee", err.Message);   
            }
        }

        public void Edit(Trainee trainee)
        {
            try
            {
                myContext.Trainees.Update(trainee);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Edit Course", err.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Trainee trainee = myContext.Trainees.Find(id);
                myContext.Trainees.Remove(trainee);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
            }
        }
    }
}
