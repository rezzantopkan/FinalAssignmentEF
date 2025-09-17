using System;
using FinalAssignmentEF;

namespace FinalAssignmentEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                var student = new Student { Name = "John Smith", Age = 20 };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student has been successfully added!");
            }
        }
    }
}
