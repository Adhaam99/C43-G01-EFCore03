using Assignment.DbContext;
using Assignment.Models;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region Adding Topic
            //Topic Top01 = new Topic { Name = "C# Basics" };

            //dbContext.Topics.Add(Top01); 
            #endregion

            //Course Crs01 = new Course { Name = "Intro to C# Basics", Top_ID = 1 , Duration = 24 , Description = "How to use C#" };

            //dbContext.Courses.Add(Crs01);

            #region Adding Student
            //Student  Std01 = new Student { FName = "Adham", LName = "Yehia" , Age = 20, Address = "Mit Alataar"  };

            //dbContext.Students.Add(Std01); 
            #endregion

            dbContext.SaveChanges();
        }
    }
}
