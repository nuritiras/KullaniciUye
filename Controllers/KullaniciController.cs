using Microsoft.AspNetCore.Mvc;
using KullaniciUye.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC.KullaniciUye.Controllers
{
    public class KullaniciController : Controller
    {
        private static List<Kullanici> kullanicilar = new List<Kullanici>();

        // GET: Kullanici
        public IActionResult Index()
        {
            return View(kullanicilar);
        }

        // GET: Kullanici/Details/5
        public IActionResult Details(int id)
        {
            var kullanici = kullanicilar.FirstOrDefault(k => k.Id == id);
            if (kullanici == null)
            {
                return NotFound();
            }
            return View(kullanici);
        }

        // GET: Kullanici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kullanici/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                kullanicilar.Add(kullanici);
                return RedirectToAction(nameof(Index));
            }
            return View(kullanici);
        }

        // GET: Kullanici/Edit/5
        public IActionResult Edit(int id)
        {
            var kullanici = kullanicilar.FirstOrDefault(k => k.Id == id);
            if (kullanici == null)
            {
                return NotFound();
            }
            return View(kullanici);
        }

        // POST: Kullanici/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Kullanici kullanici)
        {
            if (id != kullanici.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingKullanici = kullanicilar.FirstOrDefault(k => k.Id == id);
                if (existingKullanici != null)
                {
                    existingKullanici.Ad = kullanici.Ad;
                    existingKullanici.Email = kullanici.Email;
                    // Update other fields as necessary
                }
                return RedirectToAction(nameof(Index));
            }
            return View(kullanici);
        }

        // GET: Kullanici/Delete/5
        public IActionResult Delete(int id)
        {
            var kullanici = kullanicilar.FirstOrDefault(k => k.Id == id);
            if (kullanici == null)
            {
                return NotFound();
            }
            return View(kullanici);
        }

        // POST: Kullanici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var kullanici = kullanicilar.FirstOrDefault(k => k.Id == id);
            if (kullanici != null)
            {
                kullanicilar.Remove(kullanici);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}