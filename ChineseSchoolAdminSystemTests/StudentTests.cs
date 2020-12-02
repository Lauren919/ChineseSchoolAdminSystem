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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}