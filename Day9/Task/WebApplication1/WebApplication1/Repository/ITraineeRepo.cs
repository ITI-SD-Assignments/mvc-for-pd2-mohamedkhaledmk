using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface ITraineeRepo
    {
        IEnumerable<Trainee> GetAll();
        Trainee GetTraineeById(int id);
        void Create(Trainee crs);
        void Edit(Trainee crs);
        void Delete(int id);
    }
}
