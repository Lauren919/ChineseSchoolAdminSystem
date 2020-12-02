using NUnit.Framework;
using ChineseSchoolAdminSystemBusiness;
using ChineseSchoolAdminSystem;
using System.Linq;
using System.Collections.Generic;

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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
