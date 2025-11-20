using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using ViewModel;

namespace TestLibraryProject
{
    public static class SmokeRunner
    {
        public static void Main()
        {
            //RunAll();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Countries:");
            //Console.ResetColor();
            //CountriesDB Countriess = new();
            //CountriesList CountriesList = Countriess.SelectAll();
            //foreach (Countries Countries in CountriesList)
            //    Console.WriteLine(Countries.CountryName);
            //Countries CountriesToUpdate = CountriesList[0];
            //CountriesToUpdate.CountryName += "norwayupdated";
            //Countriess.Update(CountriesToUpdate);
            //int x = Countriess.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");
            //Countries countries = new Countries { CountryName = "davidland" };
            //Countriess.InsertToSQL(countries);
            //Countriess.Delete(CountriesList.Count() - 1);
            //int mb = Countriess.SaveChanges();
            //Console.WriteLine($"{mb} rows were deleted");
            CountriesDB dbc = new CountriesDB();
            var countrieslist = dbc.SelectAll();
            foreach (var b in countrieslist)
                Console.WriteLine($"{b.Id}: {b.CountryName}");
            var u = countrieslist[0];
            u.CountryName += "spaceland";
            dbc.Update(u);
            var p = new Countries { CountryName = "davidland" };
            dbc.Insert(p);
            var o = countrieslist[^1];
            dbc.Delete(o);
            int total = dbc.SaveChanges();
            Console.WriteLine($"Inserted: {dbc.InsertedCount}");
            Console.WriteLine($"Updated: {dbc.UpdatedCount}");
            Console.WriteLine($"Deleted: {dbc.DeletedCount}");
            Console.WriteLine($"Total: {total}");







            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Continents:");
            //Console.ResetColor();
            //ContinentsDB continentss = new();
            //ContinentsList continentsList = continentss.SelectAll();
            //foreach (Continents continents in continentsList)
            //    Console.WriteLine(continents.ContinentName);
            //Continents continentsToUpdate = continentsList[0];
            //continentsToUpdate.ContinentName += "americaupdated";
            //continentss.Update(continentsToUpdate);
            //int y = continentss.SaveChanges();
            //Console.WriteLine($"{y} rows were updated");
            //Continents continentsss = new Continents { ContinentName = "mushroomland" };
            //continentss.InsertToSQL(continentsss);
            //continentss.Delete(continentsList.Count() - 1);
            //int nf = continentss.SaveChanges();
            //Console.WriteLine($"{nf} rows were deleted");




            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Weather:");
            //Console.ResetColor();
            //WeatherDB Weathers = new();
            //WeatherList WeatherList = Weathers.SelectAll();
            //foreach (Weather Weather in WeatherList)
            //    Console.WriteLine(Weather.WeatherName);
            //Weather WeatherToUpdate = WeatherList[0];
            //WeatherToUpdate.WeatherName += "rainyupdated";
            //Weathers.Update(WeatherToUpdate);
            //int b = Weathers.SaveChanges();
            //Console.WriteLine($"{b} rows were updated");
            //Weather Weatherss = new Weather { WeatherName = "reallyreallycold" };
            //Weathers.InsertToSQL(Weatherss);
            //Weathers.Delete(WeatherList.Count() - 1);
            //int ml = Weathers.SaveChanges();
            //Console.WriteLine($"{ml} rows were deleted");






            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Languages:");
            //Console.ResetColor();
            //LanguagesDB Languagess = new();
            //LanguagesList LanguagesList = Languagess.SelectAll();
            //foreach (Languages Languages in LanguagesList)
            //    Console.WriteLine(Languages.LanguageName);
            //Languages LanguagesToUpdate = LanguagesList[0];
            //LanguagesToUpdate.LanguageName += "frenchupdated";
            //Languagess.Update(LanguagesToUpdate);
            //int a = Languagess.SaveChanges();
            //Console.WriteLine($"{a} rows were updated");
            //Languages Languagesss = new Languages { LanguageName = "bober" };
            //Languagess.InsertToSQL(Languagesss);
            //Languagess.Delete(LanguagesList.Count() - 1);
            //int mr = Languagess.SaveChanges();
            //Console.WriteLine($"{mr} rows were deleted");





            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Category:");
            //Console.ResetColor();
            //CategoryDB Categorys = new();
            //CategoryList CategoryList = Categorys.SelectAll();
            //foreach (Category Category in CategoryList)
            //    Console.WriteLine(Category.CategoryName);
            //Category CategoryToUpdate = CategoryList[0];
            //CategoryToUpdate.CategoryName += "adrenalineupdated";
            //Categorys.Update(CategoryToUpdate);
            //int n = Categorys.SaveChanges();
            //Console.WriteLine($"{n} rows were updated");
            //Category Categoryss = new Category { CategoryName = "scaryboo" };
            //Categorys.InsertToSQL(Categoryss);
            //Categorys.Delete(CategoryList.Count() - 1);
            //int mo = Categorys.SaveChanges();
            //Console.WriteLine($"{mo} rows were deleted");
            CategoryDB dba = new CategoryDB();
            var all1 = dba.SelectAll();
            foreach (var c1 in all1)
                Console.WriteLine($"{c1.Id}: {c1.CategoryName}");

            var up = dba.SelectAll()[0];
            up.CategoryName += "_Upd";
            dba.Update(up);

            var ins = new Category { CategoryName = "NewCat", Description = "Desc" };
            dba.Insert(ins);

            var del = dba.SelectAll()[^1];
            dba.Delete(del);

            int t = dba.SaveChanges();
            Console.WriteLine($"Inserted: {dba.InsertedCount}");
            Console.WriteLine($"Updated: {dba.UpdatedCount}");
            Console.WriteLine($"Deleted: {dba.DeletedCount}");
            Console.WriteLine($"Total: {t}");





            ////Console.ForegroundColor = ConsoleColor.Red;
            ////Console.WriteLine("Attractions:");
            ////Console.ResetColor();
            ////AttractionsDB Attractionss = new();
            ////AttractionsList AttractionsList = Attractionss.SelectAll();
            ////foreach (Attractions Attractions in AttractionsList)
            ////    Console.WriteLine(Attractions.AttractionName);
            ////Attractions AttractionsToUpdate = AttractionsList[0];
            ////AttractionsToUpdate.AttractionName += "louvreupdated";
            ////Attractionss.Update(AttractionsToUpdate);
            ////int o = Attractionss.SaveChanges();
            ////Console.WriteLine($"{o} rows were updated");
            ////Attractions Attractionsss = new Attractions { AttractionName = "ziplinewow" };
            ////Attractionss.InsertToSQL(Attractionsss);
            ////Attractionss.Delete(AttractionsList.Count() - 1);
            ////int mp = Attractionss.SaveChanges();
            ////Console.WriteLine($"{mp} rows were deleted");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Attractions:");
            //Console.ResetColor();

            AttractionsDB db = new AttractionsDB();
            var list = db.SelectAll();
            foreach (var a in list)
                Console.WriteLine($"{a.Id}: {a.AttractionName}");
            var y = list[0];
            y.AttractionName += "_Updated";
            db.Update(y);
            var n = new Attractions { AttractionName = "ZiplineWOW" };
            db.Insert(n);
            var d = list[^1];
            db.Delete(d);
            int total2 = db.SaveChanges();
            Console.WriteLine($"Inserted: {db.InsertedCount}");
            Console.WriteLine($"Updated: {db.UpdatedCount}");
            Console.WriteLine($"Deleted: {db.DeletedCount}");
            Console.WriteLine($"Total: {total2}");





            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("UserDetails:");
            //Console.ResetColor();
            //UserDetailsDB UserDetailss = new();
            //UserDetailsList UserDetailsList = UserDetailss.SelectAll();
            //foreach (UserDetails UserDetails in UserDetailsList)
            //    Console.WriteLine(UserDetails.UserName);
            //UserDetails UserDetailsToUpdate = UserDetailsList[0];
            //UserDetailsToUpdate.UserName += "ikaruupdated";
            //UserDetailss.Update(UserDetailsToUpdate);
            //int f = UserDetailss.SaveChanges();
            //Console.WriteLine($"{f} rows were updated");
            //UserDetails UserDetailsss = new UserDetails { UserName = "brocolinew" };
            //UserDetailss.InsertToSQL(UserDetailsss);
            //UserDetailss.Delete(UserDetailsList.Count() - 1);
            //int ma = UserDetailss.SaveChanges();
            //Console.WriteLine($"{ma} rows were deleted");
            UserDetailsDB dbe = new UserDetailsDB();

            var lst1 = dbe.SelectAll();
            foreach (var u1 in lst1)
                Console.WriteLine($"{u1.Id}: {u1.UserName}");

            var upa = dbe.SelectAll()[0];
            upa.UserName += "ikaru";
            dbe.Update(upa);

            var insa = new UserDetails { UserName = "TestUser", Email = "mail@test.com", Password = "1234", LastLogin = DateTime.Now };
            dbe.Insert(insa);

            var dele = dbe.SelectAll()[^1];
            dbe.Delete(dele);

            int ta = dbe.SaveChanges();
            Console.WriteLine($"Inserted: {dbe.InsertedCount}");
            Console.WriteLine($"Updated:  {dbe.UpdatedCount}");
            Console.WriteLine($"Deleted:  {dbe.DeletedCount}");
            Console.WriteLine($"Total:    {ta}");







        }
    }
}

//        public static void RunAll(Action<string> log = null)
//        {
//            log ??= Console.WriteLine;

//            TestContinents(log);
//            TestCountries(log);
//            TestCategory(log);
//            TestLanguages(log);
//            TestWeather(log);
//            TestAttractions(log);
//            TestUserDetails(log);
//            TestUserProfile(log);
//        }

//        private static void TestContinents(Action<string> log)
//        {
//            var db = new ContinentsDB();
//            var list = db.SelectAll();
//            log("--- Continents (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var c = list[0];
//                //c.ContinentName = "Updated Continent";
//                db.Update(c);
//                log("[Continents] updated");
//            }

//            list = db.SelectAll();
//            log("--- Continents (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }

//        private static void TestCountries(Action<string> log)
//        {
//            var db = new CountriesDB();
//            var list = db.SelectAll();
//            log("--- Countries (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var c = list[0];
//                //c.CountryName = "Updated Country";
//                db.Update(c);
//                log("[Countries] updated");
//            }

//            list = db.SelectAll();
//            log("--- Countries (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }

//        private static void TestCategory(Action<string> log)
//        {
//            var db = new CategoryDB();
//            var list = db.SelectAll();
//            log("--- Category (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var c = list[0];
//                //c.CategoryName = "Updated Category";
//                db.Update(c);
//                log("[Category] updated");
//            }

//            list = db.SelectAll();
//            log("--- Category (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }

//        private static void TestLanguages(Action<string> log)
//        {
//            var db = new LanguagesDB();
//            var list = db.SelectAll();
//            log("--- Languages (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var c = list[0];
//                //c.LanguageName = "Updated Language";
//                db.Update(c);
//                //log("[Languages] updated");
//            }

//            list = db.SelectAll();
//            log("--- Languages (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }

//        private static void TestWeather(Action<string> log)
//        {
//            var db = new WeatherDB();
//            var list = db.SelectAll();
//            log("--- Weather (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var c = list[0];
//                c.WeatherName = "Sunny";
//                db.Update(c);
//                //log("[Weather] updated");
//            }

//            list = db.SelectAll();
//            log("--- Weather (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }

//        private static void TestUserDetails(Action<string> log)
//        {
//            var db = new UserDetailsDB();
//            var list = db.SelectAll();
//            log("--- UserDetails (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var u = list[0];
//                //u.UserName = "UpdatedUser";
//                db.Update(u);
//                log("[UserDetails] updated");
//            }

//            list = db.SelectAll();
//            log("--- UserDetails (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }

//        private static void TestUserProfile(Action<string> log)
//        {
//            var db = new UserProfileDB();
//            var list = db.SelectAll();
//            log("--- UserProfile (before) ---");
//            foreach (var x in list) log(x.ToString());

//            if (list.Count > 0)
//            {
//                var u = list[0];
//                u.Bio = "Updated Bio";
//                db.Update(u);
//                log("[UserProfile] updated");
//            }

//            list = db.SelectAll();
//            log("--- UserProfile (after) ---");
//            foreach (var x in list) log(x.ToString());
//        }
//    }
//}
