using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInfomation
{
    internal class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual string GetInfo()
        {
            return $"ชื่อ: {Name}";
        }
    }
}
