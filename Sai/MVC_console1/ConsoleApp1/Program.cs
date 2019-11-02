using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx=new SchoolContext())
            {
                ctx.Database.Connection.ConnectionString = @"Data Source=DESKTOP-JC15U0B\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True;MultipleActiveResultSets=True";
                var student = new Student() { StudentName = "bill" };
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo Completed");
            Console.ReadLine();
        }
    }
}
