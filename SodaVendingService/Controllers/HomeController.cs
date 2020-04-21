using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SodaVendingService.Models;

namespace SodaVendingService.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Soda> _sodas =
            JsonConvert.DeserializeObject<List<Soda>>(System.IO.File.ReadAllText("wwwroot/inventory.json"));

        public IActionResult Index()
        {
            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = new VendingSession()
            };

            return View(indexViewModel);
        }

        public IActionResult Insert1Money(VendingSession session)
        {
            session.InsertMoney(1);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };

            return View("Index", indexViewModel);
        }
        
        public IActionResult Insert2Money(VendingSession session)
        {
            session.InsertMoney(2);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };

            return View("Index", indexViewModel);
        }
        
        public IActionResult Insert5Money(VendingSession session)
        {
            session.InsertMoney(5);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };

            return View("Index", indexViewModel);
        }
        
        public IActionResult Insert10Money(VendingSession session)
        {
            session.InsertMoney(10);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };

            return View("Index", indexViewModel);
        }
        
        public IActionResult Insert50Money(VendingSession session)
        {
            session.InsertMoney(50);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };

            return View("Index", indexViewModel);
        }
        
        public IActionResult Insert100Money(VendingSession session)
        {
            session.InsertMoney(100);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };

            return View("Index", indexViewModel);
        }

        public IActionResult DispenseSoda(VendingSession session)
        {
            session.DispenseSoda(session.SelectedSodaId, _sodas);

            var indexViewModel = new IndexViewModel
            {
                Sodas = _sodas,
                VendingSession = session
            };
            return View("Index", indexViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}