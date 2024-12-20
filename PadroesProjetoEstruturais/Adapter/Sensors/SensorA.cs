namespace Adapter.Sensors;

public class SensorA 
{
    public float GetTemperatureInCelsius() 
    {
        return new Random().Next(-10, 30);
    }
}