using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchingGame.Services.Data;
using MatchingGame.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace MatchingGame.Web.Controllers
{
    public class ListController : Controller
    {

        private readonly IMatchingGameRepository _matchingGameRepository;

        public ListController(IMatchingGameRepository matchingGameRepository)
        {
            _matchingGameRepository = matchingGameRepository ??
                 throw new ArgumentNullException(nameof(matchingGameRepository));
                 }

            [HttpGet]
        public ActionResult Index()
        {


            //Continue to play around with different view models until we can return all three repositories. 

            ViewBag.Message = "Welcome to the Capital Game!";
            ListViewModel listModel = new ListViewModel();
            listModel.countries = _matchingGameRepository.GetCountries();
            listModel.capitals = _matchingGameRepository.GetCapitals();
            listModel.Continents = _matchingGameRepository.GetContinents();
            
            return View(listModel);
        }

        public ActionResult PostIndex()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}