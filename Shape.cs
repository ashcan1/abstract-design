using System;

namespace ConsoleApplication32
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("copy to clipboard");
        }

        public void Select()
        {
            Console.WriteLine("select the shape");
        }


    }
}