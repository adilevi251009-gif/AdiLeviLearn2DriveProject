using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace ViewModel
{
    public class PaymentsDB : BaseDB
    {
        public PaymentsList SelectAll()
        {
            string sql = "SELECT * FROM Payments";
            return new PaymentsList(base.Select(sql));
        }

        protected override BaseEntity CreateModel(BaseEntity entity, OleDbDataReader reader)
        {
            Payments p = entity as Payments;
            if (p != null)
            {
                base.CreateModel(entity, reader);

                int studentId = reader["StudentID"] != DBNull.Value ? Convert.ToInt32(reader["StudentID"]) : 0;
                int paymentMethodId = reader["PaymentMethod"] != DBNull.Value ? Convert.ToInt32(reader["PaymentMethod"]) : 0;

                p.IdStudent = StudentDB.SelectById(studentId);
                p.Amount = reader["Amount"] != DBNull.Value ? Convert.ToInt32(reader["Amount"]) : 0;
                p.PaymentDate = reader["PaymentDate"] != DBNull.Value ? Convert.ToDateTime(reader["PaymentDate"]) : DateTime.MinValue;
                p.PaymentMethod = PaymentMethodsDB.SelectById(paymentMethodId);
            }
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new Payments();
        }

        public static Payments SelectById(int id)
        {
            PaymentsDB db = new PaymentsDB();
            PaymentsList list = db.SelectAll();
            return list.Find(item => item.Id == id);
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Payments p = entity as Payments;
            if (p != null)
            {
                cmd.CommandText = "DELETE FROM Payments WHERE Id=@id";
                cmd.Parameters.Add(new OleDbParameter("@id", p.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Payments p = entity as Payments;
            if (p != null)
            {
                cmd.CommandText = "INSERT INTO Payments (StudentID, Amount, PaymentDate, PaymentMethod) " +
                                  "VALUES (@idStudent, @amount, @paymentDate, @paymentMethod)";

                cmd.Parameters.Add(new OleDbParameter("@idStudent", p.IdStudent != null ? p.IdStudent.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@amount", p.Amount));
                //עבור תאריך
                cmd.Parameters.Add("@paymentDate", System.Data.OleDb.OleDbType.Date).Value = p.PaymentDate;
                cmd.Parameters.Add(new OleDbParameter("@paymentMethod", p.PaymentMethod != null ? p.PaymentMethod.Id : 0));
            }
        }


        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Payments p = entity as Payments;
            if (p != null)
            {
                cmd.CommandText = "UPDATE Payments SET StudentID=@idStudent, Amount=@amount, " +
                                  "PaymentDate=@paymentDate, PaymentMethod=@paymentMethod WHERE Id=@id";

                cmd.Parameters.Add(new OleDbParameter("@idStudent", p.IdStudent != null ? p.IdStudent.Id : 0));
                cmd.Parameters.Add(new OleDbParameter("@amount", p.Amount));
                cmd.Parameters.Add("@paymentDate", System.Data.OleDb.OleDbType.Date).Value = p.PaymentDate;
                cmd.Parameters.Add(new OleDbParameter("@paymentMethod", p.PaymentMethod != null ? p.PaymentMethod.Id : 0));
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
//    public class PaymentsDB : BaseDB
//    {
//        public PaymentsList SelectAll()
//        {
//            command.CommandText = "SELECT * FROM Payments";
//            PaymentsList paymentsList = new PaymentsList(base.Select());
//            return paymentsList;
//        }

//        protected override BaseEntity CreateModel(BaseEntity entity)
//        {
//            Payments p = entity as Payments;

//            p.IdStudent = StudentDB.SelectById((int)reader["StudentID"]);
//            p.Amount = (int)reader["Amount"];
//            p.PaymentDate = (DateTime)reader["PaymentDate"];
//            p.PaymentMethod = PaymentMethodsDB.SelectById((int)reader["PaymentMethod"]);

//            base.CreateModel(entity);
//            return p;
//        }

//        public override BaseEntity NewEntity()
//        {
//            return new Payments();
//        }

//        static private PaymentsList list = new PaymentsList();

//        public static Payments SelectById(int id)
//        {
//            PaymentsDB db = new PaymentsDB();
//            list = db.SelectAll();

//            Payments p = list.Find(item => item.Id == id);
//            return p;
//        }

//        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Payments p = entity as Payments;

//            if (p != null)
//            {

//                string sqlStr = $"DELETE FROM Payments WHERE Id=@id";

//                command.CommandText = sqlStr;
//                command.Parameters.Add(new OleDbParameter("@id", p.Id));
//            }
//        }

//        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Payments p = entity as Payments;

//            if (p != null)
//            {

//                string sqlStr = $"INSERT INTO Payments (StudentID, Amount, PaymentDate, PaymentMethod) " +
//                                $"VALUES (@idStudent, @amount, @paymentDate, @paymentMethod)";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@idStudent", p.IdStudent.Id));
//                command.Parameters.Add(new OleDbParameter("@amount", p.Amount));
//                command.Parameters.Add(new OleDbParameter("@paymentDate", p.PaymentDate));
//                command.Parameters.Add(new OleDbParameter("@paymentMethod", p.PaymentMethod.Id));
//            }
//        }

//        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
//        {
//            Payments p = entity as Payments;

//            if (p != null)
//            {

//                string sqlStr = $"UPDATE Payments SET StudentID=@idStudent, Amount=@amount, " +
//                                $"PaymentDate=@paymentDate, PaymentMethod=@paymentMethod WHERE Id=@id";

//                command.CommandText = sqlStr;

//                command.Parameters.Add(new OleDbParameter("@idStudent", p.IdStudent.Id));
//                command.Parameters.Add(new OleDbParameter("@amount", p.Amount));
//                command.Parameters.Add(new OleDbParameter("@paymentDate", p.PaymentDate));
//                command.Parameters.Add(new OleDbParameter("@paymentMethod", p.PaymentMethod.Id));
//                command.Parameters.Add(new OleDbParameter("@id", p.Id));
//            }
//        }
//    }
//}