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
    }
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
}
