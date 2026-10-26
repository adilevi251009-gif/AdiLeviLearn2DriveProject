using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class StudentDB : PersonDB
    {
        public StudentList SelectAll()
        {
            string sql = "SELECT Person.Id, Person.FirstName, Person.LastName, Person.Email, Person.PhoneNumber, " +
                         "Person.Pass, Student.StartDate, Student.BirthDate, Student.Status, Student.IdTeacher " +
                         "FROM (Person INNER JOIN Student ON Person.Id = Student.Id)";
            return new StudentList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            Student s = entity as Student;
            if (s != null)
            {
                base.CreateModel(entity, reader);
                s.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.MinValue;
                s.BirthDate = reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : DateTime.MinValue;

                int statusId = reader["Status"] != DBNull.Value ? Convert.ToInt32(reader["Status"]) : 0;
                int teacherId = reader["IdTeacher"] != DBNull.Value ? Convert.ToInt32(reader["IdTeacher"]) : 0;

                s.Status = StatusDB.SelectById(statusId);
                s.IdTeacher = TeacherDB.SelectById(teacherId);
            }
            return s;
        }

        public override BaseEntity NewEntity()
        {
            return new Student();
        }

        public static Student SelectById(int id)
        {
            StudentDB db = new StudentDB();
            StudentList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Student s = entity as Student;
            if (s != null)
            {
                cmd.CommandText = "INSERT INTO Student (Id, StartDate, BirthDate, Status, IdTeacher) " +
                                  "VALUES (@id, @startDate, @birthDate, @status, @idTeacher)";

                cmd.Parameters.Add(new OleDbParameter("@id", s.Id));
                // עבור תאריכים
                cmd.Parameters.Add("@startDate", System.Data.OleDb.OleDbType.Date).Value = s.StartDate;
                cmd.Parameters.Add("@birthDate", System.Data.OleDb.OleDbType.Date).Value = s.BirthDate;

                cmd.Parameters.Add(new OleDbParameter("@status", s.Status != null ? s.Status.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@idTeacher", s.IdTeacher != null ? s.IdTeacher.Id : 0));
            }
        }


        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Student s = entity as Student;
            if (s != null)
            {
                cmd.CommandText = "UPDATE Student SET StartDate=@startDate, BirthDate=@birthDate, " +
                                  "Status=@status, IdTeacher=@idTeacher WHERE Id=@id";

                // עבור תאריכים
                cmd.Parameters.Add("@startDate", System.Data.OleDb.OleDbType.Date).Value = s.StartDate;
                cmd.Parameters.Add("@birthDate", System.Data.OleDb.OleDbType.Date).Value = s.BirthDate;

                cmd.Parameters.Add(new OleDbParameter("@status", s.Status != null ? s.Status.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@idTeacher", s.IdTeacher != null ? s.IdTeacher.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@id", s.Id));
            }
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Student s = entity as Student;
            if (s != null)
            {

                cmd.CommandText = "UPDATE Student SET Status=@status WHERE Id=@id";


                cmd.Parameters.Add(new OleDbParameter("@status", 2));

                cmd.Parameters.Add(new OleDbParameter("@id", s.Id));

                //cmd.CommandText = "DELETE FROM Student WHERE Id=@id";
                //cmd.Parameters.Add(new OleDbParameter("@id", s.Id));
            }
        }

        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        public override void Update(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
            }
        }

        public override void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));

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
//    public class StudentDB:PersonDB
//    {
//        public StudentList SelectAll()
//        {
//            command.CommandText = $"SELECT Person.Id, Person.FirstName, Person.LastName, Person.Email, Person.PhoneNumber, " +
//                                  $"Person.Pass, Student.StartDate, Student.BirthDate, Student.Status, Student.IdTeacher " +
//                                  $"FROM (Person INNER JOIN Student ON Person.Id = Student.Id)";

//            StudentList sList = new StudentList(base.Select());
//            return sList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Student s = entity as Student;

//            s.StartDate = Convert.ToDateTime(reader["StartDate"]);
//            s.BirthDate = Convert.ToDateTime(reader["BirthDate"]);

//            int statusId = (int)reader["Status"];
//            int teacherId = (int)reader["IdTeacher"];

//            base.CreateModel(entity);

//            s.Status = StatusDB.SelectById(statusId);
//            s.IdTeacher = TeacherDB.SelectById(teacherId);

//            return s;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new Student();
//        }

//        static private StudentList list = new StudentList();

//        public static Student SelectById(int id)
//        {
//            StudentDB db = new StudentDB();
//            list = db.SelectAll();

//            Student s = list.Find(item => item.Id == id);
//            return s;
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Student s = entity as Student;

//            if (s != null)
//            {

//                string sqlStr = $"INSERT INTO Student (Id, StartDate, BirthDate, Status, IdTeacher) " + 
//                                $"VALUES (@id, @startDate, @birthDate, @status, @idTeacher)";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@id", s.Id));
//                command.Parameters.Add(new OleDbParameter("@startDate", s.StartDate));
//                command.Parameters.Add(new OleDbParameter("@birthDate", s.BirthDate));
//                command.Parameters.Add(new OleDbParameter("@status", s.Status.Id));
//                command.Parameters.Add(new OleDbParameter("@idTeacher", s.IdTeacher.Id));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Student s = entity as Student;

//            if (s != null)
//            {
//                string sqlStr = $"UPDATE Student SET StartDate=@startDate, BirthDate=@birthDate, " +
//                                $"Status=@status, IdTeacher=@idTeacher WHERE Id=@id"; 

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@startDate", s.StartDate));
//                command.Parameters.Add(new OleDbParameter("@birthDate", s.BirthDate));
//                command.Parameters.Add(new OleDbParameter("@status", s.Status.Id));
//                command.Parameters.Add(new OleDbParameter("@idTeacher", s.IdTeacher.Id));
//                command.Parameters.Add(new OleDbParameter("@id", s.Id));
//            }
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Student s = entity as Student;

//            if (s != null)
//            {

//                string sqlStr = $"DELETE FROM Student WHERE Id=@id"; 

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", s.Id));
//            }
//        }


//        public override void Insert(BaseEntity entity)
//        {
//            BaseEntity reqEntity = this.NewEntity();

//            if (entity != null && entity.GetType() == reqEntity.GetType())
//            {
//                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
//                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
//            }
//        }

//        public override void Update(BaseEntity entity)
//        {
//            BaseEntity reqEntity = this.NewEntity();

//            if (entity != null && entity.GetType() == reqEntity.GetType())
//            {
//                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
//                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
//            }
//        }

//        public override void Delete(BaseEntity entity)
//        {
//            BaseEntity reqEntity = this.NewEntity();

//            if (entity != null && entity.GetType() == reqEntity.GetType())
//            {
//                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
//                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
//            }
//        }
//    }
//}
