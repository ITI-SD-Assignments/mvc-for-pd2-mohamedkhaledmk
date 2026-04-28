using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface ITrackRepo
    {
        IEnumerable<Track> GetAll();
        Track GetTrackById(int id);
        void Create(Track crs);
        void Edit(Track crs);
        void Delete(int id);
    }
}
