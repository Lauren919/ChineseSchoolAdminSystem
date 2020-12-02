using NUnit.Framework;
using ChineseSchoolAdminSystemBusiness;
using ChineseSchoolAdminSystem;
using System.Linq;
using System.Collections.Generic;

namespace ChineseSchoolAdminSystemTests
{
    public class StudentTests
    {
        CRUDManager _crudManager = new CRUDManager();

        [SetUp]
        public void Setup()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var selectedStudent =
                from c in db.Students
                where c.StudentId == 7
                select c;


                foreach (var c in selectedStudent)
                {
                    db.Students.Remove(c);
                }

                db.SaveChanges();
            }
        }

        [TearDown]
        public void Teardown()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var selectedStudent =
                from c in db.Students
                where c.StudentId == 7
                select c;


                foreach (var c in selectedStudent)
                {
                    db.Students.Remove(c);
                }

                db.SaveChanges();
            }
        }

        [Test]
        public void NumberOfStudentsIncreasesBy1WhenNewStudentIsAdded()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var numberOfStudentsBefore = db.Students.Count();
                _crudManager.AddStudent(7, "Lauren", "Pang", 22, "N/A", "Emy Chung", "07123112233", "EChung@gmail.com", 6);
                var numberOfStudentsAfter = db.Students.Count();
                Assert.AreEqual(numberOfStudentsAfter, numberOfStudentsBefore + 1);
            }
        }

        [Test]
        public void CheckAllInformationIsCorrectedWhenNewStudentIsAdded()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                _crudManager.AddStudent(7, "Lauren", "Pang", 22, "N/A", "Emy Chung", "07123112233", "EChung@gmail.com", 6);

                var newStudent = from s in db.Students
                                  where s.StudentId == 7
                                  select s;
                foreach (var s in newStudent)
                {
                    Assert.AreEqual("Lauren", s.FirstName);
                    Assert.AreEqual("Pang", s.LastName);
                    Assert.AreEqual(22, s.Age);
                    Assert.AreEqual("N/A", s.Allergies);
                    Assert.AreEqual("Emy Chung", s.ParentName);
                    Assert.AreEqual("07123112233", s.ParentContactNumber);
                    Assert.AreEqual("EChung@gmail.com", s.ParentEmail);
                    Assert.AreEqual(6, s.ClassId);
                }
            }
        }
    }
}