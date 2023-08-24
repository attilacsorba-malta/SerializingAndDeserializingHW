using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingAndDeserializingHW
{
    public class Course
    {
        public string Name { get; set; }
        public string Grade { get; set; }

        public Course(string name, string grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
