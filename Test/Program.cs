using Model;
using ViewModel;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region CityDB

            //CityDB cdb = new();
            //CityList cList = cdb.SelectAll();
            //foreach (City c in cList)
            //    Console.WriteLine(c.CityName);
            ////-----הדפסת עיר לפי Id-----
            //City city = CityDB.SelectById(1);
            //if (city != null)
            //{
            //    Console.WriteLine(city.CityName);
            //}
            //else
            //{
            //    Console.WriteLine("City not found");
            //}

            ////----Insert----
            //City myCity = new City() { CityName = "מעלה אדומים" };
            //cdb.Insert(myCity);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //City c1 = cList.Last();
            //cdb.Delete(c1);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //City cityToUpdate = cList[3];
            //cityToUpdate.CityName = "ראשון לציון";
            //cdb.Update(cityToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region CarTypeDB

            //CarTypeDB ctdb = new();
            //CarTypeList ctList = ctdb.SelectAll();
            //foreach (CarType c in ctList)
            //    Console.WriteLine(c.CarTypeName);
            ////------הדפסת סוג רכב לפי Id-----
            //CarType carType = CarTypeDB.SelectById(1);
            //if (carType != null)
            //{
            //    Console.WriteLine(carType.CarTypeName);
            //}
            //else
            //{
            //    Console.WriteLine("Car type not found");
            //}

            //// ----Insert----
            //CarType carTypeToInsert = new CarType() { CarTypeName = "ידני" };
            //ctdb.Insert(carTypeToInsert);
            //int x = ctdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //CarType carTypeToDelete = ctList.Last();
            //ctdb.Delete(carTypeToDelete);
            //int x = ctdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            ////----Update----
            //CarType carTypeToUpdate = ctList[1];
            //carTypeToUpdate.CarTypeName = "אוטומטי";
            //ctdb.Update(carTypeToUpdate);
            //int x = ctdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region LessonStatusDB

            //LessonStatusDB lsdb = new();
            //LessonStatusList lsList = lsdb.SelectAll();
            //foreach (LessonStatus ls in lsList)
            //    Console.WriteLine(ls.LessonStatusName);
            ////-----הדפסת סטטוס שיעור לפי Id-----
            //LessonStatus lessonStatus = LessonStatusDB.SelectById(1);
            //if (lessonStatus != null)
            //{
            //    Console.WriteLine(lessonStatus.LessonStatusName);
            //}
            //else
            //{
            //    Console.WriteLine("Lesson status not found");
            //}

            //// ----Insert----
            //LessonStatus lessonStatusToInsert = new LessonStatus() { LessonStatusName = "נקבע" };
            //lsdb.Insert(lessonStatusToInsert);
            //int x = lsdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //LessonStatus lessonStatusToDelete = lsList.Last();
            //lsdb.Delete(lessonStatusToDelete);
            //int x = lsdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //LessonStatus lessonStatusToUpdate = lsList[1];
            //lessonStatusToUpdate.LessonStatusName = "הושלם";
            //lsdb.Update(lessonStatusToUpdate);
            //int x = lsdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region TopicsDB

            //TopicsDB topics = new();
            //TopicsList tList = topics.SelectAll();
            //foreach (Topics topic in tList)
            //    Console.WriteLine(topic.TopicName);
            ////-----הדפסת נושא לפי Id------
            //Topics topicById = TopicsDB.SelectById(1);
            //if (topicById != null)
            //{
            //    Console.WriteLine(topicById.TopicName);
            //}
            //else
            //{
            //    Console.WriteLine("Topic not found");
            //}

            //// ----Insert----
            //Topics topicsToInsert = new Topics() { TopicName = "חנייה" };
            //topics.Insert(topicsToInsert);
            //int x = topics.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //Topics topicsToDelete = tList.Last();
            //topics.Delete(topicsToDelete);
            //int x = topics.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //Topics topicsToUpdate = tList[1];
            //topicsToUpdate.TopicName = "רוורס";
            //topics.Update(topicsToUpdate);
            //int x = topics.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region ChecklistDB

            //ChecklistDB checklistdb = new();
            //ChecklistList cList = checklistdb.SelectAll();
            //foreach (Checklist c in cList)
            //    Console.WriteLine($"{c.Id}, {c.IdStudent.Id}, {c.IsDone}, {c.Topic.TopicName}");
            ////-----הדפסת Checklist לפי Id-----
            //Checklist checklistById = ChecklistDB.SelectById(1);
            //if (checklistById != null)
            //{
            //    Console.WriteLine(checklistById.IsDone);
            //}
            //else
            //{
            //    Console.WriteLine("Checklist not found");
            //}

            //// ----Insert----
            //Checklist checklistToInsert = new Checklist() { IdStudent = StudentDB.SelectById(12), Topic = TopicsDB.SelectById(1), IsDone = false };
            //checklistdb.Insert(checklistToInsert);
            //int x = checklistdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //Checklist checklistToDelete = cList.Last();
            //checklistdb.Delete(checklistToDelete);
            //int x = checklistdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //Checklist checklistToUpdate = cList[1];
            //checklistToUpdate.IsDone = true;
            //checklistdb.Update(checklistToUpdate);
            //int x = checklistdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region PaymentMethodsDB

            //PaymentMethodsDB paymentMethodsDB = new();
            //PaymentMethodsList paymentMethodsList = paymentMethodsDB.SelectAll();
            //foreach (PaymentMethods paymentMethod in paymentMethodsList)
            //    Console.WriteLine(paymentMethod.MethodName);
            ////----הדפסת אמצעי תשלום לפי Id-----
            //PaymentMethods paymentMethodById = PaymentMethodsDB.SelectById(1);
            //if (paymentMethodById != null)
            //{
            //    Console.WriteLine(paymentMethodById.MethodName);
            //}
            //else
            //{
            //    Console.WriteLine("Payment method not found");
            //}

            //// ----Insert----
            //PaymentMethods paymentMethodsToInsert = new PaymentMethods() { MethodName = "אשראי" };
            //paymentMethodsDB.Insert(paymentMethodsToInsert);
            //int x = paymentMethodsDB.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //PaymentMethods paymentMethodsToDelete = paymentMethodsList.Last();
            //paymentMethodsDB.Delete(paymentMethodsToDelete);
            //int x = paymentMethodsDB.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //PaymentMethods paymentMethodsToUpdate = paymentMethodsList[1];
            //paymentMethodsToUpdate.MethodName = "ביט";
            //paymentMethodsDB.Update(paymentMethodsToUpdate);
            //int x = paymentMethodsDB.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region StatusDB

            //StatusDB statusDB = new();
            //StatusList statusList = statusDB.SelectAll();
            //foreach (Status status in statusList)
            //    Console.WriteLine(status.StatusName);
            ////-----הדפסת סטטוס לפי Id-----
            //Status statusById = StatusDB.SelectById(1);
            //if (statusById != null)
            //{
            //    Console.WriteLine(statusById.StatusName);
            //}
            //else
            //{
            //    Console.WriteLine("Status not found");
            //}

            // ---- Insert ----
            //Status statusToInsert = new Status() { StatusName = "פעיל" };
            //statusDB.Insert(statusToInsert);
            //int x = statusDB.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //Status statusToDelete = statusList.Last();
            //statusDB.Delete(statusToDelete);
            //int x = statusDB.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            // ----Update----
            //Status statusToUpdate = statusList[1];
            //statusToUpdate.StatusName = "סיים";
            //statusDB.Update(statusToUpdate);
            //int x = statusDB.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region PersonDB

            //PersonList pList;
            //PersonDB pdb = new PersonDB();
            //pList = pdb.SelectAll();
            //foreach (Person c in pList)
            //    Console.WriteLine($"{c.Id}, {c.FirstName}, {c.LastName}, {c.Email},{c.PhoneNumber}, {c.Pass}");
            ////----הדפסת אדם לפי Id---- -
            //Person personById = PersonDB.SelectById(1);
            //if (personById != null)
            //{
            //    Console.WriteLine(personById.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("Payment method not found");
            //}

            ////----Insert----
            //Person personToInsert = new Person()
            //{
            //    FirstName = "רותי",
            //    LastName = "כהן",
            //    PhoneNumber = "0501234567",
            //    Email = "ruti@gmail.com",
            //    Pass = "RotiCohen@2567"
            //};
            //pdb.Insert(personToInsert);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            ////----Delete----
            //Person personToDelete = pList.Last();
            //pdb.Delete(personToDelete);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //Person personToUpdate = pList[3];
            //personToUpdate.FirstName = "רון";
            //pdb.Update(personToUpdate);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region PaymentsDB

            //PaymentsDB pdb = new PaymentsDB();
            //PaymentsList pList = pdb.SelectAll();
            //foreach (Payments p in pList)
            //{
            //    Console.WriteLine($"{p.Id}, {p.IdStudent.Id}, {p.Amount}, {p.PaymentDate}, {p.PaymentMethod.Id}");
            //}
            ////-----הדפסת פרטי תשלום לפי Id-----
            //Payments paymentById = PaymentsDB.SelectById(3);
            //if (paymentById != null)
            //{
            //    Console.WriteLine($"{paymentById.Id}, {paymentById.IdStudent.Id}, {paymentById.Amount}, {paymentById.PaymentDate}, {paymentById.PaymentMethod.Id}");
            //}
            //else
            //{
            //    Console.WriteLine("Payment not found");
            //}

            //// ----Insert----
            //Payments paymentToInsert = new Payments()
            //{
            //    IdStudent = StudentDB.SelectById(13),
            //    Amount = 100,
            //    PaymentDate = DateTime.Now,
            //    PaymentMethod = PaymentMethodsDB.SelectById(2)
            //};
            //pdb.Insert(paymentToInsert);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ----Delete----
            //Payments paymentToDelete = pList.Last();
            //pdb.Delete(paymentToDelete);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //Payments paymentToUpdate = pList[1];
            //paymentToUpdate.Amount = 190;
            //pdb.Update(paymentToUpdate);
            //int x = pdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region StudentDB

            //StudentDB sdb = new();
            //StudentList sList = sdb.SelectAll();
            //foreach (Student s in sList)
            //{
            //    Console.WriteLine(s.Id);
            //    Console.WriteLine(s.FirstName);
            //    Console.WriteLine(s.LastName);
            //    Console.WriteLine(s.Email);
            //    Console.WriteLine(s.PhoneNumber);
            //    Console.WriteLine(s.Pass);
            //    Console.WriteLine(s.StartDate);
            //    Console.WriteLine(s.BirthDate);
            //    Console.WriteLine(s.Status.StatusName);
            //    Console.WriteLine(s.IdTeacher.Id);
            //}
            ////----הדפסת אדם לפי Id-----
            //Student studentById = StudentDB.SelectById(12);
            //if (studentById != null)
            //{
            //    Console.WriteLine(studentById.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("Payment method not found");
            //}

            ////----Insert----
            //Student newStudent = new Student()
            //{
            //    FirstName = "David",
            //    LastName = "Cohen",
            //    Email = "david@gmail.com",
            //    PhoneNumber = "0501234567",
            //    Pass = "1234",
            //    StartDate = DateTime.Now,
            //    BirthDate = new DateTime(2008, 5, 10),
            //    Status = StatusDB.SelectById(1),
            //    IdTeacher = TeacherDB.SelectById(4)
            //};
            //sdb.Insert(newStudent);
            //int x = sdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ---- Delete ----
            //Student studentToDelete = sList.Last();
            //sdb.Delete(studentToDelete);
            //int x = sdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ----Update----
            //Student studentToUpdate = sList[1];
            //studentToUpdate.FirstName = "איתי";
            //sdb.Update(studentToUpdate);
            //int x = sdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            //Student studentToUpdate = StudentDB.SelectById(46);

            //if (studentToUpdate != null)
            //{
            //    studentToUpdate.FirstName = "אורלי";
            //    studentToUpdate.LastName = "כהן";
            //    studentToUpdate.Email = "OrlyCohen72@gmail.com";
            //    studentToUpdate.PhoneNumber = "0501239824";
            //    studentToUpdate.Pass = "Orly@Cohen72";

            //    sdb.Update(studentToUpdate);
            //    int x = sdb.SaveChanges();

            //    Console.WriteLine($"{x} rows were updated");
            //}
            //else
            //{
            //    Console.WriteLine("Student not found");
            //}

            #endregion

            #region ManagerDB

            //ManagerDB mdb = new();
            //ManagerList mList = mdb.SelectAll();
            //foreach (Manager m in mList)
            //{
            //    Console.WriteLine(m.Id);
            //    Console.WriteLine(m.FirstName);
            //    Console.WriteLine(m.LastName);
            //    Console.WriteLine(m.Email);
            //    Console.WriteLine(m.PhoneNumber);
            //    Console.WriteLine(m.Pass);
            //}
            ////----הדפסת מנהל לפי Id-----
            //Manager managerById = ManagerDB.SelectById(21);
            //if (managerById != null)
            //{
            //    Console.WriteLine(managerById.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("Manager not found");
            //}

            //// ----Insert----
            //Manager newManager = new Manager()
            //{
            //    FirstName = "דוד",
            //    LastName = "כהן",
            //    PhoneNumber = "0501233215",
            //    Email = "davidCohen67@gmail.com",
            //    Pass = "David@Cohen01"
            //};
            //mdb.Insert(newManager);
            //int x = mdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            ////----Delete----
            //Manager managerToDelete = mList.Last();
            //mdb.Delete(managerToDelete);
            //int y = mdb.SaveChanges();
            //Console.WriteLine($"{y} rows deleted");
            //// ----Update----
            //Manager managerToUpdate = mList[3];
            //managerToUpdate.FirstName = "נטע";
            //mdb.Update(managerToUpdate);
            //int x = mdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

            #region TeacherDB

            //TeacherDB tdb = new();
            //TeacherList tList = tdb.SelectAll();
            //foreach (Teacher t in tList)
            //{
            //    Console.WriteLine(t.Id);
            //    Console.WriteLine(t.FirstName);
            //    Console.WriteLine(t.LastName);
            //    Console.WriteLine(t.Email);
            //    Console.WriteLine(t.PhoneNumber);
            //    Console.WriteLine(t.Pass);
            //    Console.WriteLine(t.City.CityName);
            //    Console.WriteLine(t.CarType.CarTypeName);
            //    Console.WriteLine(t.PricePerLesson);
            //    Console.WriteLine(t.IdManager.Id);
            //    Console.WriteLine(t.Status.Id);
            //}
            //// ---- הדפסת מורה לפי Id ----
            //Teacher teacherById = TeacherDB.SelectById(4);
            //if (teacherById != null)
            //{
            //    Console.WriteLine(teacherById.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("Teacher not found");
            //}

            // ---- Insert ----
            //Teacher newTeacher = new Teacher()
            //{
            //    FirstName = "מיכל",
            //    LastName = "שמש",
            //    Email = "MichalShemesh84@gmail.com",
            //    PhoneNumber = "0501238426",
            //    Pass = "Michal@Shemesh26",
            //    City = CityDB.SelectById(4),
            //    CarType = CarTypeDB.SelectById(2),
            //    PricePerLesson = 210,
            //    IdManager = ManagerDB.SelectById(22),
            //    Status = StatusDB.SelectById(1)
            //};
            //tdb.Insert(newTeacher);
            //int x = tdb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ---- Delete ----
            //Teacher teacherToDelete = tList.Last();
            //tdb.Delete(teacherToDelete);
            //int x = tdb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ---- Update ----
            //Teacher teacherToUpdate = tList[1];
            //teacherToUpdate.FirstName = "עדי";
            //tdb.Update(teacherToUpdate);
            //int x = tdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            //Teacher teacherToUpdate = TeacherDB.SelectById(48);

            //if (teacherToUpdate != null)
            //{
            //    teacherToUpdate.FirstName = "שירה";
            //    teacherToUpdate.LastName = "חזות";
            //    teacherToUpdate.Email = "ShiraHazut44@gmail.com";
            //    teacherToUpdate.PhoneNumber = "0535741298";
            //    teacherToUpdate.Pass = "Shira@Hazut44";

            //    tdb.Update(teacherToUpdate);
            //    int x = tdb.SaveChanges();

            //    Console.WriteLine($"{x} rows were updated");
            //}
            //else
            //{
            //    Console.WriteLine("Student not found");
            //}

            #endregion

            #region LessonsDB

            //LessonsDB ldb = new();
            //LessonsList lList = ldb.SelectAll();
            //foreach (Lessons l in lList)
            //{
            //    Console.WriteLine(l.Id);
            //    Console.WriteLine(l.IdStudent.Id);
            //    Console.WriteLine(l.IdTeacher.Id);
            //    Console.WriteLine(l.LessonDate);
            //    Console.WriteLine(l.LessonTime);
            //    Console.WriteLine(l.Topics.TopicName);
            //    Console.WriteLine(l.Notes);
            //    Console.WriteLine(l.LessonStatus.LessonStatusName);
            //}
            ////----הדפסת שיעור לפי Id----
            //Lessons lessonById = LessonsDB.SelectById(3);
            //if (lessonById != null)
            //{
            //    Console.WriteLine(lessonById.Id);
            //    Console.WriteLine(lessonById.LessonDate);
            //}
            //else
            //{
            //    Console.WriteLine("Lesson not found");
            //}

            ////----Insert----
            //Lessons newLesson = new Lessons()
            //{
            //    IdStudent = StudentDB.SelectById(12),
            //    IdTeacher = TeacherDB.SelectById(4),
            //    LessonDate = new DateTime(2026, 10, 20),
            //    LessonTime = DateTime.Today.AddHours(10),
            //    Topics = TopicsDB.SelectById(1),
            //    Notes = "שיעור ראשון",
            //    LessonStatus = LessonStatusDB.SelectById(1)
            //};
            //ldb.Insert(newLesson);
            //int x = ldb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //Lessons newLesson2 = new Lessons()
            //{
            //    IdStudent = StudentDB.SelectById(13),
            //    IdTeacher = TeacherDB.SelectById(4),
            //    LessonDate = new DateTime(2026, 10, 21),
            //    LessonTime = DateTime.Today.AddHours(12),
            //    Topics = TopicsDB.SelectById(2),
            //    Notes = "שיעור תרגול נוסף",
            //    LessonStatus = LessonStatusDB.SelectById(1)
            //};
            //ldb.Insert(newLesson2);
            //ldb.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            //// ---- Delete ----
            //Lessons lessonToDelete = lList.Last();
            //ldb.Delete(lessonToDelete);
            //int x = ldb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ---- Delete2 ----
            //Lessons lessonToDelete = LessonsDB.SelectById(13);
            //ldb.Delete(lessonToDelete);
            //int x = ldb.SaveChanges();
            //Console.WriteLine($"{x} rows deleted");
            //// ---- Update ----
            //Lessons lessonToUpdate = lList[1];
            //lessonToUpdate.Notes = "שיעור ראשון";
            //ldb.Update(lessonToUpdate);
            //int x = ldb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");

            #endregion

        }
    }
}
