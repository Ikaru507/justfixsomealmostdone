using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ViewModel
//{
//    public class CountriesDB : BaseDB
//    {
//        public CountriesList SelectAll()
//        {
//            command.CommandText = "SELECT * FROM Countries";
//            return new CountriesList(Select());
//        }

//        public int InsertToSQL(Countries c)
//        {
//            return ExecuteNonQuery(
//                "INSERT INTO Countries (CountryName, ContinentID) VALUES (?,?)",
//                new OleDbParameter("@CountryName", c.CountryName ?? ""),
//                new OleDbParameter("@ContinentID", c.Continent?.Id ?? (object)DBNull.Value)
//            );
//        }
//        public static Countries SelectById(int id)
//        {
//            var db = new CountriesDB();
//            var list = new CountriesList(db.Select("SELECT * FROM Countries WHERE id = ?", new OleDbParameter("@id", id)));
//            return list.Count > 0 ? list[0] : null;
//        }
//        public int Update(Countries c)
//        {
//            return ExecuteNonQuery(
//                "UPDATE Countries SET CountryName = ?, ContinentID = ? WHERE id = ?",
//                new OleDbParameter("@CountryName", c.CountryName ?? ""),
//                new OleDbParameter("@ContinentID", c.Continent?.Id ?? (object)DBNull.Value),
//                new OleDbParameter("@id", c.Id)
//            );
//        }

//        public int Delete(int id)
//        {
//            return ExecuteNonQuery(
//                "DELETE FROM Countries WHERE id = ?",
//                new OleDbParameter("@id", id)
//            );
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Countries c = entity as Countries ?? new Countries();

//            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
//                c.Id = (int)reader["id"];

//            if (HasColumn("CountryName") && !reader.IsDBNull(reader.GetOrdinal("CountryName")))
//                c.CountryName = reader["CountryName"].ToString();

//            if (HasColumn("ContinentID") && !reader.IsDBNull(reader.GetOrdinal("ContinentID")))
//                c.Continent = new Continents { Id = (int)reader["ContinentID"] };

//            return c;
//        }

//        public override BaseEntity NewEntity() => new Countries();
//    }
//}
namespace ViewModel
{
    public class CountriesDB : BaseDB
    {
        public override BaseEntity NewEntity() => new Countries();

        public CountriesList SelectAll()
        {
            command.CommandText = "SELECT * FROM Countries";
            return new CountriesList(Select());
        }

        public Countries SelectById(int id)
        {
            var list = new CountriesList(Select("SELECT * FROM Countries WHERE id=?", new OleDbParameter("@id", id)));
            return list.Count > 0 ? list[0] : null;
        }

        public void Insert(Countries c)
        {
            inserted.Add(new EntityState(c, (e, cmd) =>
            {
                var x = (Countries)e;
                cmd.CommandText = "INSERT INTO Countries (CountryName, ContinentID) VALUES (?,?)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CountryName", x.CountryName ?? "");
                cmd.Parameters.AddWithValue("@ContinentID", x.Continent?.Id ?? (object)DBNull.Value);
            }));
        }

        public void Update(Countries c)
        {
            updated.Add(new EntityState(c, (e, cmd) =>
            {
                var x = (Countries)e;
                cmd.CommandText = "UPDATE Countries SET CountryName=?, ContinentID=? WHERE id=?";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CountryName", x.CountryName ?? "");
                cmd.Parameters.AddWithValue("@ContinentID", x.Continent?.Id ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", x.Id);
            }));
        }

        public void Delete(Countries c)
        {
            deleted.Add(new EntityState(c, (e, cmd) =>
            {
                cmd.CommandText = "DELETE FROM Countries WHERE id=?";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", e.Id);
            }));
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            var c = (Countries)entity;

            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
                c.Id = Convert.ToInt32(reader["id"]);

            if (HasColumn("CountryName") && !reader.IsDBNull(reader.GetOrdinal("CountryName")))
                c.CountryName = reader["CountryName"].ToString();

            if (HasColumn("ContinentID") && !reader.IsDBNull(reader.GetOrdinal("ContinentID")))
                c.Continent = new Continents { Id = Convert.ToInt32(reader["ContinentID"]) };

            return c;
        }
    }
}
