using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.Controllers
{
    public class StatisticsController1cs : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";
            ViewBag.v1 = context.Skills.Count(); 
            ViewBag.v2=context.Skills.Sum(x=>x.SkillValue);
            ViewBag.v3 = context.Skills.Where(x => x.SkillValue >= 70).Count();
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6=context.Experiences.Where(x=>x.SubTitle=="Developer").Count();



            return View();
        }
    }
}
