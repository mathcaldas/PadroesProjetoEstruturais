namespace Bridge.Shapes;

using Bridge.Interfaces;

public abstract class Shape
{
    protected IColor _color;

    public Shape(IColor color)
    {
        _color = color;
    }
    
    public abstract void Draw();
}