using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = new List<string>();
            participants.Add("A1");
            participants.Add("A2");
            participants.Add("A3");

            List<string> tempParts = new List<string>();
            foreach (var item in participants)
            {
                if (item.EndsWith("2"))
                {
                    tempParts.Add(item);
                }
            }

            foreach (var item in tempParts)
            {
                participants.Remove(item);
            }

            participants.ForEach(p => Console.WriteLine(p));


            //ArrayList oldParticipants = new ArrayList();
            Student student = new Student();
            foreach (var item in student.Courses)
            {

            }
            //  student.Course

            ClassRoom classRoom = new ClassRoom();
            classRoom.AddStudent(new Student { Id = 1, Name = "Serhat" });
            classRoom.AddStudent(new Student { Id = 1, Name = "Sedanur" });
            classRoom.AddStudent(new Student { Id = 3, Name = "Kadir" });

            Stack<string> lifo = new Stack<string>();
            lifo.Push("a");
            lifo.Push("b");
            lifo.Push("c");

            while (lifo.Count>0)
            {
                Console.WriteLine(lifo.Pop());
            }

            Queue<string> mailAddress = new Queue<string>();
            mailAddress.Enqueue("a@b.com");
            mailAddress.Enqueue("x@b.com");
            mailAddress.Enqueue("d@b.com");

            while (mailAddress.Count >0)
            {
                Console.WriteLine(mailAddress.Dequeue());
            }





        }

        public class ClassRoom
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            public void AddStudent(Student student)
            {
                if (students.ContainsKey(student.Id))
                {
                    Console.WriteLine("Bu id zaten var!");
                    return;
                }

                students.Add(student.Id, student);
            }

            public Student FindStudentById(int id)
            {
                var student = new Student();
                var isExist = students.TryGetValue(id, out student);
                if (isExist)
                {
                    return student;
                }
                else
                {
                    Console.WriteLine("Öğrenci bulunamadı");
                    return null;
                }
            }
        }
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IEnumerable<Course> Courses { get; set; } = new List<Course>();
        }

        public class Course
        {
            public string Name { get; set; }
        }
    }
}
