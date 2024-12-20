using Bridge.Interfaces;

namespace Bridge.Shapes
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            _color.ApplyColor();
            Console.WriteLine("Drawing a square.");
        }
    }
}