using System;

namespace Shapes
{

    /*
     *  
     *  
     * 
     */
    class HW3Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 3);
            Square square = new Square(5,5);

            //Use a collection of Shape objects and display their dimensions and area.

           triangle.CalculateArea();
            triangle.DisplayShapeData();

            square.CalculateArea();
            square.DisplayShapeData();

            
        }
    }

    public abstract class Shape //Create a class called Shape that cannot be instantiated.
    {

        //Include some attributes that most shapes have such as height, width, area, etc.
        public int _height { get; set; }
        public int _width { get; set; }
        public int area { get; set; }

        public abstract void CalculateArea();

        public void DisplayShapeData()
        {
            Console.WriteLine($"Height: {_height}\nWidth: {_width}\nArea: {area}");
        }
        

        
    }

    //Then create two different Types of shapes that calculate their area correctly.
    public class Triangle : Shape
    {
        public Triangle(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public override void CalculateArea()
        {
            
            area = (_height * _width) / 2;
        }
    }

    public class Square : Shape
    {
        public Square(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public override void CalculateArea()
        {
            area = _height * _width;
        }
    }
}
