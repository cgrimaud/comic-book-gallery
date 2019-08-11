using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    // controller classes need to be public otherwise mvc won't be able to find or use them
    public class ComicBooksController : Controller
    {
        // add action method: every public method on a controller is an action method. responsible for
        // performing any actions that are requred to prepare a response for a request
        // action methods need to be public 
        // action method typically returns one of the MVC action result types

        public ActionResult Detail()
        {
            return View();
        } 
    }
}