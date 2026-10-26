using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class LessonsDB : BaseDB
    {
        public LessonsList SelectAll()
        {
            string sql = "SELECT * FROM Lessons";
            return new LessonsList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            Lessons l = entity as Lessons;
            if (l != null)
            {
                base.CreateModel(entity, reader);
                l.IdStudent = reader["StudentID"] != DBNull.Value ? StudentDB.SelectById(Convert.ToInt32(reader["StudentID"])) : null;
                l.IdTeacher = reader["TeacherID"] != DBNull.Value ? TeacherDB.SelectById(Convert.ToInt32(reader["TeacherID"])) : null;
                l.LessonDate = reader["LessonDate"] != DBNull.Value ? Convert.ToDateTime(reader["LessonDate"]) : DateTime.MinValue;
                l.LessonTime = reader["LessonTime"] != DBNull.Value ? Convert.ToDateTime(reader["LessonTime"]) : DateTime.MinValue;
                l.Topics = reader["Topics"] != DBNull.Value ? TopicsDB.SelectById(Convert.ToInt32(reader["Topics"])) : null;
                l.Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : string.Empty;
                l.LessonStatus = reader["LessonStatus"] != DBNull.Value ? LessonStatusDB.SelectById(Convert.ToInt32(reader["LessonStatus"])) : null;
            }
            return l;
        }

        public override BaseEntity NewEntity()
        {
            return new Lessons();
        }

        public static Lessons SelectById(int id)
        {
            LessonsDB db = new LessonsDB();
            LessonsList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Lessons l = entity as Lessons;
            if (l != null)
            {
                cmd.CommandText = "DELETE FROM Lessons WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", l.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Lessons l = entity as Lessons;
            if (l != null)
            {
                cmd.CommandText = "INSERT INTO Lessons (StudentID, TeacherID, LessonDate, LessonTime, Topics, Notes, LessonStatus) " +
                                  "VALUES (@idStudent, @idTeacher, @lessonDate, @lessonTime, @topics, @notes, @lessonStatus)";

                cmd.Parameters.Add(new OleDbParameter("@idStudent", l.IdStudent != null ? l.IdStudent.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@idTeacher", l.IdTeacher != null ? l.IdTeacher.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@lessonDate", l.LessonDate));
                cmd.Parameters.Add(new OleDbParameter("@lessonTime", l.LessonTime));
                cmd.Parameters.Add(new OleDbParameter("@topics", l.Topics != null ? l.Topics.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@notes", l.Notes ?? string.Empty));
                cmd.Parameters.Add(new OleDbParameter("@lessonStatus", l.LessonStatus != null ? l.LessonStatus.Id : 0));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Lessons l = entity as Lessons;
            if (l != null)
            {
                cmd.CommandText = "UPDATE Lessons SET StudentID=@idStudent, TeacherID=@idTeacher, " +
                                  "LessonDate=@lessonDate, LessonTime=@lessonTime, " +
                                  "Topics=@topics, Notes=@notes, LessonStatus=@lessonStatus WHERE Id=@id";

                cmd.Parameters.Add(new OleDbParameter("@idStudent", l.IdStudent != null ? l.IdStudent.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@idTeacher", l.IdTeacher != null ? l.IdTeacher.Id : 0));
                //עבור תאריכים 
                cmd.Parameters.Add("@lessonDate", System.Data.OleDb.OleDbType.Date).Value = l.LessonDate;
                cmd.Parameters.Add("@lessonTime", System.Data.OleDb.OleDbType.Date).Value = l.LessonTime;

                cmd.Parameters.Add(new OleDbParameter("@topics", l.Topics != null ? l.Topics.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@notes", l.Notes ?? string.Empty));
                cmd.Parameters.Add(new OleDbParameter("@lessonStatus", l.LessonStatus != null ? l.LessonStatus.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@id", l.Id));
            }
        }
        //cmd.Parameters.Add("@paymentDate", System.Data.OleDb.OleDbType.Date).Value = p.PaymentDate;

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
//    public class LessonsDB:BaseDB
//    {
//        public LessonsList SelectAll()
//        {
//            command.CommandText = $"SELECT * FROM Lessons";
//            LessonsList lessonsList = new LessonsList(base.Select());
//            return lessonsList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Lessons l = entity as Lessons;

//            l.IdStudent = StudentDB.SelectById((int)reader["StudentID"]);
//            l.IdTeacher = TeacherDB.SelectById((int)reader["TeacherID"]);
//            l.LessonDate = Convert.ToDateTime(reader["LessonDate"]);
//            l.LessonTime = Convert.ToDateTime(reader["LessonTime"]);
//            l.Topics = TopicsDB.SelectById((int)reader["Topics"]);
//            l.Notes = reader["Notes"].ToString();
//            l.LessonStatus = LessonStatusDB.SelectById((int)reader["LessonStatus"]);

//            base.CreateModel(entity);
//            return l;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new Lessons();
//        }

//        static private LessonsList list = new LessonsList();

//        public static Lessons SelectById(int id)
//        {
//            LessonsDB db = new LessonsDB();
//            list = db.SelectAll();

//            Lessons l = list.Find(item => item.Id == id);
//            return l;
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Lessons l = entity as Lessons;

//            if (l != null)
//            {

//                string sqlStr = $"DELETE FROM Lessons WHERE Id=@id";


//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", l.Id));
//            }
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Lessons l = entity as Lessons;

//            if (l != null)
//            {
//                string sqlStr = $"INSERT INTO Lessons " +
//                                $"(StudentID, TeacherID, LessonDate, LessonTime, Topics, Notes, LessonStatus) " +
//                                $"VALUES (@idStudent, @idTeacher, @lessonDate, @lessonTime, @topics, @notes, @lessonStatus)";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@idStudent", l.IdStudent.Id));
//                command.Parameters.Add(new OleDbParameter("@idTeacher", l.IdTeacher.Id));
//                command.Parameters.Add(new OleDbParameter("@lessonDate", l.LessonDate));
//                command.Parameters.Add(new OleDbParameter("@lessonTime", l.LessonTime));
//                command.Parameters.Add(new OleDbParameter("@topics", l.Topics.Id));
//                command.Parameters.Add(new OleDbParameter("@notes", l.Notes));
//                command.Parameters.Add(new OleDbParameter("@lessonStatus", l.LessonStatus.Id));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Lessons l = entity as Lessons;

//            if (l != null)
//            {
//                string sqlStr = $"UPDATE Lessons SET " +
//                                $"StudentID=@idStudent, TeacherID=@idTeacher, " +
//                                $"LessonDate=@lessonDate, LessonTime=@lessonTime, " +
//                                $"Topics=@topics, Notes=@notes, LessonStatus=@lessonStatus " +
//                                $"WHERE Id=@id";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@idStudent", l.IdStudent.Id));
//                command.Parameters.Add(new OleDbParameter("@idTeacher", l.IdTeacher.Id));
//                command.Parameters.Add(new OleDbParameter("@lessonDate", l.LessonDate));
//                command.Parameters.Add(new OleDbParameter("@lessonTime", l.LessonTime));
//                command.Parameters.Add(new OleDbParameter("@topics", l.Topics.Id));
//                command.Parameters.Add(new OleDbParameter("@notes", l.Notes));
//                command.Parameters.Add(new OleDbParameter("@lessonStatus", l.LessonStatus.Id));
//                command.Parameters.Add(new OleDbParameter("@id", l.Id));
//            }
//        }
//    }
//}