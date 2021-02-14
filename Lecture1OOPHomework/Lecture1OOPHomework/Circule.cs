using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1OOPHomework
{
    class Circule : Figure//Часть 1
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    radius = value;
            }
        }
        public Circule(double radius)=> Radius = radius;

        public override double FigureArea()=> 3.14 * radius * radius;
    

        public override double FigurePerimeter()=> 2 * 3.14 * radius;
  
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Circule's Area is {FigureArea()} and Perimeter is {FigurePerimeter()}!!!");
        }
    }
}
