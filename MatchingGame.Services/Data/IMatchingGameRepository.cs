using MatchingGame.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace MatchingGame.Services.Data
{
    public interface IMatchingGameRepository
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int CountryId);
        Country GetCountryByName(string CountryName);
        Country AddCountry(Country country);

        IEnumerable<Continent> GetContinents();

        Continent GetContinent(int ContinentId);
        Continent GetContinentByName(string ContinentName);
        IEnumerable<Capital> GetCapitals();
        Capital GetCapital(int CapitalId);
        Capital GetCapitalByName(string CapitalName);
    }
}
