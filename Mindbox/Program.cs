using System;
using System.Collections.Generic;
using MindboxLib;
using System.Linq;


namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<BaseShape>
            {
                new Triangle(3, 4, 5),
                new Circle(1),
                new Triangle(2, 3, 4),
                new CustomShape(x => x.First() * x.First(), 9)
            };

            foreach (var el in list)
            {
                Console.WriteLine($"{el.GetType()} \tarea: {el.GetArea()} \t\t{(el as Triangle)?.IsRight()}");
            }
            
            Console.ReadKey();
        }
    }
}
