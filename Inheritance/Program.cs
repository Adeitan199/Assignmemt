using System;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");


            Student Student1 = new Student("Ade", 14, 192104, 6.5);
            Student Student2 = new Student("Ayo", 16, 192105, 6.0);

            Student2.SetschoolCode(1234);

            Console.WriteLine("My name is " + Student2.Name + " I am "+ Student2.Age + " years old, " + "my Matric Number is "
                + Student2.MatricNo + " our school code is " + Student2.GetschoolCode());
*/

            Triangles triangle1  = new Triangles();
            //int x = triangle1.CalculateArea(6, 7,4);

            Console.WriteLine(triangle1.CalculateArea(2,4,3));
            
        }
    }
}
 