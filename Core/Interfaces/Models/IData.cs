using System;

namespace Core.Interfaces.Models
{
    public interface IData
    {
        public int DataId { get; set; }
        public DateTime Read { get; set; }
        public double Temperature { get; set; }
        public string TemperatureMU { get; set; }
        public double Humidity { get; set; }
        public string HumidityMU { get; set; }
    }
}
