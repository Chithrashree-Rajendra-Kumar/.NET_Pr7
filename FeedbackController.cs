using System.Collections.Generic;
using System.Web.Mvc;
using pr7.Models;

namespace pr7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        // GET: Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("List");
            }

            return View(feedback);
        }

        // GET: Feedback/List
        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}