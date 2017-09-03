using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace aspnetcore.Controllers
{
    public class ToolController : Controller
    {
        // GET: Tool
        public ActionResult Index()
        {
            ViewBag.value = string.Empty;
            ViewBag.type = string.Empty;
            return View();
        }

        // GET: Tool/Details/5
        public ActionResult Convert(string value, string type)
        {
            ViewBag.value = type;
            ViewBag.type = type;

            switch (type)
            {
                case "urlencode":
                    ViewBag.result = WebUtility.UrlEncode(value);
                    break;
                case "urldecode":
                    ViewBag.result = WebUtility.UrlDecode(value);
                    break;
                case "htmlencode":
                    ViewBag.result = WebUtility.HtmlEncode(value);
                    break;
                case "htmldecode":
                    ViewBag.result = WebUtility.HtmlDecode(value);
                    break;
            }

            return View("Index");
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