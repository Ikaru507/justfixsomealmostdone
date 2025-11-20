using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ViewModel
//{
//    public class LanguagesDB : BaseDB
//    {
//        public LanguagesList SelectAll()
//        {
//            command.CommandText = "SELECT * FROM Languages";
//            return new LanguagesList(Select());
//        }

//        public int Insert(Languages l)
//        {
//            return ExecuteNonQuery(
//                "INSERT INTO Languages (LanguageName) VALUES (?)",
//                new OleDbParameter("@LanguageName", l.LanguageName ?? "")
//            );
//        }
//        public static Languages SelectById(int id)
//        {
//            var db = new LanguagesDB();
//            var list = new LanguagesList(db.Select("SELECT * FROM Languages WHERE id = ?", new OleDbParameter("@id", id)));
//            return list.Count > 0 ? list[0] : null;
//        }
//        public int Update(Languages l)
//        {
//            return ExecuteNonQuery(
//                "UPDATE Languages SET LanguageName = ? WHERE id = ?",
//                new OleDbParameter("@LanguageName", l.LanguageName ?? ""),
//                new OleDbParameter("@id", l.Id)
//            );
//        }

//        public int Delete(int id)
//        {
//            return ExecuteNonQuery(
//                "DELETE FROM Languages WHERE id = ?",
//                new OleDbParameter("@id", id)
//            );
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Languages l = entity as Languages ?? new Languages();

//            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
//                l.Id = (int)reader["id"];

//            if (HasColumn("LanguageName") && !reader.IsDBNull(reader.GetOrdinal("LanguageName")))
//                l.LanguageName = reader["LanguageName"].ToString();

//            return l;
//        }

//        public override BaseEntity NewEntity() => new Languages();
//    }
//}
namespace ViewModel
{
    public class LanguagesDB : BaseDB
    {
        // שליפת כל השפות
        public LanguagesList SelectAll()
        {
            command.CommandText = "SELECT * FROM Languages";
            return new LanguagesList(Select());
        }

        // שליפה לפי מזהה
        public static Languages SelectById(int id)
        {
            var db = new LanguagesDB();
            var list = new LanguagesList(db.Select("SELECT * FROM Languages WHERE id = ?", new OleDbParameter("@id", id)));
            return list.Count > 0 ? list[0] : null;
        }

        // הוספת שפה חדשה
        public int InsertToSQL(Languages l)
        {
            int rowsAffected = ExecuteNonQuery(
                "INSERT INTO Languages (LanguageName) VALUES (?)",
                new OleDbParameter("@LanguageName", l.LanguageName ?? "")
            );

            // אם נוספה רשומה בהצלחה, נקבל את ה-ID החדש
            if (rowsAffected > 0)
            {
                command.CommandText = "SELECT @@IDENTITY";
                object idObj = command.ExecuteScalar();
                if (idObj != null && int.TryParse(idObj.ToString(), out int newId))
                    l.Id = newId;
            }

            return rowsAffected;
        }

        // עדכון שפה קיימת
        public int Update(Languages l)
        {
            return ExecuteNonQuery(
                "UPDATE Languages SET LanguageName = ? WHERE id = ?",
                new OleDbParameter("@LanguageName", l.LanguageName ?? ""),
                new OleDbParameter("@id", l.Id)
            );
        }

        // מחיקת שפה לפי מזהה
        public int Delete(int id)
        {
            return ExecuteNonQuery(
                "DELETE FROM Languages WHERE id = ?",
                new OleDbParameter("@id", id)
            );
        }

        // המרת רשומת DB לאובייקט Languages
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Languages l = entity as Languages ?? new Languages();

            if (HasColumn("id") && !reader.IsDBNull(reader.GetOrdinal("id")))
                l.Id = Convert.ToInt32(reader["id"]);

            if (HasColumn("LanguageName") && !reader.IsDBNull(reader.GetOrdinal("LanguageName")))
                l.LanguageName = reader["LanguageName"].ToString();

            return l;
        }

        // יצירת ישות חדשה
        public override BaseEntity NewEntity() => new Languages();
    }
}
