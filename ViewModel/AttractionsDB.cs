 using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

//namespace ViewModel
//{
//    public class AttractionsDB : BaseDB
//    {
//        public AttractionsList SelectAll()
//        {
//            command.CommandText = "SELECT * FROM Attractions";
//            return new AttractionsList(Select());
//        }

//        public int Insert(Attractions a)
//        {
//            return ExecuteNonQuery(
//                "INSERT INTO Attractions (AttractionName, CountryID, CategoryID, Description) VALUES (?,?,?,?)",
//                new OleDbParameter("@AttractionName", a.AttractionName ?? ""),
//                new OleDbParameter("@CountryID", a.Country?.Id ?? (object)DBNull.Value),
//                new OleDbParameter("@CategoryID", a.Category?.Id ?? (object)DBNull.Value),
//                new OleDbParameter("@Description", (object)a.Description ?? DBNull.Value)
//            );
//        }

//        public int Update(Attractions a)
//        {
//            return ExecuteNonQuery(
//                "UPDATE Attractions SET AttractionName = ?, CountryID = ?, CategoryID = ?, Description = ? WHERE id = ?",
//                new OleDbParameter("@AttractionName", a.AttractionName ?? ""),
//                new OleDbParameter("@CountryID", a.Country?.Id ?? (object)DBNull.Value),
//                new OleDbParameter("@CategoryID", a.Category?.Id ?? (object)DBNull.Value),
//                new OleDbParameter("@Description", (object)a.Description ?? DBNull.Value),
//                new OleDbParameter("@id", a.Id)
//            );
//        }

//        public int UpdateName(int id, string newName)
//        {
//            return ExecuteNonQuery(
//                "UPDATE Attractions SET AttractionName = ? WHERE id = ?",
//                new OleDbParameter("@AttractionName", newName ?? ""),
//                new OleDbParameter("@id", id)
//            );
//        }
//        public static Attractions SelectById(int id)
//        {
//            var db = new AttractionsDB();
//            var list = new AttractionsList(db.Select("SELECT * FROM Attractions WHERE id = ?", new OleDbParameter("@id", id)));
//            return list.Count > 0 ? list[0] : null;
//        }
//        public int Delete(int id)
//        {
//            return ExecuteNonQuery(
//                "DELETE FROM Attractions WHERE id = ?",
//                new OleDbParameter("@id", id)
//            );
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Attractions a = entity as Attractions ?? new Attractions();

//            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
//                a.Id = Convert.ToInt32(reader["id"]);

//            if (HasColumn("AttractionName") && !reader.IsDBNull(reader.GetOrdinal("AttractionName")))
//                a.AttractionName = reader["AttractionName"].ToString();

//            if (HasColumn("Description") && !reader.IsDBNull(reader.GetOrdinal("Description")))
//                a.Description = reader["Description"].ToString();

//            if (HasColumn("CountryID") && !reader.IsDBNull(reader.GetOrdinal("CountryID")))
//                a.Country = new Countries { Id = Convert.ToInt32(reader["CountryID"]) };

//            if (HasColumn("CategoryID") && !reader.IsDBNull(reader.GetOrdinal("CategoryID")))
//                a.Category = new Category { Id = Convert.ToInt32(reader["CategoryID"]) };

//            return a;
//        }

//        public override BaseEntity NewEntity() => new Attractions();
//    }
//}
namespace ViewModel
{
    public class AttractionsDB : BaseDB
    {
        public override BaseEntity NewEntity() => new Attractions();

        public AttractionsList SelectAll()
        {
            command.CommandText = "SELECT * FROM Attractions";
            return new AttractionsList(Select());
        }

        public void Insert(Attractions a)
        {
            inserted.Add(new EntityState(a, (e, cmd) =>
            {
                var x = (Attractions)e;
                cmd.CommandText = "INSERT INTO Attractions (AttractionName, CountryID, CategoryID, Description) VALUES (?,?,?,?)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AttractionName", x.AttractionName ?? "");
                cmd.Parameters.AddWithValue("@CountryID", x.Country?.Id ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CategoryID", x.Category?.Id ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Description", x.Description ?? (object)DBNull.Value);
            }));
        }

        public void Update(Attractions a)
        {
            updated.Add(new EntityState(a, (e, cmd) =>
            {
                var x = (Attractions)e;
                cmd.CommandText = "UPDATE Attractions SET AttractionName=?, CountryID=?, CategoryID=?, Description=? WHERE id=?";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AttractionName", x.AttractionName ?? "");
                cmd.Parameters.AddWithValue("@CountryID", x.Country?.Id ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CategoryID", x.Category?.Id ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Description", x.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", x.Id);
            }));
        }

        public void Delete(Attractions a)
        {
            deleted.Add(new EntityState(a, (e, cmd) =>
            {
                cmd.CommandText = "DELETE FROM Attractions WHERE id=?";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", e.Id);
            }));
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Attractions a = (Attractions)entity;

            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
                a.Id = Convert.ToInt32(reader["id"]);

            if (HasColumn("AttractionName") && !reader.IsDBNull(reader.GetOrdinal("AttractionName")))
                a.AttractionName = reader["AttractionName"].ToString();

            if (HasColumn("Description") && !reader.IsDBNull(reader.GetOrdinal("Description")))
                a.Description = reader["Description"].ToString();

            return a;
        }
    }
}