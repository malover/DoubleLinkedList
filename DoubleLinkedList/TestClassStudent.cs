using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class TestClassStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TestClassStudent(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
        }
    }
}
