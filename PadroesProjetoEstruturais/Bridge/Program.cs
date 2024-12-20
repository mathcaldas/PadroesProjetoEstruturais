using System;
using Bridge.Interfaces;
using Bridge.Colors;
using Bridge.Shapes;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IColor blue = new BlueColor();
            IColor red = new RedColor();

            Shape circle = new Circle(blue);
            Shape square = new Square(red);

            circle.Draw();
            square.Draw();
        }
    }
}