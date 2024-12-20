using System;
using Adapter.Sensors;
using Adapter.Adapters;
using Adapter.Interfaces;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITemperatureSensor sensorAAdapter = new SensorAAdapter();
            ITemperatureSensor sensorBAdapter = new SensorBAdapter();
            ITemperatureSensor sensorCAdapter = new SensorCAdapter();

            Console.WriteLine("Temperature from Sensor A: " + sensorAAdapter.ReadTemperature() + " °C");
            Console.WriteLine("Temperature from Sensor B: " + sensorBAdapter.ReadTemperature() + " °C");
            Console.WriteLine("Temperature from Sensor C: " + sensorCAdapter.ReadTemperature() + " °C");
        }
    }
}
