namespace Bridge.Shapes;

public class Square : Shape
{
    public Square(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
    }
}