using Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Authorize]
    public class HomeController1 : Controller
    {
        private readonly studentdbcontextcs _context;

       /* public object Entitystate { get; private set; }*/

        public HomeController1(studentdbcontextcs context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View(_context.students.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(student std)
        {
            _context.students.Add(std);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var res = _context.students.Where(x=>x.id==id).FirstOrDefault();
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(int id,student std)
        {
            _context.Entry(std).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            /*var ids = ;*/
            _context.students.Remove(_context.students.Where(x => x.id == id).FirstOrDefault());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
