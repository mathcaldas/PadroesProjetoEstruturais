namespace Bridge.Colors;

using Bridge.Interfaces;

public class RedColor : IColor 
{
    public void ApplyColor() 
    {
        Console.WriteLine("Applying red color.");
    }
}