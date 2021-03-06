﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMosh1.Models;
using MvcMosh1.ViewModels;

namespace MvcMosh1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie=movie,
                Customers=customers
            };
            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, SortBy = "Name" });
        }
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);

        }

        public ActionResult Index(int? pageIndex , string SortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(SortBy))
            {
                SortBy = "Name";
            }
            return Content(String.Format("pageIndex = {0}&SortBy = {1}", pageIndex, SortBy));

        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,2)}")]
       public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year + " / " + month );
        }
    }
}