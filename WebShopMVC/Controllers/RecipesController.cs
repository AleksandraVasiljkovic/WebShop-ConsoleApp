﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebShop.Bsn;
using WebShop.Model;

namespace WebShopMVC.Controllers
{
    public class RecipesController : Controller
    {
        private IConfiguration configuration;
        public RecipesController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        // GET: RecipesController

        public async Task<IActionResult> Index()
        {
            List<RecipesModel> recipesList = JsonConvert.DeserializeObject<List<RecipesModel>>(await MVCHelper.GetAPI(string.Format("{0}", configuration.GetSection("baseUrl").Value + "api/GetRecipes")));
            return View(recipesList);
        }

        // GET: RecipesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecipesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecipesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecipesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
