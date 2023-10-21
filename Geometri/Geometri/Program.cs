using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Square square = new Square();
           Console.WriteLine($"{square.Area()}: is the area of the square. ");

            Circle circle = new Circle();
            Console.WriteLine($"{circle.Area()}: is the area of the circle");

            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"{rectangle.Area()}: is the area of the rectangle");

            Parallellogram parallellogram = new Parallellogram();
            Console.WriteLine($"{parallellogram.Area()}: is the area of the parallellogram. ");

            Ellipse ellipse = new Ellipse();
            Console.WriteLine($"{ellipse.Area()}: is the area of the ellipse. ");




        }
    }
}
