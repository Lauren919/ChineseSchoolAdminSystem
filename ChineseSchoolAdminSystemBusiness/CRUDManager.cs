using System;
using ChineseSchoolAdminSystem;
using System.Collections.Generic;
using System.Linq;

namespace ChineseSchoolAdminSystemBusiness
{
    public class CRUDManager
    {
        static void Main(string[] args)
        {
           
        }

        public Student SelectedStudent { get; set; }
        public Teacher SelectedTeacher { get; set; }

        public Class SelectedClass { get; set; }


        public void SetSelectedStudent(object selectedItem)
        {
            SelectedStudent = (Student)selectedItem;
        }

        public void SetSelectedTeacher(object selectedItem)
        {
            SelectedTeacher = (Teacher)selectedItem;
        }

        public void SetSelectedClass(object selectedItem)
        {
            SelectedClass = (Class)selectedItem;
        }

        public List<Class> RetrieveAllClasses()
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                return db.Classes.ToList();
            }
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


        public void AddStudent (int studentID, string firstName, string lastName, int age, string allergies,
            string parentName, string parentContactNumber, string parentEmail, int classID)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var newStudent = new Student
                {
                    StudentId = studentID,
                    FirstName = firstName,
                    LastName = lastName,
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

        public void EditStudent (int studentID, string firstName, string lastName, int age, string allergies,
            string parentName, string parentContactNumber, string parentEmail, int classID)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                SelectedStudent = db.Students.Where(s => s.StudentId == studentID).FirstOrDefault();
                SelectedStudent.FirstName = firstName;
                SelectedStudent.LastName = lastName;
                SelectedStudent.Age = age;
                SelectedStudent.Allergies = allergies;
                SelectedStudent.ParentName = parentName;
                SelectedStudent.ParentContactNumber = parentContactNumber;
                SelectedStudent.ParentEmail = parentEmail;
                SelectedStudent.ClassId = classID;

                db.SaveChanges();
            }
        }

        public void EditTeacher(int teacherID, string firstName, string lastName, string email)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                SelectedTeacher = db.Teachers.Where(t => t.TeacherId == teacherID).FirstOrDefault();
                SelectedTeacher.FirstName = firstName;
                SelectedTeacher.LastName = lastName;
                SelectedTeacher.Email = email;

                db.SaveChanges();
            }
        }

        public void DeleteStudent(int studentID)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var selectedStudent = db.Students.Where(s => s.StudentId == studentID).FirstOrDefault();
                db.Students.Remove(selectedStudent);
                db.SaveChanges();
            }
        }

        public void DeleteTeacher(int teacherID)
        {
            using (var db = new ChineseSchoolAdminSystemContext())
            {
                var selectedTeacher = db.Teachers.Where(s => s.TeacherId == teacherID).FirstOrDefault();
                db.Teachers.Remove(selectedTeacher);
                db.SaveChanges();
            }
        }
    }
}
