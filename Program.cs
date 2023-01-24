using teacher.Models;
using teacher.Services;
using System.Text.RegularExpressions;

namespace teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeacherManager teacherManager = new TeacherManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add teacher"))
                {
                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        Firstname = "Elvin",
                        Lastname = "Cebrayilov",
                        Age = 25,
                        Course = 2,
                        EntryDate = DateTime.Now,
                        Group = new Models.Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    };
                    var teacher2 = new Teacher
                    {
                        Id = 2,
                        Firstname = "Sahlar",
                        Lastname = "Haciyev",
                        Age = 24,
                        Course = 1,
                        EntryDate = DateTime.Now,
                        Group = new Models.Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    };

                    teacherManager.Add(teacher1);
                    teacherManager.Add(teacher2);

                }
                else if (command.ToLower().Equals("print teachers"))
                {
                    teacherManager.Print();
                }
                else if (command.ToLower().Equals("delete teacher"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }
                else if (command.ToLower().Equals("update "))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    if (existTeacher == null)
                        continue;

                    Console.WriteLine(existTeacher);

                    var teacher2 = new Teacher
                    {
                        Id = 2,
                        Firstname = "Sahlar",
                        Lastname = "Haciyev",
                        Age = 25,
                        Course = 1,
                        EntryDate = DateTime.Now,
                        Group = new Models.Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    };

                    teacherManager.Update(id, teacher2);
                }

            } while (command.ToLower() != "quit");
        }
    }
}
