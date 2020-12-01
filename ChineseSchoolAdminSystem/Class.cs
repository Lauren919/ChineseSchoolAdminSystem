using System;
using System.Collections.Generic;

#nullable disable

namespace ChineseSchoolAdminSystem
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int TeacherId { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
