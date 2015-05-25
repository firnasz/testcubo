using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        private string welesudha;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double salary { get; set; }
        public int days { get; set; }
        public int AlMuradu { get; set; }

        public string getFullName()
        {
            return FirstName + " " + LastName;
        }

        public double getSalary()
        {
            return salary;
        }


    }
}
