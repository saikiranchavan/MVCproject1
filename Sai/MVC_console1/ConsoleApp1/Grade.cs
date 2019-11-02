using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
