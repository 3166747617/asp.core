using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManage.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StuName { get; set; }
        public int StuNumber { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public string Pwd { get; set; }
        public int PostId { get; set; }
        public int ProfessionalId { get; set; }
    }
}
