using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterface
{
    public interface ApiInterface
    {
        #region GetAll
        public Task<CarTypeList> GetAllCarTypes();
        public Task<ChecklistList> GetAllChecklist();
        public Task<CityList> GetAllCity();
        public Task<LessonsList> GetAllLessons();
        public Task<LessonStatusList> GetAllLessonStatus();
        public Task<ManagerList> GetAllManager();
        public Task<PaymentMethodsList> GetAllPaymentMethods();
        public Task<PaymentsList> GetAllPayments();
        public Task<PersonList> GetAllPerson();
        public Task<StatusList> GetAllStatus();
        public Task<StudentList> GetAllStudent();
        public Task<TeacherList> GetAllTeacher();
        public Task<TopicsList> GetAllTopics();

        #endregion

        #region Update
        public Task<int> UpdateCarType(CarType carType);
        public Task<int> UpdateChecklist(Checklist checklist);
        public Task<int> UpdateCity(City city);
        public Task<int> UpdateLessons(Lessons lessons);
        public Task<int> UpdateLessonStatus(LessonStatus lessonStatus);
        public Task<int> UpdateManager(Manager manager);
        public Task<int> UpdatePaymentMethods(PaymentMethods paymentMethods);
        public Task<int> UpdatePayments(Payments payments);
        public Task<int> UpdatePerson(Person person);
        public Task<int> UpdateStatus(Status status);
        public Task<int> UpdateStudent(Student student);
        public Task<int> UpdateTeacher(Teacher teacher);
        public Task<int> UpdateTopics(Topics topics);

        #endregion

        #region Insert
        public Task<int> InsertCarType(CarType carType);
        public Task<int> InsertChecklist(Checklist checklist);
        public Task<int> InsertCity(City city);
        public Task<int> InsertLessons(Lessons lessons);
        public Task<int> InsertLessonStatus(LessonStatus lessonStatus);
        public Task<int> InsertManager(Manager manager);
        public Task<int> InsertPaymentMethods(PaymentMethods paymentMethods);
        public Task<int> InsertPayments(Payments payments);
        public Task<int> InsertPerson(Person person);
        public Task<int> InsertStatus(Status status);
        public Task<int> InsertStudent(Student student);
        public Task<int> InsertTeacher(Teacher teacher);
        public Task<int> InsertTopics(Topics topics);
        #endregion

        #region Delete
        public Task<int> DeleteCarType(int id);
        public Task<int> DeleteChecklist(int id);
        public Task<int> DeleteCity(int id);
        public Task<int> DeleteLessons(int id);
        public Task<int> DeleteLessonStatus(int id);
        public Task<int> DeleteManager(int id);
        public Task<int> DeletePaymentMethods(int id);
        public Task<int> DeletePayments(int id);
        public Task<int> DeletePerson(int id);
        public Task<int> DeleteStatus(int id);
        public Task<int> DeleteStudent(int id);
        public Task<int> DeleteTeacher(int id);
        public Task<int> DeleteTopics(int id);
        #endregion

    }
}
