using CryptoMarketplace.Models;
using CryptoMarketplace.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using X.PagedList;

namespace CryptoMarketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICoinRepo _coinRepo;

        public HomeController(ILogger<HomeController> logger, ICoinRepo coinRepo)
        {
            _logger = logger;
            _coinRepo = coinRepo;
        }

        public ActionResult Index(string? symbol, int? pageNumber)
        {
            ViewData["symbol"] = symbol;

            var coins = _coinRepo.GetAllCoinsFiltered(symbol);
       
            int pageSize = 10;
            int nrOfPage = (pageNumber ?? 1);
            return View(coins.ToPagedList(nrOfPage, pageSize));
        }

    }
}