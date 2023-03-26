using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Classroom
    {
        private string name;
        private List<Class1> class1s = new List<Class1>();
        private int ageSum = 0;
        private Class1 min = null;
        private Class1 max = null;
        public Classroom(string name)
        {
         this.name = name;
        }

        public void addClass12Class(Class1 p)
        {
            this.class1s.Add(p);
            this.ageSum += p.getAge();

            if (max == null || p.getGPA() > max.getGPA())
            {
                this.max = p;
            }
            if (min == null || p.getGPA() < min.getGPA())
            {
                this.min = p;
            }
        }
        public string showallclass12inclass()
        {
            string result = "";
            foreach (Class1 p in this.class1s)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public int totalAge()
        {

            int result = 0;
            foreach (Class1 p in this.class1s)
            {

                result += +p.getAge();

            }
            return result;
        }

        public double avggpa()
        {
            double result = 0;
            int a = 0;
            foreach (Class1 p in this.class1s)
            {

                result = (result + p.getGPA());
                a = a + 1;
            }
            result = result / a;
            return result;
        }

        public string NMinGPA()
        {
            return this.min.getName();
        }
        public double MinGPA()
        {
            if (min == null)
            {
                return 0;
            }
            return this.min.getGPA();
        }
        public string NMaxGPA()
        {
            return this.max.getName();
        }
        public double MaxGPA()
        {
            if (max == null)
            {
                return 0; // 
            }
            return this.max.getGPA();
        }
        public int getPersonCount()
        {
            return this.class1s.Count;
        }
        public int getAgeSumaryOfThisClass()
        {
            return this.ageSum;
        }
        public double getAgeAverage()
        {
            return this.ageSum / this.class1s.Count;
        }
        public double GPAAverage()
        {
            double _avg = 0.0;
            foreach (Class1 p in this.class1s)
            {
                _avg += p.getGPA();
            }
            return _avg / this.class1s.Count;
        }
    }
}
