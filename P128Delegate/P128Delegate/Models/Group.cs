using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P128Delegate.Models
{
    class Group
    {
        List<Student> Students { get; set; }

        public Group()
        {
            Student student = new Student { };

            Students = new List<Student>
            {
                new Student{Name="Murad",SurName="Abdullayev",Age = 22},
                new Student{Name="Seid",SurName="Zahidov",Age = 17},
                new Student{Name="Rehman",SurName="Vahabov",Age = 19},
                new Student{Name="Metin",SurName="Nejefov",Age = 55},
                new Student{Name="Surxay",SurName="Sxiyev",Age = 21},
                new Student{Name="Leman",SurName="Memmedli",Age = 22},
                new Student{Name="Ziver",SurName="Babayeva",Age = 22},
                new Student{Name="Vasif",SurName="Haciyev",Age = 22},
                new Student{Name="Serxan",SurName="Kerimov",Age = 30},
                new Student{Name="Hamid",SurName="Mammadov",Age = 31}
            };

        }

        public List<Student> GetStudents(string search)
        {
            //List<Student> students = new List<Student>();

            //foreach (Student student in Students)
            //{
            //    if (predicate(student))
            //    {
            //        students.Add(student);
            //    }
            //}

            //return students;

            List<Student> students = Students.FindAll(s=>s.Name.ToLower().Contains(search));
            Console.WriteLine("1-ci");
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }

            Student student = Students.Find(s=>s.Name.ToLower().Contains(search));
            Console.WriteLine("2-ci");
            Console.WriteLine(student);


            bool check = Students.Exists(s=>s.Name.ToLower().Contains(search));
            Console.WriteLine("3-cu");
            Console.WriteLine(check);


            int index = Students.FindLastIndex(3,2,s=>s.Age == 55);
            Console.WriteLine("4-cu");
            Console.WriteLine(index);

            Students.ForEach(s => Console.WriteLine(s));

            return students;
        }

        //public List<Student> FindByNameAndSurName(string name, string surname)
        //{
        //    List<Student> students = new List<Student>();

        //    foreach (Student student in Students)
        //    {
        //        if (student.Name.ToLower() == name.ToLower() && student.SurName.ToLower() == surname.ToLower())
        //        {
        //            students.Add(student);
        //        }
        //    }

        //    return students;
        //}
    }
}
