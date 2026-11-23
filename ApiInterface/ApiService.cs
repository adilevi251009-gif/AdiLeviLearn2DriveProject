using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace ApiInterface
{
    public class ApiService : ApiInterface
    {
        string url;
        public HttpClient client;
        public ApiService()
        {
            url = "http://localhost:5256";
            client = new HttpClient();
        }

        #region GetAll
        public async Task<CarTypeList> GetAllCarTypes()
        {
            return await client.GetFromJsonAsync<CarTypeList>(url + "/api/select/SelectAllCarType");
        }
        public async Task<ChecklistList> GetAllChecklist()
        {
            return await client.GetFromJsonAsync<ChecklistList>(url + "/api/select/SelectAllChecklist");
        }
        public async Task<CityList> GetAllCity()
        {
            return await client.GetFromJsonAsync<CityList>(url + "/api/select/SelectAllCity");
        }
        public async Task<LessonsList> GetAllLessons()
        {
            return await client.GetFromJsonAsync<LessonsList>(url + "/api/select/SelectAllLessons");
        }
        public async Task<LessonStatusList> GetAllLessonStatus()
        {
            return await client.GetFromJsonAsync<LessonStatusList>(url + "/api/select/SelectAllLessonStatus");
        }
        public async Task<ManagerList> GetAllManager()
        {
            return await client.GetFromJsonAsync<ManagerList>(url + "/api/select/SelectAllManager");
        }
        public async Task<PaymentMethodsList> GetAllPaymentMethods()
        {
            return await client.GetFromJsonAsync<PaymentMethodsList>(url + "/api/select/SelectAllPaymentMethods");
        }
        public async Task<PaymentsList> GetAllPayments()
        {
            return await client.GetFromJsonAsync<PaymentsList>(url + "/api/select/SelectAllPayments");
        }
        public async Task<PersonList> GetAllPerson()
        {
            return await client.GetFromJsonAsync<PersonList>(url + "/api/select/SelectAllPerson");
        }
        public async Task<StatusList> GetAllStatus()
        {
            return await client.GetFromJsonAsync<StatusList>(url + "/api/select/SelectAllStatus");
        }
        public async Task<StudentList> GetAllStudent()
        {
            return await client.GetFromJsonAsync<StudentList>(url + "/api/select/SelectAllStudent");
        }
        public async Task<TeacherList> GetAllTeacher()
        {
            return await client.GetFromJsonAsync<TeacherList>(url + "/api/select/SelectAllTeacher");
        }
        public async Task<TopicsList> GetAllTopics()
        {
            return await client.GetFromJsonAsync<TopicsList>(url + "/api/select/SelectAllTopics");
        }
        #endregion

        #region Update
        public async Task<int> UpdateCarType(CarType carType)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateCarType", carType)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateChecklist(Checklist checklist)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateChecklist", checklist)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateCity(City city)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateCity", city)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateLessons(Lessons lessons)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateLessons", lessons)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateLessonStatus(LessonStatus lessonStatus)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateLessonStatus", lessonStatus)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateManager(Manager manager)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateManager", manager)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdatePaymentMethods(PaymentMethods paymentMethods)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdatePaymentMethods", paymentMethods)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdatePayments(Payments payments)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdatePayments", payments)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdatePerson(Person person)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdatePerson", person)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateStatus(Status status)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateStatus", status)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateStudent(Student student)
        {

            return (await client.PutAsJsonAsync(url + "/api/update/UpdateStudent", student)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateTeacher(Teacher teacher)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateTeacher", teacher)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateTopics(Topics topics)
        {
            return (await client.PutAsJsonAsync(url + "/api/update/UpdateTopics", topics)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion

        #region Insert
        public async Task<int> InsertCarType(CarType carType)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertCarType", carType)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertChecklist(Checklist checklist)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertChecklist", checklist)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertCity(City city)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertCity", city)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertLessons(Lessons lessons)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertLessons", lessons)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertLessonStatus(LessonStatus lessonStatus)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertLessonStatus", lessonStatus)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertManager(Manager manager)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertManager", manager)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertPaymentMethods(PaymentMethods paymentMethods)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertPaymentMethods", paymentMethods)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertPayments(Payments payments)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertPayments", payments)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertPerson(Person person)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertPerson", person)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertStatus(Status status)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertStatus", status)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertStudent(Student student)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertStudent", student)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertTeacher(Teacher teacher)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertTeacher", teacher)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> InsertTopics(Topics topics)
        {
            return (await client.PostAsJsonAsync(url + "/api/insert/InsertTopics", topics)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion

        #region Delete
        public async Task<int> DeleteCarType(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteCarType/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteChecklist(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteChecklist/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteCity(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteCity/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteLessons(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteLessons/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteLessonStatus(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteLessonStatus/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteManager(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteManager/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeletePaymentMethods(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeletePaymentMethods/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeletePayments(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeletePayments/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeletePerson(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeletePerson/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteStatus(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteStatus/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteStudent(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteStudent/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteTeacher(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteTeacher/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> DeleteTopics(int id)
        {
            return (await client.DeleteAsync(url + "/api/delete/DeleteTopics/" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion

    }
}
