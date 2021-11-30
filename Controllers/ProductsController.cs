﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebApp.Models;

namespace DemoWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}