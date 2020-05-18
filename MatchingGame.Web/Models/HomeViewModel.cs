using MatchingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchingGame.Web.Models
{
    public class HomeViewModel
    {
        public List<Country> countries { get; set; }
        public List<Capital> capitals { get; set; }

        //public IEnumerable<Continent> Continents { get; set; }

        public string CountryName { get; set; }

        public Country SelectedCountry { get; set; }
        public Capital SelectedCapital { get; set; }
    }
}
