using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class PaymentMethodsDB : BaseDB
    {
        public PaymentMethodsList SelectAll()
        {
            string sql = "SELECT * FROM PaymentMethods";
            return new PaymentMethodsList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            PaymentMethods pm = entity as PaymentMethods;
            if (pm != null)
            {
                base.CreateModel(entity, reader);
                pm.MethodName = reader["MethodName"] != DBNull.Value ? reader["MethodName"].ToString() : string.Empty;
            }
            return pm;
        }

        public override BaseEntity NewEntity()
        {
            return new PaymentMethods();
        }

        public static PaymentMethods SelectById(int id)
        {
            PaymentMethodsDB db = new PaymentMethodsDB();
            PaymentMethodsList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PaymentMethods pm = entity as PaymentMethods;
            if (pm != null)
            {
                cmd.CommandText = "DELETE FROM PaymentMethods WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", pm.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PaymentMethods pm = entity as PaymentMethods;
            if (pm != null)
            {
                cmd.CommandText = "INSERT INTO PaymentMethods (MethodName) VALUES (@methodName)";
                cmd.Parameters.Add(new OleDbParameter("@methodName", pm.MethodName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PaymentMethods pm = entity as PaymentMethods;
            if (pm != null)
            {
                cmd.CommandText = "UPDATE PaymentMethods SET MethodName=@methodName WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@methodName", pm.MethodName));
                cmd.Parameters.Add(new OleDbParameter("@id", pm.Id));
            }
        }
    }
}//using Model;
//using System;
//using System.Collections.Generic;
//using System.Data.OleDb;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ViewModel
//{
//    public class PaymentMethodsDB:BaseDB
//    {
//        public PaymentMethodsList SelectAll()
//        {
//            command.CommandText = $"SELECT * FROM PaymentMethods";
//            PaymentMethodsList paymentMethodsList = new PaymentMethodsList(base.Select());
//            return paymentMethodsList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            PaymentMethods pm = entity as PaymentMethods;
//            pm.MethodName = reader["MethodName"].ToString();
//            base.CreateModel(entity);
//            return pm;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new PaymentMethods();
//        }

//        static private PaymentMethodsList list = new PaymentMethodsList();

//        public static PaymentMethods SelectById(int id)
//        {
//            PaymentMethodsDB db = new PaymentMethodsDB();
//            list = db.SelectAll();

//            PaymentMethods pm = list.Find(item => item.Id == id);
//            return pm;
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            PaymentMethods pm = entity as PaymentMethods;

//            if (pm != null)
//            {

//                string sqlStr = $"DELETE FROM PaymentMethods WHERE Id=@id"; 

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", pm.Id));
//            }
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            PaymentMethods pm = entity as PaymentMethods;

//            if (pm != null)
//            {
//                string sqlStr = $"INSERT INTO PaymentMethods (MethodName) VALUES (@methodName)";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@methodName", pm.MethodName));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            PaymentMethods pm = entity as PaymentMethods;

//            if (pm != null)
//            {

//                string sqlStr = $"UPDATE PaymentMethods SET MethodName=@methodName WHERE Id=@id"; 

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@methodName", pm.MethodName));
//                command.Parameters.Add(new OleDbParameter("@id", pm.Id));
//            }
//        }
//    }
//}
