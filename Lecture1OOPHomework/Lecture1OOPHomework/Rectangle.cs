using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1OOPHomework
{
    class Rectangle : Figure//Часть 1
    {
        private double firstSide;
        private double secondSide;

        public double FirstSide
        {
            get => firstSide;

            set
            {
                if (value <= 0) 
                    throw new Exception("Please insert valid number for input");
                else
                    firstSide = value;
            }
        }
        public double SecondSide
        {
            get => secondSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    secondSide = value;
            }
        }
        public Rectangle(double firstside, double secondside)
        {
            FirstSide = firstside;
            SecondSide = secondside;
        }
        public override double FigureArea()=> firstSide * secondSide;
      
        public override double FigurePerimeter()=> 2 * (firstSide + secondSide);
   
        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Rectangles's Area is {FigureArea()} and Perimeter is {FigurePerimeter()}!!!");
        }
    }
}
