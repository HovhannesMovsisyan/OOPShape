using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1OOPHomework
{
    static class TotalAreaAndPerimeter//Часть 2
    {
        public static double TotalArea(List<Figure> figures)
        {
            double areaOfFirstMember = figures[0].FigureArea();
            for (int i = 0; i < figures.Count - 1; i++)
            {
                areaOfFirstMember += figures[i + 1].FigureArea();
            }
            return areaOfFirstMember;
        }
        public static double TotalPerimeter(List<Figure> figures)
        {
            double perimeterOfFirstMember = figures[0].FigurePerimeter();
            for (int i = 0; i < figures.Count - 1; i++)
            {
                perimeterOfFirstMember += figures[i + 1].FigurePerimeter();
            }
            return perimeterOfFirstMember;
        }
        public static void PrintTotalSum(List<Figure> figures)
        {
            Console.WriteLine($" The total area of given figures is {TotalArea(figures)}, and total perimeter is {TotalPerimeter(figures)}");
        }
    }
}
