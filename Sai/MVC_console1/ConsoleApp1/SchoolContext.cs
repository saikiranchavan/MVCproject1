using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ConsoleApp1
{
    class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolDB1")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
        }     
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
         
    }
}
