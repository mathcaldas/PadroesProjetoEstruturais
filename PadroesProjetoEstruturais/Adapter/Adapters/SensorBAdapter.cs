using Adapter.Interfaces;
using Adapter.Sensors;

namespace Adapter.Adapters;

public class SensorBAdapter : ITemperatureSensor 
{ 
    private readonly SensorB _sensorB = new();

    public float ReadTemperature() 
    {
        return _sensorB.ObtenerTemperaturaEnCentigrados();
    }
}