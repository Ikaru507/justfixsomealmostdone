using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ViewModel;

namespace TestLibraryProject
{
    public static class SmokeRunner
    {
        public static void Main()
        {
            
            CountriesDB dbc = new CountriesDB();
            var countrieslist = dbc.SelectAll();
            foreach (var b in countrieslist)
                Console.WriteLine($"{b.Id}: {b.CountryName}");
            var u = countrieslist[0];
            u.CountryName += "סוססס";
            dbc.Update(u);
            //var p = new Countries { CountryName = "davidland" };
            //dbc.Insert(p);
            var o = countrieslist[^1];
            dbc.Delete(o);
            int total = dbc.SaveChanges();
            Console.WriteLine($"Inserted: {dbc.InsertedCount}");
            Console.WriteLine($"Updated: {dbc.UpdatedCount}");
            Console.WriteLine($"Deleted: {dbc.DeletedCount}");
            Console.WriteLine($"Total: {total}");



            ContinentsDB dbcas = new ContinentsDB();
            var Continentslist = dbcas.SelectAll();
            foreach (var b in Continentslist)
                Console.WriteLine($"{b.Id}: {b.ContinentName}");
            var us = Continentslist[0];
            us.ContinentName += "lianyland";
            dbcas.Update(us);
            int total123 = dbcas.SaveChanges();
            //var pa = new Continents { ContinentName = "tulala" };
            //dbcas.Insert(pa);
            var op = Continentslist[^1];
            dbcas.Delete(op);
            total123 = dbcas.SaveChanges();
            Console.WriteLine($"Inserted: {dbcas.InsertedCount}");
            Console.WriteLine($"Updated: {dbcas.UpdatedCount}");
            Console.WriteLine($"Deleted: {dbcas.DeletedCount}");
            Console.WriteLine($"Total: {total123}");




            LanguagesDB dbca = new LanguagesDB();
            var Languageslist = dbca.SelectAll();
            foreach (var h in Languageslist)
                Console.WriteLine($"{h.Id}: {h.LanguageName}");
            var s = Languageslist[0];
            s.LanguageName += "xxxx";
            dbca.Update(s);
            //Languages w = new Languages { LanguageName = "yyyy" };
            //dbca.Insert(w);
            var q = Languageslist[^1];
            dbca.Delete(q);
            int totalre = dbca.SaveChanges();
            Console.WriteLine($"Inserted: {dbca.InsertedCount}");
            Console.WriteLine($"Updated: {dbca.UpdatedCount}");
            Console.WriteLine($"Deleted: {dbca.DeletedCount}");
            Console.WriteLine($"Total: {totalre}");





            CategoryDB dba = new CategoryDB();
            var all1 = dba.SelectAll();
            foreach (var c1 in all1)
                Console.WriteLine($"{c1.Id}: {c1.CategoryName}");
            var up = dba.SelectAll()[0];
            up.CategoryName += "interstingcategory";
            dba.Update(up);
            //var ins = new Category { CategoryName = "NewCategotywowoww" , Description = "verycool"};
            //dba.Insert(ins);
            var del = dba.SelectAll()[^1];
            dba.Delete(del);
            int t = dba.SaveChanges();
            Console.WriteLine($"Inserted: {dba.InsertedCount}");
            Console.WriteLine($"Updated: {dba.UpdatedCount}");
            Console.WriteLine($"Deleted: {dba.DeletedCount}");
            Console.WriteLine($"Total: {t}");



            

            AttractionsDB db = new AttractionsDB();
            var list = db.SelectAll();
            foreach (var a in list)
                Console.WriteLine($"{a.Id}: {a.AttractionName}");
            var y = list[0];
            y.AttractionName += "mooooooooooo";
            db.Update(y);
            //var n = new Attractions { AttractionName = "ZiplineWOW" };
            //db.Insert(n);
            var d = list[^1];
            db.Delete(d);
            int total2 = db.SaveChanges();
            Console.WriteLine($"Inserted: {db.InsertedCount}");
            Console.WriteLine($"Updated: {db.UpdatedCount}");
            Console.WriteLine($"Deleted: {db.DeletedCount}");
            Console.WriteLine($"Total: {total2}");




            UserDetailsDB dbe = new UserDetailsDB();
            var lst1 = dbe.SelectAll();
            foreach (var u1 in lst1)
                Console.WriteLine($"{u1.Id}: {u1.UserName}");
            UserDetails upa = dbe.SelectAll()[0];
            //var insa = new UserDetails { UserName = "TestUser", Email = "mail@test.com", Password = "1234", LastLogin = DateTime.Now };
            //dbe.Insert(insa);
            int ta = dbe.SaveChanges();
            upa.UserName += "ikaru";
            dbe.Update(upa);
            ta = dbe.SaveChanges();

            var dele = dbe.SelectAll()[^1];
            dbe.Delete(dele);
            ta = dbe.SaveChanges();
            Console.WriteLine($"Inserted: {dbe.InsertedCount}");
            Console.WriteLine($"Updated:  {dbe.UpdatedCount}");
            Console.WriteLine($"Deleted:  {dbe.DeletedCount}");
            Console.WriteLine($"Total:    {ta}");



            WeatherDB dbaas = new WeatherDB();
            var all12 = dbaas.SelectAll();
            foreach (var c12 in all12)
                Console.WriteLine($"{c12.Id}: {c12.WeatherName}");
            var ups = dbaas.SelectAll()[0];
            ups.WeatherName += "superrainy";
            dbaas.Update(ups);
            //var insas = new Weather { WeatherName = "supercold" };
            //dbaas.Insert(insas);
            var deles = dbaas.SelectAll()[^1];
            dbaas.Delete(deles);
            int tat = dbaas.SaveChanges();
            Console.WriteLine($"Inserted: {dbaas.InsertedCount}");
            Console.WriteLine($"Updated: {dbaas.UpdatedCount}");
            Console.WriteLine($"Deleted: {dbaas.DeletedCount}");
            Console.WriteLine($"Total: {tat}");



        }
    }
}

