namespace Adapter.Sensors;

public class SensorC 
{
    public float FetchTempC() 
    {
        return new Random().Next(-10, 30);
    }
}