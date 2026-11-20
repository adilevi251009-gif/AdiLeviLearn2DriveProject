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





        public async Task<int> UpdateCarType(CarType carType)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateCarType", carType);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateChecklist(Checklist checklist)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateChecklist", checklist);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateCity(City city)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateCity", city);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateLessons(Lessons lessons)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateLessons", lessons);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateLessonStatus(LessonStatus lessonStatus)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateLessonStatus", lessonStatus);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> UpdateManager(Manager manager)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateManager", manager);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdatePaymentMethods(PaymentMethods paymentMethods)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdatePaymentMethods", paymentMethods);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdatePayments(Payments payments)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdatePayments", payments);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdatePerson(Person person)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdatePerson", person);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateStatus(Status status)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateStatus", status);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateStudent(Student student)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateStudent", student);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateTeacher(Teacher teacher)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateTeacher", teacher);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> UpdateTopics(Topics topics)
        {
            var response = await client.PutAsJsonAsync(url + "/api/update/UpdateTopics", topics);
            return await response.Content.ReadFromJsonAsync<int>();
        }





        public async Task<int> InsertCarType(CarType carType)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertCarType", carType);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> InsertChecklist(Checklist checklist)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertChecklist", checklist);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertCity(City city)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertCity", city);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertLessons(Lessons lessons)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertLessons", lessons);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertLessonStatus(LessonStatus lessonStatus)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertLessonStatus", lessonStatus);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertManager(Manager manager)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertManager", manager);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertPaymentMethods(PaymentMethods paymentMethods)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertPaymentMethods", paymentMethods);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertPayments(Payments payments)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertPayments", payments);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertPerson(Person person)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertPerson", person);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertStatus(Status status)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertStatus", status);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertStudent(Student student)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertStudent", student);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertTeacher(Teacher teacher)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertTeacher", teacher);
            return await response.Content.ReadFromJsonAsync<int>();
        }
        public async Task<int> InsertTopics(Topics topics)
        {
            var response = await client.PostAsJsonAsync(url + "/api/insert/InsertTopics", topics);
            return await response.Content.ReadFromJsonAsync<int>();
        }





        //public async Task<int> DeleteCarType(int id)
        //{
        //    return (await client.DeleteAsync(url + "/api/delete/DeleteCarType/" + id));
        //}
    }
}
