﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodShtuphs.Models;
using FoodShtuphs.Queries;


namespace FoodShtuphs.Controllers
{
    public class ReviewsController : Controller
    {

        FoodDb _db = new FoodDb();
        //
        // GET: /Reviews/
        public ActionResult Index()
        {
            var model = _db.Reviews.FindTheLatest(3) ;
            return View(model);
        }

        //
        // GET: /Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
