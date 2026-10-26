using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class ManagerDB : PersonDB
    {
        public ManagerList SelectAll()
        {
            string sql = "SELECT Person.Id, Person.FirstName, Person.LastName, Person.Email, Person.PhoneNumber, Person.Pass " +
                         "FROM (Person INNER JOIN Manager ON Person.Id = Manager.ID)";
            return new ManagerList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            Manager m = entity as Manager;
            if (m != null)
            {
                base.CreateModel(entity, reader);
            }
            return m;
        }

        public override BaseEntity NewEntity()
        {
            return new Manager();
        }

        public static Manager SelectById(int id)
        {
            ManagerDB db = new ManagerDB();
            ManagerList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Manager m = entity as Manager;
            if (m != null)
            {
                cmd.CommandText = "INSERT INTO Manager (ID) VALUES (@id)";
                cmd.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Manager m = entity as Manager;
            if (m != null)
            {
                cmd.CommandText = "UPDATE Manager SET ID=@id WHERE ID=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Manager m = entity as Manager;
            if (m != null)
            {
                cmd.CommandText = "DELETE FROM Manager WHERE ID=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", m.Id));
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
                deleted.Add(new ChangeEntity(base.CreateDeletedSQL, entity));
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
//    public class ManagerDB:PersonDB
//    {
//        public ManagerList SelectAll()
//        {
//            command.CommandText = $"SELECT Person.Id, Person.FirstName, Person.LastName, Person.Email, Person.PhoneNumber, " +
//                                  $"Person.Pass " +
//                                  $"FROM (Person INNER JOIN Manager ON Person.Id = Manager.ID)";

//            ManagerList mList = new ManagerList(base.Select());
//            return mList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Manager m = entity as Manager;

//            base.CreateModel(entity);
//            return m;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new Manager();
//        }

//        static private ManagerList list = new ManagerList();

//        public static Manager SelectById(int id)
//        {
//            ManagerDB db = new ManagerDB();
//            list = db.SelectAll();

//            Manager m = list.Find(item => item.Id == id);
//            return m;
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Manager m = entity as Manager;

//            if (m != null)
//            {
//                string sqlStr = $"INSERT INTO Manager (ID) " +
//                                $"VALUES (@id)";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@id", m.Id));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Manager m = entity as Manager;

//            if (m != null)
//            {
//                string sqlStr = $"UPDATE Manager SET ID=@id WHERE ID=@id";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@id", m.Id));
//            }
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Manager m = entity as Manager;

//            if (m != null)
//            {
//                string sqlStr = $"DELETE FROM Manager WHERE ID=@id";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", m.Id));
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
