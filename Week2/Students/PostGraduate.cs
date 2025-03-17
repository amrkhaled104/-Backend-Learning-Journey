using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class PostGraduate : Student
    {
        public string ThesisTopic { get; set; }
        public new void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Topics: {ThesisTopic}");
        }

    }
}
