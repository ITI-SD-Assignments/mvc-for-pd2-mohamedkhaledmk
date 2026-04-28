using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class TraineesController : Controller
    {
        public ITraineeRepo repo { get; }
        public ITrackRepo track { get; }
        public TraineesController(ITraineeRepo trcrrepo,ITrackRepo trackRepo)
        {
            repo = trcrrepo;
            track = trackRepo;
        }
        // GET: TraineeController
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetTraineeById(id));
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            ViewBag.TrackID = new SelectList(track.GetAll().ToList(), "ID", "Name");
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee tr)
        {
            try
            {
                repo.Create(tr);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tr);
            }
        }

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repo.GetTraineeById(id));
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Trainee tr)
        {
            try
            {
                repo.Edit(tr);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tr);
            }
        }

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repo.GetTraineeById(id));
        }

        // POST: TraineeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Trainee tr)
        {
            try
            {
                repo.Delete(tr.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tr);
            }
        }
    }
}
