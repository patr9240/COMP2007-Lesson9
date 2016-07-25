﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_Lesson9.Models;

namespace COMP2007_Lesson9.Controllers
{
    public class StoreController : Controller
    {
        [Authorize]
        // GET: /Store/
        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Genre> genres = new List<Genre>

            {
                new Genre ("Disco"),
                new Genre ("Jazz"),
                new Genre ("Rock")
            };

            return View(genres);
        }

        // GET: /Store/Browse?genre=Disco
        [AllowAnonymous]
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);

            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            Album album = new Album("Album " + id);

            return View(album);
        }
    }
}