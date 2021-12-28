using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication3.Controllers
{
    public class SotrController : Controller
    {
        private WWWContext db;
        public SotrController(WWWContext context)
        {
            db = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public async Task<IActionResult> laba3()
        //{
        //    return View(await db.Sotrudnikis.ToListAsync());
        //}
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(Sotrudniki sotrudniki)
        //{
        //    db.Sotrudnikis.Add(sotrudniki);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("laba3");
        //}
        public IActionResult laba3() //работает
        {
            SotrudnikiViewModel sotrudnikiViewModel = new SotrudnikiViewModel();
            sotrudnikiViewModel.ListSotr = db.Sotrudnikis.ToList();
            sotrudnikiViewModel.Sotrudniki = new Sotrudniki();
            //return View(db.Sotrudnikis.ToList());
            return View(sotrudnikiViewModel);
        }

        [HttpPost][ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind("F,I,O,Dolzhnost,Tel")] Sotrudniki Sotrudniki)
        {
            if (ModelState.IsValid)
            {
                db.Add(Sotrudniki);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(laba3));
            }
            return View();
        }
    }
}
