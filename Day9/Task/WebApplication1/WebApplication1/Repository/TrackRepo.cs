using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TrackRepo : ITrackRepo
    {
        public Context myContext { get; }
        public TrackRepo(Context context)
        {
            myContext = context;
        }
        public void Create(Track track)
        {
            try
            {
                myContext.Tracks.Add(track);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Create Course", err.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                Track? track = myContext.Tracks.Find(id);
                if (track!=null)
                {
                    myContext.Tracks.Remove(track);
                    myContext.SaveChanges();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
            }
        }

        public void Edit(Track track)
        {
            try
            {
                myContext.Tracks.Update(track);
                myContext.SaveChanges();
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Update Course", err.Message);
            }
        }

        public IEnumerable<Track> GetAll()
        {
            try
            {
                return myContext.Tracks;
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
                return Enumerable.Empty<Track>();
            }
        }

        public Track GetTrackById(int id)
        {
            try
            {
                return myContext.Tracks.FirstOrDefault(t=>t.ID==id);
            }
            catch (Exception err)
            {
                Console.WriteLine("Cannot Delete Course", err.Message);
                return new Track();
            }
        }
    }
}
