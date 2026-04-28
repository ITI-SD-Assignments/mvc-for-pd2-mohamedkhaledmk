using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class TracksController : Controller
    {
        public ITrackRepo trackRepo{ get; }

        public TracksController(ITrackRepo repo)
        {
            trackRepo = repo;
        }
        // GET: TracksController
        public ActionResult Index()
        {
            return View(trackRepo.GetAll());
        }

        // GET: TracksController/Details/5
        public ActionResult Details(int id)
        {
            return View(trackRepo.GetTrackById(id));
        }

        // GET: TracksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TracksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Track track)
        {
            try
            {
                trackRepo.Create(track);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(track);
            }
        }

        // GET: TracksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(trackRepo.GetTrackById(id));
        }

        // POST: TracksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Track track)
        {
            try
            {
                trackRepo.Edit(track);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(track);
            }
        }

        // GET: TracksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(trackRepo.GetTrackById(id));
        }

        // POST: TracksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Track track)
        {
            try
            {
                trackRepo.Delete(track.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(track);
            }
        }
    }
}
