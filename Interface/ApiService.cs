using Interface;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;

    


namespace Service
{
    public class ApiService : IAPIService
    {
        string uri;
        public HttpClient client;
        public ApiService()
        {
            uri = "https://localhost:7290";
            client = new HttpClient();
        }
        public async Task<CountriesList> GetAllCountries()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");  
        }

        public Task<int> InsertCountry(Countries country)
        {
            return (await client.DeleteAsync(uri + "/api/Select/DeleteCountry/" + id)).IsSuccessStatucCode ? 1 : 0;
        }

        public Task<int> UpdateCountry(Countries country)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteCountry(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<ContinentsList> GetAllContinents()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> InsertContinent(Continents continent)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> UpdateContinent(Continents continent)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteContinent(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<LanguagesList> GetAllLanguages()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> InsertLanguage(Languages language)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> UpdateLanguage(Languages language)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteLanguage(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<WeatherList> GetAllWeather()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> InsertWeather(Weather weather)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> UpdateWeather(Weather weather)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteWeather(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<UserDetailsList> GetAllUserDetails()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> InsertUserDetails(UserDetails userDetails)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> UpdateUserDetails(UserDetails userDetails)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteUserDetails(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<CategoryList> GetAllCategory()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> InsertCategory(Category category)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> UpdateCategory(Category category)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteCategory(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<AttractionsList> GetAllAttractions()
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> InsertAttraction(Attractions attraction)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> UpdateAttraction(Attractions attraction)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }

        public Task<int> DeleteAttraction(int id)
        {
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");
        }
    }
}
