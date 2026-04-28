using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class TraineeCoursesController : Controller
    {
        public ITraineeTraineeCoursesRepo traineeCourses { get; }
        public ITraineeRepo trRepo { get; }
        public ICourseRepo crsRepo{ get; }

        public TraineeCoursesController(ITraineeTraineeCoursesRepo trcrs,ICourseRepo cr,ITraineeRepo tr)
        {
            traineeCourses = trcrs;
            trRepo = tr;
            crsRepo = cr;
        }
        // GET: TraineeCoursesController
        public ActionResult Index()
        {
            return View(traineeCourses.GetAll());
        }

        // GET: TraineeCoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View(traineeCourses.GetTraineeCourseById(id));
        }

        // GET: TraineeCoursesController/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(crsRepo.GetAll(), "ID", "Topic");
            ViewBag.TraineeID = new SelectList(trRepo.GetAll(), "ID", "Name");
            return View();
        }

        // POST: TraineeCoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( TraineeCourse trCrs)
        {
            ViewBag.CourseID = new SelectList(crsRepo.GetAll(), "ID", "Name");
            ViewBag.TraineeID = new SelectList(trRepo.GetAll(), "ID", "Name");
            try
            {
                traineeCourses.Create(trCrs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(trCrs);
            }
        }

        // GET: TraineeCoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(traineeCourses.GetTraineeCourseById(id));
        }

        // POST: TraineeCoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TraineeCourse trCrs)
        {
            try
            {
                traineeCourses.Edit(trCrs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(trCrs);
            }
        }

        // GET: TraineeCoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(traineeCourses.GetTraineeCourseById(id));
        }

        // POST: TraineeCoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(TraineeCourse trCrs)
        {
            try
            {
                traineeCourses.Delete(trCrs.TraineeID,trCrs.CourseID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(trCrs);
            }
        }
    }
}
