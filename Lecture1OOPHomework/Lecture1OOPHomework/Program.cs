using System;
using System.Collections.Generic;

namespace Lecture1OOPHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Circule circule = new Circule(5.0);//Часть 1
                //circule.PrintFigureAreaAndPerimeter();//Часть 1
                //Rectangle rectangle = new Rectangle(2.3, 3.5);//Часть 1
                //rectangle.PrintFigureAreaAndPerimeter();//Часть 1

                Triangle triangle = new Triangle(2, 3, 4, 5);//Часть 3
                triangle.PrintFigureAreaAndPerimeter();//Часть 3
                Square square = new Square(5.3);//Часть 3
                square.PrintFigureAreaAndPerimeter();//Часть 3
                Trapezium trapezium = new Trapezium(2.4, 2.1, 1, 8.1, 7.3);//Часть 3
                trapezium.PrintFigureAreaAndPerimeter();//Часть 3
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //List<Figure> figures =new List<Figure>
            //{ 
            //    new Circule(2.4), 
            //    new Circule(2.1), 
            //    new Rectangle(2.2, 2), 
            //    new Rectangle(2, 2.9) 
            //};//Часть 2
            //TotalAreaAndPerimeter.PrintTotalSum(figures);//Часть 2


        }
    }
}
