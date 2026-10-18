using System.Collections.Generic;
using System.Web.Mvc;
using pr7.Models;

namespace pr7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index() => View();

        public ActionResult Create() => View();

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

        public ActionResult List() => View(feedbackList);
    }
}
