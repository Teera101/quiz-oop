using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static studentInfomation.Student;

namespace studentInfomation
{
    internal class Teacher
    {
        public string Name { get; private set; }
        public string Department { get; private set; }
        private List<Student> students; // รายชื่อนักศึกษาที่ที่ปรึกษา

        public Teacher(string name, string department)
        {
            Name = name;
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
    }
}
