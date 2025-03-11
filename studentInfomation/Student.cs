using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace studentInfomation
{
    internal class Student : Person
    {
        public string StudentID { get; private set; }
        public double Grade { get; private set; }
        public string Major { get; private set; }
        public Teacher? Advisor { get; private set; }

        [Browsable(false)] //ซ่อน Advisor ที่เป็น Object ใน DataGridView
        public string AdvisorName => Advisor != null ? Advisor.Name : "ไม่มีที่ปรึกษา";

        public Student(string studentID, string name, string major, double grade)
            : base(name) //สืบทอด Name จาก Person
        {
            StudentID = studentID;
            Major = major;
            Grade = grade;
        }

        public void AssignAdvisor(Teacher advisor)
        {
            if (Advisor == null)
            {
                Advisor = advisor;
                advisor.AddStudent(this);
            }
        }

        public override string GetInfo()
        {
            return $"นักศึกษา: {Name}, รหัส: {StudentID}, สาขา: {Major}, เกรดเฉลี่ย: {Grade}";
        }
    }
}