using System.Web.Mvc;

namespace KeepFaith.Controllers
{
    public class KeepFaithController : Controller
    {
        //
        // GET: /KeepFaith/

        public ActionResult KeepFaith()
        {
            return View();
        }

        //
        // GET: /KeepFaith/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /KeepFaith/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /KeepFaith/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /KeepFaith/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /KeepFaith/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /KeepFaith/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /KeepFaith/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
