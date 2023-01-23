using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Student.Entities
{
    internal class Student
    {
        public string Name { get; set; }
        public double Grade1, Grade2, Grade3;
        public Student() { }

        public double FinalGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public string FinalStatus()
        {
            if (FinalGrade() >= 60)
            {
                return "APPROVED";
            }
            else
            {
                return "REPROVED\n" +
                    "You were " + (60 - FinalGrade()) + " points short of being approved";
            }
        }
    }
}
