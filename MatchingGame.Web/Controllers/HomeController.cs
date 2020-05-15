using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MatchingGame.Web.Models;
using MatchingGame.Services.Data;
using MatchingGame.Models;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace MatchingGame.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMatchingGameRepository _matchingGameRepository;

        public HomeController(IMatchingGameRepository matchingGameRepository)
        {
            _matchingGameRepository = matchingGameRepository ??
                 throw new ArgumentNullException(nameof(matchingGameRepository));
        }


        [HttpGet]
        public ActionResult Index()
        {


            //Continue to play around with different view models until we can return all three repositories. 

            ViewBag.Message = "Welcome to the Capital Game!";
            HomeViewModel mymodel = new HomeViewModel();
            mymodel.countries = _matchingGameRepository.GetCountries();
            mymodel.capitals = _matchingGameRepository.GetCapitals();
            mymodel.Continents = _matchingGameRepository.GetContinents();
            return View(mymodel);
        }

        [HttpPost]
        // ask Arron about this.  [ActionName]  vs redirect to action vs correct way to do this
        [ActionName("Index")]
        public ActionResult IndexPost()
        {

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
