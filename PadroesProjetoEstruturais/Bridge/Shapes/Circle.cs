using Bridge.Interfaces;

namespace Bridge.Shapes
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            _color.ApplyColor();
            Console.WriteLine("Drawing a circle.");
        }
    }
}