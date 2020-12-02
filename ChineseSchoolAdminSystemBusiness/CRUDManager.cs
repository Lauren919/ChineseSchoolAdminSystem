using System;
using ChineseSchoolAdminSystem;
using System.Collections.Generic;
using System.Linq;

namespace ChineseSchoolAdminSystemBusiness
{
    class CRUDManager
    {
        static void Main(string[] args)
        {
           
        }

        public Student SelectedStudent { get; set; }
        public Teacher SelectedTeacher { get; set; }


        public void SetSelectedStudent(object selectedItem)
        {
            SelectedStudent = (Student)selectedItem;
        }

        public void SetSelectedTeacher(object selectedItem)
        {
            SelectedTeacher = (Teacher)selectedItem;
        }


        public List<Student> RetrieveAllStudents()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                return db.Students.ToList();
            }
        }

        public List<Teacher> RetrieveAllTeachers()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                return db.Teachers.ToList();
            }
        }


        public void AddStudent (int studentID, string firstName, string lastName, DateTime dateOfBirth, int age, string allergies,
            string parentName, string parentContactNumber, string parentEmail, int classID)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var newStudent = new Student
                {
                    StudentId = studentID,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    Age = age,
                    Allergies = allergies,
                    ParentName = parentName,
                    ParentContactNumber = parentContactNumber,
                    ParentEmail = parentEmail,
                    ClassId = classID
                };

                db.Students.Add(newStudent);
                db.SaveChanges();
            }
        }

        public void AddTeacher (int teacherID, string firstName, string lastName, string email)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var newTeacher = new Teacher
                {
                    TeacherId = teacherID,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email
                };

                db.Teachers.Add(newTeacher);
                db.SaveChanges();
            }
        }
    }
}
