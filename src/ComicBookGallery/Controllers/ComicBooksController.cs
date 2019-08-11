﻿using System;
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
            // ViewBag is an object provided by MVC that allows us to pass data from a controller to a view
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };


            return View();
        } 
    }
}