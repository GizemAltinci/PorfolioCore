using Microsoft.AspNetCore.Mvc;
using PorfolioCore.Context;

namespace PorfolioCore.ViewComponents
{
    public class _DefaulProjectComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Portfolios.ToList();
            return View(values);
        }
    }
}
