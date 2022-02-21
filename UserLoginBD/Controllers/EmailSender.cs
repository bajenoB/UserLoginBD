using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserLoginBD.Controllers
{
    public class EmailSender : Controller
    {
        // GET: EmailSender
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmailSender/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmailSender/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmailSender/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmailSender/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmailSender/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmailSender/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmailSender/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
