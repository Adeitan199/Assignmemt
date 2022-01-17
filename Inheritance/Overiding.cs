using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    class Overiding
    {
       

    }

    public class Shape
    {
        public string shape;
        public int width;
        public int breadth;

        //Method Overriding

        public virtual int CalculateArea(int width, int breadth)
        {
            return width * breadth;
        }
    }

    public class Triangle : Shape
    {
        public int height;

        public override int CalculateArea(int width, int breadth)
        {
            return width * breadth * height;
        }
    }


    //OverLoading
    public class Shapes
    {
        public string shape;
        public int width;
        public int breadth;


        public int CalculateArea(int width, int breadth)
        {
            return width * breadth;
        }
    }

    public class Triangles : Shape
    {
        public int height;

        public int CalculateArea(int width, int breadth, int height)
        {
            return width * breadth * height;
        }

    }

    //Method Hiding
    public class Hide
    {

        public string name;
        //Method Hiding(Parent)
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    public class Hiding
    {
        public string name;
        // Method Hiding Derived
        public new void SayHello()
        {
            Console.WriteLine($"Hello {name}");
        }

    }

    public abstract class shape
    {
        public int Width;
        public int Breadth;

        public shape (int width, int breadth)
        {
            this.Width = width;
            this.Breadth = breadth;
        }

        public virtual int CalArea(int widht, int breadth)
        {
            return Width * breadth; 
        }
    }

}
