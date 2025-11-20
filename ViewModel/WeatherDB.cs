using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ViewModel
//{
//    public class WeatherDB : BaseDB
//    {
//        public WeatherList SelectAll()
//        {
//            command.CommandText = "SELECT * FROM Weather";
//            return new WeatherList(Select());
//        }

//        public int Insert(Weather w)
//        {
//            return ExecuteNonQuery(
//                "INSERT INTO Weather (WeatherName) VALUES (?)",
//                new OleDbParameter("@WeatherName", w.WeatherName ?? "")
//            );
//        }

//        public int Update(Weather w)
//        {
//            return ExecuteNonQuery(
//                "UPDATE Weather SET WeatherName = ? WHERE id = ?",
//                new OleDbParameter("@WeatherName", w.WeatherName ?? ""),
//                new OleDbParameter("@id", w.Id)
//            );
//        }

//        public int Delete(int id)
//        {
//            return ExecuteNonQuery(
//                "DELETE FROM Weather WHERE id = ?",
//                new OleDbParameter("@id", id)
//            );
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Weather w = entity as Weather ?? new Weather();

//            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
//                w.Id = (int)reader["id"];

//            if (HasColumn("WeatherName") && !reader.IsDBNull(reader.GetOrdinal("WeatherName")))
//                w.WeatherName = reader["WeatherName"].ToString();

//            return w;
//        }
//        public static Weather SelectById(int id)
//        {
//            var db = new WeatherDB();
//            var list = new WeatherList(db.Select("SELECT * FROM Weather WHERE id = ?", new OleDbParameter("@id", id)));
//            return list.Count > 0 ? list[0] : null;
//        }
//        public override BaseEntity NewEntity() => new Weather();
//    }
//}

namespace ViewModel
{
    public class WeatherDB : BaseDB
    {
        // שליפת כל רשומות מזג האוויר
        public WeatherList SelectAll()
        {
            command.CommandText = "SELECT * FROM Weather";
            return new WeatherList(Select());
        }

        // שליפה לפי מזהה
        public static Weather SelectById(int id)
        {
            var db = new WeatherDB();
            var list = new WeatherList(db.Select("SELECT * FROM Weather WHERE id = ?", new OleDbParameter("@id", id)));
            return list.Count > 0 ? list[0] : null;
        }

        // הוספת רשומת מזג אוויר חדשה
        public int InsertToSQL(Weather w)
        {
            int rowsAffected = ExecuteNonQuery(
                "INSERT INTO Weather (WeatherName) VALUES (?)",
                new OleDbParameter("@WeatherName", w.WeatherName ?? "")
            );

            // אם נוספה רשומה בהצלחה, נביא את ה־ID החדש
            if (rowsAffected > 0)
            {
                command.CommandText = "SELECT @@IDENTITY";
                object idObj = command.ExecuteScalar();
                if (idObj != null && int.TryParse(idObj.ToString(), out int newId))
                    w.Id = newId;
            }

            return rowsAffected;
        }

        // עדכון רשומת מזג אוויר קיימת
        public int Update(Weather w)
        {
            return ExecuteNonQuery(
                "UPDATE Weather SET WeatherName = ? WHERE id = ?",
                new OleDbParameter("@WeatherName", w.WeatherName ?? ""),
                new OleDbParameter("@id", w.Id)
            );
        }

        // מחיקת רשומה לפי מזהה
        public int Delete(int id)
        {
            return ExecuteNonQuery(
                "DELETE FROM Weather WHERE id = ?",
                new OleDbParameter("@id", id)
            );
        }

        // המרת רשומה מאקסס לאובייקט
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Weather w = entity as Weather ?? new Weather();

            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
                w.Id = Convert.ToInt32(reader["id"]);

            if (HasColumn("WeatherName") && !reader.IsDBNull(reader.GetOrdinal("WeatherName")))
                w.WeatherName = reader["WeatherName"].ToString();

            return w;
        }

        // יצירת ישות חדשה
        public override BaseEntity NewEntity() => new Weather();
    }
}
