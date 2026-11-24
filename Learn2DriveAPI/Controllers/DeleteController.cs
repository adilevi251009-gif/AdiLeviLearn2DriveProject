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
        [HttpDelete("{id}")]
        public int DeleteCity(int id)
        {
            CityDB cdb = new CityDB();
            City city = new City();
            city.Id = id;
            cdb.Delete(city);
            int x = cdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteCarType(int id)
        {
            CarTypeDB ctdb = new CarTypeDB();
            CarType carType = new CarType();
            carType.Id = id;
            ctdb.Delete(carType);
            int x = ctdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteChecklist(int id)
        {
            ChecklistDB checkdb = new ChecklistDB();
            Checklist checklist = new Checklist();
            checklist.Id = id;
            checkdb.Delete(checklist);
            int x = checkdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteLessons(int id)
        {
            LessonsDB ldb = new LessonsDB();
            Lessons lessons = new Lessons();
            lessons.Id = id;
            ldb.Delete(lessons);
            int x = ldb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteLessonStatus(int id)
        {
            LessonStatusDB lsdb = new LessonStatusDB();
            LessonStatus lessonStatus = new LessonStatus();
            lessonStatus.Id = id;
            lsdb.Delete(lessonStatus);
            int x = lsdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteManager(int id)
        {
            ManagerDB mdb = new ManagerDB();
            Manager manager = new Manager();
            manager.Id = id;
            mdb.Delete(manager);
            int x = mdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeletePaymentMethods(int id)
        {
            PaymentMethodsDB pmdb = new PaymentMethodsDB();
            PaymentMethods paymentMethods = new PaymentMethods();
            paymentMethods.Id = id;
            pmdb.Delete(paymentMethods);
            int x = pmdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeletePayments(int id)
        {
            PaymentsDB pdb = new PaymentsDB();
            Payments payments = new Payments();
            payments.Id = id;
            pdb.Delete(payments);
            int x = pdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeletePerson(int id)
        {
            PersonDB perdb = new PersonDB();
            Person person = new Person();
            person.Id = id;
            perdb.Delete(person);
            int x = perdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteStatus(int id)
        {
            StatusDB sdb = new StatusDB();
            Status status = new Status();
            status.Id = id;
            sdb.Delete(status);
            int x = sdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteStudent(int id)
        {
            StudentDB studb = new StudentDB();
            Student student = new Student();
            student.Id = id;
            studb.Delete(student);
            int x = studb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteTeacher(int id)
        {
            TeacherDB teachdb = new TeacherDB();
            Teacher teacher = new Teacher();
            teacher.Id = id;
            teachdb.Delete(teacher);
            int x = teachdb.SaveChanges();
            return x;
        }

        [HttpDelete("{id}")]
        public int DeleteTopics(int id)
        {
            TopicsDB topdb = new TopicsDB();
            Topics topics = new Topics();
            topics.Id = id;
            topdb.Delete(topics);
            int x = topdb.SaveChanges();
            return x;
        }
    }
}
