using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class SchoolDBInitializer:DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Grade> grades = new List<Grade>();
            grades.Add(new Grade() { GradeName = "Grade1", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade2", Section = "B" });
            grades.Add(new Grade() { GradeName = "Grade3", Section = "C" });
            grades.Add(new Grade() { GradeName = "Grade4", Section = "D" });

            context.Grades.AddRange(grades);
            base.Seed(context);
        }
    }
}
