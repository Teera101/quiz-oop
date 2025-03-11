using System;
using System.Collections.Generic;

namespace studentInfomation
{
    internal class Teacher : Person
    {
        public string Department { get; private set; }
        private List<Student> students;

        public Teacher(string name, string department)
            : base(name) // สืบทอด Name จาก Person
        {
            Department = department;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public Student? GetTopStudent()
        {
            return students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }

        public override string GetInfo()
        {
            return $"อาจารย์: {Name}, ภาควิชา: {Department}";
        }
    }
}
