using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1OOPHomework
{
    class Square : Figure//Часть 3
    {
        private double side;

        public double Side
        {
            get => side;

            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    side = value;
            }
        }

        public Square(double side)
        {
            Side = side;
        }
        public override double FigureArea() => side * side;

        public override double FigurePerimeter() =>4* side;

        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Square's Area is {FigureArea()} and Perimeter is {FigurePerimeter()}!!!");
        }
    }
}
