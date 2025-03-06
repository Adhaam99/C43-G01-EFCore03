using Assignment.DbContext;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region Adding Data

            #region Adding Topic
            //Topic Top01 = new Topic { Name = "C# Basics" };

            //dbContext.Topics.Add(Top01);
            #endregion

            #region Adding Course
            //Course Crs01 = new Course { Name = "Intro to C# Basics", Top_ID = 1, Duration = 24, Description = "How to use C#" };

            //dbContext.Courses.Add(Crs01); 
            #endregion

            #region Adding Student
            //Student Std01 = new Student { FName = "Adham", LName = "Yehia", Age = 20, Address = "Mit Alataar" , Dept_ID = 10 };

            //dbContext.Students.Add(Std01);

            //Student Std02 = new Student { FName = "Khaled", LName = "Ahmed", Age = 18, Address = "Giza", Dept_ID = 10 };

            //dbContext.Students.Add(Std02);
            #endregion

            #region Adding Instructor
            //Instructor Inst01 = new Instructor { Name = "Khaled Ahmed", Address = "Cairo", Dep_ID = 10 , Bouns = 20 , HourRate = 250 , Salary = 5000  };

            //dbContext.Instructors.Add(Inst01);
            #endregion

            //Course_Inst Crs_Inst01 = new Course_Inst { Course_ID = 1, Inst_ID = 1 };

            //dbContext.Course_Insts.Add(Crs_Inst01);

            //Stud_Course Stud_Crs01 = new Stud_Course { Stud_ID = 1, Course_ID = 1, Grade = 90 };

            //dbContext.stud_Courses.Add(Stud_Crs01); 

            #endregion

            #region Select

            //var Student = dbContext.Students.Where(S => S.ID == 1).FirstOrDefault();

            //Console.WriteLine(Student);

            #endregion

            #region Update

            ////var Student = dbContext.Students.Where(S => S.ID == 2).FirstOrDefault();

            ////Console.WriteLine(Student.Address);

            ////Student.Address = "Cairo";

            ////dbContext.SaveChanges();

            ////Student = dbContext.Students.Where(S => S.ID == 2).FirstOrDefault();

            ////Console.WriteLine(Student.Address);

            //var Dept01 = dbContext.Departments.Where(D => D.ID == 10).FirstOrDefault();

            //Dept01.Ins_ID = 1;

            //dbContext.SaveChanges();

            #endregion

            #region Delete

            //var Student = dbContext.Students.Where(S => S.ID == 2).FirstOrDefault();

            //dbContext.Students.Remove(Student);

            //dbContext.SaveChanges();

            #endregion

            #region Try Eager Loading

            //var Student01WithDept = dbContext.Students.Include(S => S.Department).ThenInclude( D => D.Manager).Where(S => S.ID == 1).FirstOrDefault();

            //if (Student01WithDept is not null)
            //{
            //    Console.WriteLine($"Student Dept Name : {Student01WithDept.Department.Name}");
            //    Console.WriteLine("=================================");
            //    Console.WriteLine($"Dept Manager Name : {Student01WithDept.Department.Manager.Name}");

            //}

            #endregion

            #region Try Lazy Loading
            //var Std01WithCourses = dbContext.Students.FirstOrDefault(S => S.ID == 1);

            //if (Std01WithCourses is not null )
            //{
            //    Console.WriteLine($"Student Name : {Std01WithCourses.FName}");
            //    Console.WriteLine("=================================");
            //    foreach (var item in Std01WithCourses.Stud_Courses)
            //    {
            //        Console.WriteLine($"Course Name : {item.Course.Name}");
            //    }
            //}
            #endregion

        }
    }
}
