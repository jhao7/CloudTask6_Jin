using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudProgrammingTask6.Controllers
{

    /// <summary>
    /// The controller for the home page.
    /// </summary>
    public class HomeController : Controller
    {

        /// <summary>
        /// The function for displaying the home page
        /// </summary>
        /// /// <returns>
        /// Returns a view of home page.
        /// </returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The function for displaying the about page
        /// </summary>
        /// /// <returns>
        /// <para>Returns a view of about page.</para>
        /// <para>Returns a floating message.</para>
        /// </returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// The function for displaying the contact page
        /// </summary>
        /// /// <returns>
        /// <para>Returns a view of contact page.</para>
        /// <para>Returns a floating message.</para>
        /// </returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}