using System;
using System.Collections.Generic;
using System.Text;

namespace ChineseSchoolAdminSystem
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
