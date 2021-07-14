using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double length;
            double area;
            string inputLength;
            string inputWidth;

            Console.WriteLine("enter the length of the rectangle:");
            inputLength = Console.ReadLine();
            length = double.Parse(inputLength);

            Console.WriteLine("enter the width of the rectangle:");
            inputWidth = Console.ReadLine();
            width = double.Parse(inputWidth);

            area = width * length;
            Console.WriteLine("the rectangle area is:" + area);
            Console.ReadLine();
        }
    }
}