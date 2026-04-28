using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Context _context;

        public ProductsController(Context context)
        {
            _context = context;
        }

        // GET: Products
        public  IActionResult Index()
        {
            var context = _context.Products.Include(p => p.Customer);
            return View( context.ToList());
        }

        // GET: Products/Details/5
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Products
                .Include(p => p.Customer)
                .FirstOrDefault(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CustID"] = new SelectList(_context.Customers, "ID", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("ID,Name,Image,Price,Description,CustID")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustID"] = new SelectList(_context.Customers, "ID", "Name", product.CustID);
            return View(product);
        }

        // GET: Products/Edit/5
        public  IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CustID"] = new SelectList(_context.Customers, "ID", "Name", product.CustID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Edit(int id, [Bind("ID,Name,Image,Price,Description,CustID")] Product product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustID"] = new SelectList(_context.Customers, "ID", "Name", product.CustID);
            return View(product);
        }

        // GET: Products/Delete/5
        public  IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Products
                .Include(p => p.Customer)
                .FirstOrDefault(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
            var product =  _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
