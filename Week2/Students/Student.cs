using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Student
    {
        public string Name { get; set; }
        public  double Age { get; set; }
        public  string Grade { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name : {this.Name}\nAge : {this.Age}\nGrade : {this.Grade}");
        }

    }
}
