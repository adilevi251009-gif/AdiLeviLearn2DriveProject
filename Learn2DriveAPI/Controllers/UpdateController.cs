using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace Learn2DriveAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        [HttpPut]
        public int UpdateCity([FromBody] City city)
        {
            CityDB cdb = new CityDB();
            cdb.Update(city);
            int x = cdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateCarType([FromBody] CarType carType)
        {
            CarTypeDB ctdb = new CarTypeDB();
            ctdb.Update(carType);
            int x = ctdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateChecklist([FromBody] Checklist checklist)
        {
            ChecklistDB checkdb = new ChecklistDB();
            checkdb.Update(checklist);
            int x = checkdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateLessons([FromBody] Lessons lessons)
        {
            LessonsDB ldb = new LessonsDB();
            ldb.Update(lessons);
            int x = ldb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateLessonStatus([FromBody] LessonStatus lessonStatus)
        {
            LessonStatusDB lsdb = new LessonStatusDB();
            lsdb.Update(lessonStatus);
            int x = lsdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateManager([FromBody] Manager manager)
        {
            ManagerDB mdb = new ManagerDB();
            mdb.Update(manager);
            int x = mdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdatePaymentMethods([FromBody] PaymentMethods paymentMethods)
        {
            PaymentMethodsDB pmdb = new PaymentMethodsDB();
            pmdb.Update(paymentMethods);
            int x = pmdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdatePayments([FromBody] Payments payments)
        {
            PaymentsDB pdb = new PaymentsDB();
            pdb.Update(payments);
            int x = pdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdatePerson([FromBody] Person person)
        {
            PersonDB perdb = new PersonDB();
            perdb.Update(person);
            int x = perdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateStatus([FromBody] Status status)
        {
            StatusDB sdb = new StatusDB();
            sdb.Update(status);
            int x = sdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateStudent([FromBody] Student student)
        {
            StudentDB studb = new StudentDB();
            studb.Update(student);
            int x = studb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateTeacher([FromBody] Teacher teacher)
        {
            TeacherDB teachdb = new TeacherDB();
            teachdb.Update(teacher);
            int x = teachdb.SaveChanges();
            return x;
        }

        [HttpPut]
        public int UpdateTopics([FromBody] Topics topics)
        {
            TopicsDB cdb = new TopicsDB();
            cdb.Update(topics);
            int x = cdb.SaveChanges();
            return x;
        }
    }
}
