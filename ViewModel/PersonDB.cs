using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class PersonDB : BaseDB
    {
        public PersonList SelectAll()
        {
            string sql = "SELECT * FROM Person";
            return new PersonList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            Person p = entity as Person;
            if (p != null)
            {
                base.CreateModel(entity, reader);
                p.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
                p.LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
                p.PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : string.Empty;
                p.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                p.Pass = reader["Pass"] != DBNull.Value ? reader["Pass"].ToString() : string.Empty;
            }
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new Person();
        }

        public static Person SelectById(int id)
        {
            PersonDB db = new PersonDB();
            PersonList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person p = entity as Person;
            if (p != null)
            {
                cmd.CommandText = "DELETE FROM Person WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person p = entity as Person;
            if (p != null)
            {
                cmd.CommandText = "INSERT INTO Person (FirstName, LastName, Email, PhoneNumber, Pass) VALUES (@firstName, @lastName, @email, @phoneNumber, @pass)";
                cmd.Parameters.Add(new OleDbParameter("@firstName", p.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lastName", p.LastName));
                cmd.Parameters.Add(new OleDbParameter("@email", p.Email));
                cmd.Parameters.Add(new OleDbParameter("@phoneNumber", p.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@pass", p.Pass));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person p = entity as Person;
            if (p != null)
            {
                cmd.CommandText = "UPDATE Person SET FirstName=@firstName, LastName=@lastName, Email=@email, PhoneNumber=@phoneNumber, Pass=@pass WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@firstName", p.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lastName", p.LastName));
                cmd.Parameters.Add(new OleDbParameter("@email", p.Email));
                cmd.Parameters.Add(new OleDbParameter("@phoneNumber", p.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@pass", p.Pass));
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
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
//    public class PersonDB: BaseDB
//    {
//        public PersonList SelectAll()
//        {
//            command.CommandText = $"SELECT * FROM Person";
//            PersonList personList = new PersonList(base.Select());
//            return personList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Person p = entity as Person;

//            p.FirstName = reader["FirstName"].ToString();
//            p.LastName = reader["LastName"].ToString();
//            p.PhoneNumber = reader["PhoneNumber"].ToString();
//            p.Email = reader["Email"].ToString();
//            p.Pass = reader["Pass"].ToString();

//            base.CreateModel(entity);
//            return p;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new Person();
//        }

//        static private PersonList list = new PersonList();

//        public static Person SelectById(int id)
//        {
//            PersonDB db = new PersonDB();
//            list = db.SelectAll();

//            Person p = list.Find(item => item.Id == id);
//            return p;
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Person p = entity as Person;

//            if (p != null)
//            {
//                string sqlStr = $"DELETE FROM Person WHERE Id=@id";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", p.Id));
//            }
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Person p = entity as Person;

//            if (p != null)
//            {
//                string sqlStr = $"INSERT INTO Person (FirstName, LastName, Email, PhoneNumber, Pass) VALUES (@firstName, @lastName, @email, @phoneNumber, @pass)";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@firstName", p.FirstName));
//                command.Parameters.Add(new OleDbParameter("@lastName", p.LastName));
//                command.Parameters.Add(new OleDbParameter("@email", p.Email));
//                command.Parameters.Add(new OleDbParameter("@phoneNumber", p.PhoneNumber));
//                command.Parameters.Add(new OleDbParameter("@pass", p.Pass));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Person p = entity as Person;

//            if (p != null)
//            {
//                string sqlStr = $"UPDATE Person SET FirstName=@firstName, LastName=@lastName, Email=@email, PhoneNumber=@phoneNumber, Pass=@pass WHERE Id=@id";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@firstName", p.FirstName));
//                command.Parameters.Add(new OleDbParameter("@lastName", p.LastName));
//                command.Parameters.Add(new OleDbParameter("@email", p.Email));

//                command.Parameters.Add(new OleDbParameter("@phoneNumber", p.PhoneNumber));


//                command.Parameters.Add(new OleDbParameter("@pass", p.Pass));
//                command.Parameters.Add(new OleDbParameter("@id", p.Id));
//            }
//        }
//    }
//}
