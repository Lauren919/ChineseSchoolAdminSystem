using NUnit.Framework;
using ChineseSchoolAdminSystemBusiness;
using ChineseSchoolAdminSystem;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace ChineseSchoolAdminSystemTests
{
    public class TeacherTests
    {
        CRUDManager _crudManager = new CRUDManager();

        [SetUp]
        public void Setup()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var selectedTeacher =
                from c in db.Teachers
                where c.TeacherId == 5
                select c;


                foreach (var c in selectedTeacher)
                {
                    db.Teachers.Remove(c);
                }

                db.SaveChanges();
            }
        }

        [TearDown]
        public void Teardown()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var selectedTeacher =
                from c in db.Teachers
                where c.TeacherId == 5
                select c;


                foreach (var c in selectedTeacher)
                {
                    db.Teachers.Remove(c);
                }

                db.SaveChanges();
            }
        }

        [Test]
        public void NumberOfTeachersIncreasesBy1WhenNewTeacherIsAdded()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var numberOfTeachersBefore = db.Teachers.Count();
                _crudManager.AddTeacher(5, "Alice", "Cheung", "ACheung@gmail.com");
                var numberOfTeachersAfter = db.Teachers.Count();
                Assert.AreEqual(numberOfTeachersAfter, numberOfTeachersBefore + 1);
            }
        }

        [Test]
        public void CheckAllInformationIsCorrectedWhenNewTeacherIsAdded()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                _crudManager.AddTeacher(5, "Alice", "Cheung", "ACheung@gmail.com");

                var newTeacher = from t in db.Teachers
                                 where t.TeacherId == 5
                                 select t;
                foreach (var s in newTeacher)
                {
                    Assert.AreEqual("Alice", s.FirstName);
                    Assert.AreEqual("Cheung", s.LastName);
                    Assert.AreEqual("ACheung@gmail.com", s.Email);
                }
            }
        }

        [Test]
        public void CheckAllInformationIsCorrectedWhenStudentInformationIsEdited()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var newTeacher = new Teacher
                {
                    TeacherId = 5,
                    FirstName = "Jo",
                    LastName = "Wong",
                    Email = "JoWong@email.com"
                };

                db.Teachers.Add(newTeacher);
                db.SaveChanges();

                _crudManager.EditTeacher(5, "Alice", "Cheung", "ACheung@gmail,com");


                var selectedTeacher = db.Teachers.Where(t => t.TeacherId == 5).FirstOrDefault();
                Thread.Sleep(2000);
                Assert.AreEqual("Alice", selectedTeacher.FirstName);
                Assert.AreEqual("Cheung", selectedTeacher.LastName);
                Assert.AreEqual("ACheung@gmail.com", selectedTeacher.Email);

            }
        }
    }
}
