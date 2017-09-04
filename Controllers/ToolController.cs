using aspnetcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace aspnetcore.Controllers
{
    public class ToolController : Controller
    {
        // GET: Tool
        public ActionResult Index()
        {
            var model = new ToolViewModel();
            return View(model);
        }

        // POST: Tool
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ToolViewModel model)
        {
            switch (model.ConvertType)
            {
                case ConvertType.UrlEncode:
                    model.Result = WebUtility.UrlEncode(model.Value);
                    break;
                case ConvertType.UrlDecode:
                    model.Result = WebUtility.UrlDecode(model.Value);
                    break;
                case ConvertType.HtmlEncode:
                    model.Result = WebUtility.HtmlEncode(model.Value);
                    break;
                case ConvertType.HtmlDocode:
                    model.Result = WebUtility.HtmlDecode(model.Value);
                    break;
            }
            ModelState.Clear();

            return View(model);
        }

        // GET: Tool/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tool/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tool/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tool/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tool/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tool/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}