﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PorfolioCore.Context;
using PorfolioCore.Entities;

namespace PorfolioCore.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult PortfolioList()
        {
            var values=context.Portfolios.Include(x=>x.Category).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio() 
        {
            var values = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
