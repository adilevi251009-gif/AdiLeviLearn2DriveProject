using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Learn2DriveAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InsertController : ControllerBase
    {
        [HttpPost]
        public int InsertCity([FromBody] City city)
        {
            CityDB cdb = new CityDB();
            cdb.Insert(city);
            int x = cdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertCarType([FromBody] CarType carType)
        {
            CarTypeDB ctdb = new CarTypeDB();
            ctdb.Insert(carType);
            int x = ctdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertChecklist([FromBody] Checklist checklist)
        {
            ChecklistDB checkdb = new ChecklistDB();
            checkdb.Insert(checklist);
            int x = checkdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertLessons([FromBody] Lessons lessons)
        {
            LessonsDB ldb = new LessonsDB();
            ldb.Insert(lessons);
            int x = ldb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertLessonStatus([FromBody] LessonStatus lessonStatus)
        {
            LessonStatusDB lsdb = new LessonStatusDB();
            lsdb.Insert(lessonStatus);
            int x = lsdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertManager([FromBody] Manager manager)
        {
            ManagerDB mdb = new ManagerDB();
            mdb.Insert(manager);
            int x = mdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertPaymentMethods([FromBody] PaymentMethods paymentMethods)
        {
            PaymentMethodsDB pmdb = new PaymentMethodsDB();
            pmdb.Insert(paymentMethods);
            int x = pmdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertPayments([FromBody] Payments payments)
        {
            PaymentsDB pdb = new PaymentsDB();
            pdb.Insert(payments);
            int x = pdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertPerson([FromBody] Person person)
        {
            PersonDB pdb = new PersonDB();
            pdb.Insert(person);
            int x = pdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertStatus([FromBody] Status status)
        {
            StatusDB sdb = new StatusDB();
            sdb.Insert(status);
            int x = sdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertStudent([FromBody] Student student)
        {
            StudentDB studb = new StudentDB();
            studb.Insert(student);
            int x = studb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertTeacher([FromBody] Teacher teacher)
        {
            TeacherDB teachdb = new TeacherDB();
            teachdb.Insert(teacher);
            int x = teachdb.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertTopics([FromBody] Topics topics)
        {
            TopicsDB topdb = new TopicsDB();
            topdb.Insert(topics);
            int x = topdb.SaveChanges();
            return x;
        }
    }
}
