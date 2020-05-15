using MatchingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatchingGame.Web.Models
{
    public class ListViewModel
    {
        public IEnumerable<Country> countries { get; set; }
        public IEnumerable<Capital> capitals { get; set; }
        public IEnumerable<Continent> Continents { get; set; }

        
    }
}
