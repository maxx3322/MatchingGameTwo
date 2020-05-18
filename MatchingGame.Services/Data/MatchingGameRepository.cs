using MatchingGame.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchingGame.Services.Data
{
    public class MatchingGameRepository: IMatchingGameRepository
    {
        private readonly MatchingGameContext _matchingGameContext;
        public MatchingGameRepository(MatchingGameContext matchingGameContext)
        {
            _matchingGameContext = matchingGameContext ?? throw new ArgumentNullException(nameof(matchingGameContext));
        }
        public IEnumerable<Country> GetCountries()
        {
            return _matchingGameContext.Country
                .OrderBy(c => c.CountryName).ToList();
        }

        public IEnumerable<Capital> GetCapitals()
        {
            return _matchingGameContext.Capital
                .OrderBy(c => c.CapitalName).ToList();
        }

        public IEnumerable<Continent> GetContinents()
        {
            return _matchingGameContext.Continent
                .OrderBy(c => c.ContinentName).ToList();
        }

        public Capital GetCapital(int CapitalId)
        {
            return _matchingGameContext.Capital.FirstOrDefault();
        }
        public Capital GetCapitalByName(string CapitalName)
        {
            return _matchingGameContext.Capital.FirstOrDefault();
        }

        public Country GetCountry(int CountryId)
        {
            return _matchingGameContext.Country.FirstOrDefault();
        }

        public Country GetCountryByName(string countryName)
        {
            return _matchingGameContext.Country
                .FirstOrDefault(p => p.CountryName == countryName);
        }

        public Country AddCountry(Country country)
        {


            _matchingGameContext.Country.Add(country);
            return (country);
               
            
        }

        public Continent GetContinent(int ContinentId)
        {
            return _matchingGameContext.Continent.FirstOrDefault();
        }
        public Continent GetContinentByName(string ContinentName)
        {
            return _matchingGameContext.Continent.FirstOrDefault();
        }
    }
}
