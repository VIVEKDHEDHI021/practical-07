using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_7.Models; // added


namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        // GET: Feedback
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (feedback != null)
            {
                feedbackList.Add(feedback);
            }
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}