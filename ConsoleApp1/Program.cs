using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(-5);
            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine(circle.Square());
            Console.WriteLine(triangle.Square());
        }
    }
}
