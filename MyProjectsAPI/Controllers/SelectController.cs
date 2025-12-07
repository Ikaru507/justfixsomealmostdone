using Microsoft.AspNetCore.Mvc;
using ViewModel;
using Model;

namespace MyProjectsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        [ActionName("CountriesSelector")]

        public CountriesList SelectAllCountries()
        {
           CountriesDB countriesDB = new CountriesDB();
            CountriesList countriesList = countriesDB.SelectAll();
            return countriesList;
        }

        [HttpGet]
        [ActionName("ContinentsSelector")]

        public ContinentsList SelectAllContinents()
        {
            ContinentsDB continentsDB = new ContinentsDB();
            ContinentsList continentsList = continentsDB.SelectAll();
            return continentsList;
        }

        [HttpGet]
        [ActionName("LanguagesSelector")]

        public LanguagesList SelectAllLanguages()
        {
            LanguagesDB languagesDB = new LanguagesDB();
            LanguagesList languagesList = languagesDB.SelectAll();
            return languagesList;
        }

        [HttpGet]
        [ActionName("WeatherSelector")]

        public WeatherList SelectAllWeather()
        {
            WeatherDB weatherDB = new WeatherDB();
            WeatherList weatherList = weatherDB.SelectAll();
            return weatherList;
        }

        [HttpGet]
        [ActionName("UserDetailsSelector")]

        public UserDetailsList SelectAllUserDetails()
        {
            UserDetailsDB userDetailsDB = new UserDetailsDB();
            UserDetailsList userDetailsList = userDetailsDB.SelectAll();
            return userDetailsList;
        }

        [HttpGet]
        [ActionName("CategorySelector")]

        public CategoryList SelectAllCategory()
        {
            CategoryDB categoryDB = new CategoryDB();
            CategoryList categoryList = categoryDB.SelectAll();
            return categoryList;
        }

        [HttpGet]
        [ActionName("AttractionsSelector")]

        public AttractionsList SelectAllAttractions()
        {
            AttractionsDB attractionsDB = new AttractionsDB();
            AttractionsList attractionsList = attractionsDB.SelectAll();
            return attractionsList;
        }
    }
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
}
