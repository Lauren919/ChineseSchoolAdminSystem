using System;
using System.Collections.Generic;

#nullable disable

namespace ChineseSchoolAdminSystem
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Allergies { get; set; }
        public string ParentName { get; set; }
        public string ParentContactNumber { get; set; }
        public string ParentEmail { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
