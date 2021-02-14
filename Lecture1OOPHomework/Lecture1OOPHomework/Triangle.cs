using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1OOPHomework
{
    class Triangle : Figure//Часть 3
    {
        private double firstSide;
        private double secondSide;
        private double baseSide;
        private double height;

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
        public double BaseSide
        {
            get => baseSide;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    baseSide = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new Exception("Please insert valid number for input");
                else
                    height = value;
            }
        }
        public Triangle(double firstside, double secondside,double baseside, double height)
        {
            FirstSide = firstside;
            SecondSide = secondside;
            BaseSide = baseside;
            Height = height;
        }
        
        public override double FigureArea() => (baseSide * height)/2;

        public override double FigurePerimeter() => firstSide + secondSide + baseSide;

        public override void PrintFigureAreaAndPerimeter()
        {
            Console.WriteLine($"The Triangle's Area is {FigureArea()} and Perimeter is {FigurePerimeter()}!!!");
        }
    }
}
