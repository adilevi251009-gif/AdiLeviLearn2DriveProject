using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Learn2DriveAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        [HttpDelete]
        public int DeleteCity([FromBody] City city)
        {
            CityDB cdb = new CityDB();
            cdb.Delete(city);
            int x = cdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteCarType([FromBody] CarType carType)
        {
            CarTypeDB ctdb = new CarTypeDB();
            ctdb.Delete(carType);
            int x = ctdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteChecklist([FromBody] Checklist checklist)
        {
            ChecklistDB checkdb = new ChecklistDB();
            checkdb.Delete(checklist);
            int x = checkdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteLessons([FromBody] Lessons lessons)
        {
            LessonsDB ldb = new LessonsDB();
            ldb.Delete(lessons);
            int x = ldb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteLessonStatus([FromBody] LessonStatus lessonStatus)
        {
            LessonStatusDB lsdb = new LessonStatusDB();
            lsdb.Delete(lessonStatus);
            int x = lsdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteManager([FromBody] Manager manager)
        {
            ManagerDB mdb = new ManagerDB();
            mdb.Delete(manager);
            int x = mdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeletePaymentMethods([FromBody] PaymentMethods paymentMethods)
        {
            PaymentMethodsDB pmdb = new PaymentMethodsDB();
            pmdb.Delete(paymentMethods);
            int x = pmdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeletePayments([FromBody] Payments payments)
        {
            PaymentsDB pdb = new PaymentsDB();
            pdb.Delete(payments);
            int x = pdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeletePerson([FromBody] Person person)
        {
            PersonDB perdb = new PersonDB();
            perdb.Delete(person);
            int x = perdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteStatus([FromBody] Status status)
        {
            StatusDB sdb = new StatusDB();
            sdb.Delete(status);
            int x = sdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteStudent([FromBody] Student student)
        {
            StudentDB studb = new StudentDB();
            studb.Delete(student);
            int x = studb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteTeacher([FromBody] Teacher teacher)
        {
            TeacherDB teachdb = new TeacherDB();
            teachdb.Delete(teacher);
            int x = teachdb.SaveChanges();
            return x;
        }

        [HttpDelete]
        public int DeleteTopics([FromBody] Topics topics)
        {
            TopicsDB topdb = new TopicsDB();
            topdb.Delete(topics);
            int x = topdb.SaveChanges();
            return x;
        }
    }
}
