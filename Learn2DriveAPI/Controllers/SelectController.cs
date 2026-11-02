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
        //[ActionName("CitySelector")]
        public CityList SelectAllCity()
        {
            CityDB cdb = new CityDB();
            CityList cities = cdb.SelectAll();
            return cities;
        }

        [HttpGet]
        [ActionName("CarTypeSelector")]
        public CarTypeList SelectAllCarType()
        {
            CarTypeDB ctdb = new CarTypeDB();
            CarTypeList carTypes = ctdb.SelectAll();
            return carTypes;
        }

        [HttpGet]
        [ActionName("ChecklistSelector")]
        public ChecklistList SelectAllChecklist()
        {
            ChecklistDB cdb = new ChecklistDB();
            ChecklistList checklists = cdb.SelectAll();
            return checklists;
        }

        [HttpGet]
        [ActionName("LessonsSelector")]
        public LessonsList SelectAllLessons()
        {
            LessonsDB ldb = new LessonsDB();
            LessonsList lessons = ldb.SelectAll();
            return lessons;
        }

        [HttpGet]
        [ActionName("LessonStatusSelector")]
        public LessonStatusList SelectAllLessonStatus()
        {
            LessonStatusDB lsdb = new LessonStatusDB();
            LessonStatusList lessonStatus = lsdb.SelectAll();
            return lessonStatus;
        }

        [HttpGet]
        [ActionName("ManagerSelector")]
        public ManagerList SelectAllManager()
        {
            ManagerDB mdb = new ManagerDB();
            ManagerList managers = mdb.SelectAll();
            return managers;
        }

        [HttpGet]
        [ActionName("PaymentMethodsSelector")]
        public PaymentMethodsList SelectAllPaymentMethods()
        {
            PaymentMethodsDB pmdb = new PaymentMethodsDB();
            PaymentMethodsList lessonStatus = pmdb.SelectAll();
            return lessonStatus;
        }

        [HttpGet]
        [ActionName("PaymentsSelector")]
        public PaymentsList SelectAllPayments()
        {
            PaymentsDB pdb = new PaymentsDB();
            PaymentsList payments = pdb.SelectAll();
            return payments;
        }

        [HttpGet]
        [ActionName("PersonSelector")]
        public PersonList SelectAllPerson()
        {
            PersonDB perdb = new PersonDB();
            PersonList persons = perdb.SelectAll();
            return persons;
        }

        [HttpGet]
        [ActionName("StatusSelector")]
        public StatusList SelectAllStatus()
        {
            StatusDB sdb = new StatusDB();
            StatusList statuses = sdb.SelectAll();
            return statuses;
        }

        [HttpGet]
        [ActionName("StudentSelector")]
        public StudentList SelectAllStudent()
        {
            StudentDB studb = new StudentDB();
            StudentList students = studb.SelectAll();
            return students;
        }

        [HttpGet]
        [ActionName("TeacherSelector")]
        public TeacherList SelectAllTeacher()
        {
            TeacherDB teachdb = new TeacherDB();
            TeacherList teachers = teachdb.SelectAll();
            return teachers;
        }

        [HttpGet]
        [ActionName("TopicsSelector")]
        public TopicsList SelectAllTopics()
        {
            TopicsDB topdb = new TopicsDB();
            TopicsList topics = topdb.SelectAll();
            return topics;
        }
    }
}
