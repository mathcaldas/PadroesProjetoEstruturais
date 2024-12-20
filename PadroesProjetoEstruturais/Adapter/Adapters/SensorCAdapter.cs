using Adapter.Interfaces;
using Adapter.Sensors;

namespace Adapter.Adapters;
public class SensorCAdapter : ITemperatureSensor
{
    private readonly SensorC _sensorC = new();

    public float ReadTemperature()
    {
        return _sensorC.FetchTempC();
    }
}