using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ViewModel
//{
//    public class ContinentsDB : BaseDB
//    {
//        public ContinentsList SelectAll()
//        {
//            command.CommandText = "SELECT * FROM Continents";
//            return new ContinentsList(Select());
//        }

//        public int Insert(Continents c)
//        {
//            return ExecuteNonQuery(
//                "INSERT INTO Continents (ContinentName) VALUES (?)",
//                new OleDbParameter("@ContinentName", c.ContinentName ?? "")
//            );
//        }

//        public static Continents SelectById(int id)
//        {
//            var db = new ContinentsDB();
//            var list = new ContinentsList(db.Select("SELECT * FROM Continents WHERE id = ?", new OleDbParameter("@id", id)));
//            return list.Count > 0 ? list[0] : null;
//        }
//        public int Update(Continents c)
//        {
//            return ExecuteNonQuery(
//                "UPDATE Continents SET ContinentName = ? WHERE id = ?",
//                new OleDbParameter("@ContinentName", c.ContinentName ?? ""),
//                new OleDbParameter("@id", c.Id)
//            );
//        }

//        public int Delete(int id)
//        {
//            return ExecuteNonQuery(
//                "DELETE FROM Continents WHERE id = ?",
//                new OleDbParameter("@id", id)
//            );
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Continents c = entity as Continents ?? new Continents();

//            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
//                c.Id = (int)reader["id"];

//            if (HasColumn("ContinentName") && !reader.IsDBNull(reader.GetOrdinal("ContinentName")))
//                c.ContinentName = reader["ContinentName"].ToString();

//            return c;
//        }

//        public override BaseEntity NewEntity() => new Continents();
//    }
//}
namespace ViewModel
{
    public class ContinentsDB : BaseDB
    {
        public override BaseEntity NewEntity() => new Continents();

        public ContinentsList SelectAll()
        {
            command.CommandText = "SELECT * FROM Continents";
            return new ContinentsList(Select());
        }

        public Continents SelectById(int id)
        {
            var list = new ContinentsList(Select("SELECT * FROM Continents WHERE id=?", new OleDbParameter("@id", id)));
            return list.Count > 0 ? list[0] : null;
        }

        public void Insert(Continents c)
        {
            inserted.Add(new EntityState(c, (e, cmd) =>
            {
                var x = (Continents)e;
                cmd.CommandText = "INSERT INTO Continents (ContinentName) VALUES (@ContinentName)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ContinentName", x.ContinentName ?? "");
            }));
        }

        public void Update(Continents c)
        {
            updated.Add(new EntityState(c, (e, cmd) =>
            {
                var x = (Continents)e;
                cmd.CommandText = "UPDATE Continents SET ContinentName=? WHERE id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ContinentName", x.ContinentName ?? "");
                cmd.Parameters.AddWithValue("@id", x.Id);
            }));
        }

        public void Delete(Continents c)
        {
            deleted.Add(new EntityState(c, (e, cmd) =>
            {
                cmd.CommandText = "DELETE FROM Continents WHERE id=?";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", e.Id);
            }));
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            var c = (Continents)entity;

            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
                c.Id = Convert.ToInt32(reader["id"]);

            if (HasColumn("ContinentName") && !reader.IsDBNull(reader.GetOrdinal("ContinentName")))
                c.ContinentName = reader["ContinentName"].ToString();

            return c;
        }
    }
}
