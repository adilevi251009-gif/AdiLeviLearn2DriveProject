using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class LessonStatusDB : BaseDB
    {
        public LessonStatusList SelectAll()
        {
            string sql = "SELECT * FROM LessonStatus";
            return new LessonStatusList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            LessonStatus ls = entity as LessonStatus;
            if (ls != null)
            {
                base.CreateModel(entity, reader);
                ls.LessonStatusName = reader["LessonStatusName"] != DBNull.Value ? reader["LessonStatusName"].ToString() : string.Empty;
            }
            return ls;
        }

        public override BaseEntity NewEntity()
        {
            return new LessonStatus();
        }

        public static LessonStatus SelectById(int id)
        {
            LessonStatusDB db = new LessonStatusDB();
            LessonStatusList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            LessonStatus ls = entity as LessonStatus;
            if (ls != null)
            {
                cmd.CommandText = "DELETE FROM LessonStatus WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", ls.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            LessonStatus ls = entity as LessonStatus;
            if (ls != null)
            {
                cmd.CommandText = "INSERT INTO LessonStatus (LessonStatusName) VALUES (@lessonStatusName)";
                cmd.Parameters.Add(new OleDbParameter("@lessonStatusName", ls.LessonStatusName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            LessonStatus ls = entity as LessonStatus;
            if (ls != null)
            {
                cmd.CommandText = "UPDATE LessonStatus SET LessonStatusName=@lessonStatusName WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@lessonStatusName", ls.LessonStatusName));
                cmd.Parameters.Add(new OleDbParameter("@id", ls.Id));
            }
        }
    }
}

//using Model;
//using System;
//using System.Collections.Generic;
//using System.Data.OleDb;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ViewModel
//{
//    public class LessonStatusDB:BaseDB
//    {
//        public LessonStatusList SelectAll()
//        {
//            command.CommandText = $"SELECT * FROM LessonStatus";
//            LessonStatusList lessonStatusList = new LessonStatusList(base.Select());
//            return lessonStatusList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            LessonStatus ls = entity as LessonStatus;
//            ls.LessonStatusName = reader["LessonStatusName"].ToString();
//            base.CreateModel(entity);
//            return ls;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new LessonStatus();
//        }

//        static private LessonStatusList list = new LessonStatusList();

//        public static LessonStatus SelectById(int id)
//        {
//            LessonStatusDB db = new LessonStatusDB();
//            list = db.SelectAll();

//            LessonStatus ls = list.Find(item => item.Id == id);
//            return ls;
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            LessonStatus ls = entity as LessonStatus;
//            if (ls != null)
//            {
//                string sqlStr = $"DELETE FROM LessonStatus WHERE Id=@id";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", ls.Id));
//            }
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            LessonStatus ls = entity as LessonStatus;
//            if (ls != null)
//            {

//                string sqlStr = $"INSERT INTO LessonStatus (LessonStatusName) VALUES (@lessonStatusName)";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@lessonStatusName", ls.LessonStatusName));

//                //string sqlStr = $"INSERT INTO LessonStatus (LessonStatus) VALUES (@lessonStatus)";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@lessonStatus", ls.LessonStatusName));

//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            LessonStatus ls = entity as LessonStatus;
//            if (ls != null)
//            {

//                string sqlStr = $"UPDATE LessonStatus SET LessonStatusName=@lessonStatusName WHERE Id=@id";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@lessonStatusName", ls.LessonStatusName));

//                command.Parameters.Add(new OleDbParameter("@id", ls.Id));
//            }
//        }
//    }
//}