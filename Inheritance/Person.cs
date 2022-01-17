using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {

        public string Name;

        public int Age;

        public double weight;

        public string Gender;


    }

   


    public class Student: Person
    {
        public int MatricNo;
        public  double height;
        private int SchoolCode;


        public Student(string name, int age, int matricNo, double height)
        {
            Name = name;
            Age = age;
            MatricNo = matricNo;
        }

        public int GetschoolCode()
        {
            return this.SchoolCode;
        }
        public void SetschoolCode(int schoolCode)
        {
            this.SchoolCode = schoolCode;
        }
       


    }

}    
