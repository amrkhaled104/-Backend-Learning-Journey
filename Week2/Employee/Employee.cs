using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if ((value == 'M' || value == 'F')||(value == 'm' || value == 'f'))
                    _gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
            }
        }

        public override string ToString()
        {
            return String.Format("ID: {0}, Name: {1}, Gender: {2}, Security Level: {3}, Salary: {4:C}, Hire Date: {5:yyyy-MM-dd}",
                                 ID, Name, Gender, Security, Salary, HireDate);
        }
    }
}
