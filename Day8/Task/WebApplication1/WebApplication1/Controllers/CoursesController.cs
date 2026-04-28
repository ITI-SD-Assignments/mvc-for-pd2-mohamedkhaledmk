using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class CoursesController : Controller
    {
        // GET: CoursesController
        ICourseRepo crsRepo;
        public CoursesController(ICourseRepo cr)
        {
            crsRepo = cr;
        }
        public ActionResult Index()
        {
            return View(crsRepo.GetAll());
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View(crsRepo.GetCourseById(id));
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course crs)
        {
            try
            {
                crsRepo.Create(crs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(crs);
            }
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(crsRepo.GetCourseById(id));
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course crs)
        {
            try
            {
                crsRepo.Edit(crs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(crs);
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(crsRepo.GetCourseById(id));
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Course crs)
        {
            try
            {
                crsRepo.Delete(crs.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(crs);
            }
        }
    }
}
