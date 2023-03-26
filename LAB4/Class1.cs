using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Class1
    {
        private string name;
        private int age;
        private int birthYear;
        private double gpa;

        public Class1(string name, int bYear, double gpa)
        {
            this.name = name;
            this.birthYear = bYear;
            this.age = 2566 - bYear;
            this.gpa = gpa;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getName()
        {
            return this.name;
        }
        public int getbYear()
        {
            return this.birthYear;
        }
        public double getGPA()
        {
            return this.gpa;
        }
    }
}
