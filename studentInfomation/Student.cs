using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace studentInfomation
{
    internal class Student
    {
        public string StudentID { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }

        [Browsable(false)] //ซ่อน Advisor ที่เป็น Object ใน DataGridView
        public Teacher? Advisor { get; private set; }

        //เพิ่ม Property ที่แสดงเฉพาะชื่ออาจารย์ใน DataGridView
        public string AdvisorName => Advisor != null ? Advisor.Name : "ไม่มีที่ปรึกษา";

        public Student(string studentID, string name, string major)
        {
            StudentID = studentID;
            Name = name;
            Major = major;
            Advisor = null; // เริ่มต้นยังไม่มีที่ปรึกษา
        }

        public void AssignAdvisor(Teacher advisor)
        {
            if (Advisor == null)
            {
                Advisor = advisor;
                advisor.AddStudent(this);
            }
        }
    }
}