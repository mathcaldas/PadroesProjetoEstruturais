using Adapter.Interfaces; 
using Adapter.Sensors;

namespace Adapter.Adapters;

public class SensorAAdapter : ITemperatureSensor 
{ 
    private readonly SensorA _sensorA = new();

    public float ReadTemperature() 
    {
        return _sensorA.GetTemperatureInCelsius();
    }
}
