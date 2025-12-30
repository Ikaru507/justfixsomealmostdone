
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
            uri = "http://localhost:5038";
            client = new HttpClient();
        }
        public async Task<CountriesList> GetAllCountries()
        {
                                              
            return await client.GetFromJsonAsync<CountriesList>(uri + "/api/Select/CountriesSelector");  
        }

        public async Task<int> DeleteCountry(int id)
        {
            return (await client.DeleteAsync(uri+ $"/api/Select/DeleteCountry/{ id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateCountry(Countries country)
        {
            return (await client.PutAsJsonAsync<Countries>(uri + "/api/Insert/UpdateCountry/", country)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertCountry(Countries country)
        {
            return (await client.PostAsJsonAsync<Countries>(uri + "/api/Insert/InsertCountry/", country)).IsSuccessStatusCode ? 1 : 0;
        }




        public async Task<ContinentsList> GetAllContinents()
        {
            return await client.GetFromJsonAsync<ContinentsList>(uri + "/api/Select/ContinentsSelector");
        }

        public async Task<int> DeleteContinent(int id)
        {
            return (await client.DeleteAsync(uri+ $"/api/Select/DeleteContinent/{ id}")).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateContinent(Continents Continent)
        {
            return (await client.PutAsJsonAsync<Continents>(uri + "/api/Insert/UpdateContinent/", Continent)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertContinent(Continents Continent)
        {
            return (await client.PostAsJsonAsync<Continents>(uri + "/api/Insert/InsertContinent/", Continent)).IsSuccessStatusCode ? 1 : 0;
        }





        public async Task<LanguagesList> GetAllLanguages()
        {
            return await client.GetFromJsonAsync<LanguagesList>(uri + "/api/Select/LanguagesSelector");
        }

        public async Task<int> DeleteLanguage(int id)
        {
            return (await client.DeleteAsync(uri+ "/api/Select/DeleteLanguage/"+ id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateLanguage(Languages Language)
        {
            return (await client.PutAsJsonAsync<Languages>(uri + "/api/Insert/UpdateLanguage/", Language)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertLanguage(Languages Language)
        {
            return (await client.PostAsJsonAsync<Languages>(uri + "/api/Insert/InsertLanguage/", Language)).IsSuccessStatusCode ? 1 : 0;
        }






        public async Task<WeatherList> GetAllWeather()
        {
            return await client.GetFromJsonAsync<WeatherList>(uri + "/api/Select/LanguagesSelector");
        }

        public async Task<int> DeleteWeather(int id)
        {
            return (await client.DeleteAsync(uri+ "/api/Select/DeleteWeather/"+ id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateWeather(Weather weather)
        {
            return (await client.PutAsJsonAsync<Weather>(uri + "/api/Insert/UpdateWeather/", weather)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertWeather(Weather weather)
        {
            return (await client.PostAsJsonAsync<Weather>(uri + "/api/Insert/InsertWeather/", weather)).IsSuccessStatusCode ? 1 : 0;
        }






        public async Task<UserDetailsList> GetAllUserDetails()
        {
            return await client.GetFromJsonAsync<UserDetailsList>(uri + "/api/Select/UserDetailsSelector");
        }

        public async Task<int> DeleteUserDetails(int id)
        {
            return (await client.DeleteAsync(uri+ "/api/Select/DeleteUserDetails/"+ id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateUserDetails(UserDetails userDetails)
        {
            return (await client.PutAsJsonAsync<UserDetails>(uri + "/api/Insert/UpdateUserDetails/", userDetails)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertUserDetails(UserDetails userDetails)
        {
            return (await client.PostAsJsonAsync<UserDetails>(uri + "/api/Insert/InsertUserDetails/", userDetails)).IsSuccessStatusCode ? 1 : 0;
        }







        public async Task<CategoryList> GetAllCategory()
        {
            return await client.GetFromJsonAsync<CategoryList>(uri + "/api/Select/CategorySelector");
        }

        public async Task<int> DeleteCategory(int id)
        {
            return (await client.DeleteAsync(uri+ "/api/Select/DeleteCategory/"+ id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateCategory(Category category)
        {
            return (await client.PutAsJsonAsync<Category>(uri + "/api/Insert/UpdateCategory/", category)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertCategory(Category category)
        {
            return (await client.PostAsJsonAsync<Category>(uri + "/api/Insert/InsertCategory/", category)).IsSuccessStatusCode ? 1 : 0;
        }






        public async Task<AttractionsList> GetAllAttractions()
        {
            return await client.GetFromJsonAsync<AttractionsList>(uri + "/api/Select/AttractionsSelector");
        }

        public async Task<int> DeleteAttraction(int id)
        {
            return (await client.DeleteAsync(uri+ "/api/Select/DeleteAttraction/"+ id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAttraction(Attractions Attraction)
        {
            return (await client.PutAsJsonAsync<Attractions>(uri + "/api/Insert/UpdateAttraction/", Attraction)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAttraction(Attractions Attraction)
        {
            return (await client.PostAsJsonAsync<Attractions>(uri + "/api/Insert/InsertAttraction/", Attraction)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
