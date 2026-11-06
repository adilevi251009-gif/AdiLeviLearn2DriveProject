using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModel;
using Model;

namespace Learn2DriveAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        public CityList SelectAllCity()
        {
            CityDB cdb = new CityDB();
            CityList cities = cdb.SelectAll();
            return cities;
        }

        [HttpGet]
        public CarTypeList SelectAllCarType()
        {
            CarTypeDB ctdb = new CarTypeDB();
            CarTypeList carTypes = ctdb.SelectAll();
            return carTypes;
        }

        [HttpGet]
        public ChecklistList SelectAllChecklist()
        {
            ChecklistDB checkdb = new ChecklistDB();
            ChecklistList checklists = checkdb.SelectAll();
            return checklists;
        }

        [HttpGet]
        public LessonsList SelectAllLessons()
        {
            LessonsDB ldb = new LessonsDB();
            LessonsList lessons = ldb.SelectAll();
            return lessons;
        }

        [HttpGet]
        public LessonStatusList SelectAllLessonStatus()
        {
            LessonStatusDB lsdb = new LessonStatusDB();
            LessonStatusList lessonStatus = lsdb.SelectAll();
            return lessonStatus;
        }

        [HttpGet]
        public ManagerList SelectAllManager()
        {
            ManagerDB mdb = new ManagerDB();
            ManagerList managers = mdb.SelectAll();
            return managers;
        }

        [HttpGet]
        public PaymentMethodsList SelectAllPaymentMethods()
        {
            PaymentMethodsDB pmdb = new PaymentMethodsDB();
            PaymentMethodsList lessonStatus = pmdb.SelectAll();
            return lessonStatus;
        }

        [HttpGet]
        public PaymentsList SelectAllPayments()
        {
            PaymentsDB pdb = new PaymentsDB();
            PaymentsList payments = pdb.SelectAll();
            return payments;
        }

        [HttpGet]
        public PersonList SelectAllPerson()
        {
            PersonDB perdb = new PersonDB();
            PersonList persons = perdb.SelectAll();
            return persons;
        }

        [HttpGet]
        public StatusList SelectAllStatus()
        {
            StatusDB sdb = new StatusDB();
            StatusList statuses = sdb.SelectAll();
            return statuses;
        }

        [HttpGet]
        public StudentList SelectAllStudent()
        {
            StudentDB studb = new StudentDB();
            StudentList students = studb.SelectAll();
            return students;
        }

        [HttpGet]
        public TeacherList SelectAllTeacher()
        {
            TeacherDB teachdb = new TeacherDB();
            TeacherList teachers = teachdb.SelectAll();
            return teachers;
        }

        [HttpGet]
        public TopicsList SelectAllTopics()
        {
            TopicsDB topdb = new TopicsDB();
            TopicsList topics = topdb.SelectAll();
            return topics;
        }
    }
}
