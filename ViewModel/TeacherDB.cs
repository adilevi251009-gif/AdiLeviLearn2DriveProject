using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class TeacherDB : PersonDB
    {
        public TeacherList SelectAll()
        {
            string sql = "SELECT Person.Id, Person.FirstName, Person.LastName, Person.Email, " +
                         "Person.PhoneNumber, Person.Pass, Teacher.City, Teacher.CarType, Teacher.PricePerLesson, Teacher.IdManager, Teacher.Status " +
                         "FROM (Person INNER JOIN Teacher ON Person.Id = Teacher.Id)";
            return new TeacherList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            Teacher t = entity as Teacher;
            if (t != null)
            {
                base.CreateModel(entity, reader);

                int cityId = reader["City"] != DBNull.Value ? Convert.ToInt32(reader["City"]) : 0;
                int carTypeId = reader["CarType"] != DBNull.Value ? Convert.ToInt32(reader["CarType"]) : 0;
                int managerId = reader["IdManager"] != DBNull.Value ? Convert.ToInt32(reader["IdManager"]) : 0;
                int statusId = reader["Status"] != DBNull.Value ? Convert.ToInt32(reader["Status"]) : 0;

                t.City = CityDB.SelectById(cityId);
                t.CarType = CarTypeDB.SelectById(carTypeId);
                t.PricePerLesson = reader["PricePerLesson"] != DBNull.Value ? Convert.ToInt32(reader["PricePerLesson"]) : 0;
                t.IdManager = ManagerDB.SelectById(managerId);
                t.Status = StatusDB.SelectById(statusId);
            }
            return t;
        }

        public override BaseEntity NewEntity()
        {
            return new Teacher();
        }

        public static Teacher SelectById(int id)
        {
            TeacherDB db = new TeacherDB();
            TeacherList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Teacher t = entity as Teacher;
            if (t != null)
            {
                cmd.CommandText = "INSERT INTO Teacher (Id, City, CarType, PricePerLesson, IdManager, Status) " +
                                  "VALUES (@id, @city, @carType, @pricePerLesson, @idManager, @status)";

                cmd.Parameters.Add(new OleDbParameter("@id", t.Id));
                cmd.Parameters.Add(new OleDbParameter("@city", t.City != null ? t.City.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@carType", t.CarType != null ? t.CarType.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@pricePerLesson", t.PricePerLesson));
                cmd.Parameters.Add(new OleDbParameter("@idManager", t.IdManager != null ? t.IdManager.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@status", t.Status != null ? t.Status.Id : 0));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Teacher t = entity as Teacher;
            if (t != null)
            {
                cmd.CommandText = "UPDATE Teacher SET City=@city, CarType=@carType, " +
                                  "PricePerLesson=@pricePerLesson, IdManager=@idManager, Status=@status WHERE Id=@id";

                cmd.Parameters.Add(new OleDbParameter("@city", t.City != null ? t.City.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@carType", t.CarType != null ? t.CarType.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@pricePerLesson", t.PricePerLesson));
                cmd.Parameters.Add(new OleDbParameter("@idManager", t.IdManager != null ? t.IdManager.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@status", t.Status != null ? t.Status.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@id", t.Id));
            }
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Teacher t = entity as Teacher;
            if (t != null)
            {
                cmd.CommandText = "UPDATE Teacher SET Status=@status WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@status", 2));
                cmd.Parameters.Add(new OleDbParameter("@id", t.Id));
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
//    public class TeacherDB:PersonDB
//    {
//        public TeacherList SelectAll()
//        {
//            command.CommandText = $"SELECT Person.Id, Person.FirstName, Person.LastName, Person.Email, " +
//                                  $"Person.PhoneNumber, Person.Pass, Teacher.City, Teacher.CarType, Teacher.PricePerLesson, Teacher.IdManager " +
//                                  $"FROM (Person INNER JOIN Teacher ON Person.Id = Teacher.Id)";
//            TeacherList tList = new TeacherList(base.Select());
//            return tList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Teacher t = entity as Teacher;

//            t.City = CityDB.SelectById((int)reader["City"]);
//            t.CarType = CarTypeDB.SelectById((int)reader["CarType"]);
//            t.PricePerLesson = Convert.ToInt32(reader["PricePerLesson"]);
//            t.IdManager = ManagerDB.SelectById((int)reader["IdManager"]);

//            base.CreateModel(entity);
//            return t;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new Teacher();
//        }

//        static private TeacherList list = new TeacherList();

//        public static Teacher SelectById(int id)
//        {
//            TeacherDB db = new TeacherDB();
//            list = db.SelectAll();

//            Teacher t = list.Find(item => item.Id == id);
//            return t;
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Teacher t = entity as Teacher;

//            if (t != null)
//            {

//                string sqlStr = $"INSERT INTO Teacher (Id, City, CarType, PricePerLesson, IdManager) " + 
//                                $"VALUES (@id, @city, @carType, @pricePerLesson, @idManager)";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@id", t.Id));
//                command.Parameters.Add(new OleDbParameter("@city", t.City.Id));
//                command.Parameters.Add(new OleDbParameter("@carType", t.CarType.Id));
//                command.Parameters.Add(new OleDbParameter("@pricePerLesson", t.PricePerLesson));
//                command.Parameters.Add(new OleDbParameter("@idManager", t.IdManager.Id));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Teacher t = entity as Teacher;

//            if (t != null)
//            {
//                string sqlStr = $"UPDATE Teacher SET City=@city, CarType=@carType, " +
//                                $"PricePerLesson=@pricePerLesson, IdManager=@idManager WHERE Id=@id"; 

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@city", t.City.Id));
//                command.Parameters.Add(new OleDbParameter("@carType", t.CarType.Id));
//                command.Parameters.Add(new OleDbParameter("@pricePerLesson", t.PricePerLesson));
//                command.Parameters.Add(new OleDbParameter("@idManager", t.IdManager.Id));
//                command.Parameters.Add(new OleDbParameter("@id", t.Id));
//            }
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Teacher t = entity as Teacher;

//            if (t != null)
//            {

//                string sqlStr = $"DELETE FROM Teacher WHERE Id=@id"; 

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", t.Id));
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

