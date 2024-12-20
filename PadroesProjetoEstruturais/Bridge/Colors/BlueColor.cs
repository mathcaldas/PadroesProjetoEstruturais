namespace Bridge.Colors;

using Bridge.Interfaces;

public class BlueColor : IColor
{
    public void ApplyColor()
    {
        Console.WriteLine("Applying blue color.");
    }
}