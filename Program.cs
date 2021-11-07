using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApplication32
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw red rectangle");
        }
    }
    internal class Program
    {
        
        public static void Main(string[] args)
        {

            var circle = new Circle();
            circle.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();





        }
    }
}