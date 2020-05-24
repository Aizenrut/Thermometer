using System;
using Core.Interfaces.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Core.Models
{
    public class Data : IData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DataId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Read { get; set; }
        [JsonProperty("temperature")]
        public double Temperature { get; set; }
        public string TemperatureMU { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        public string HumidityMU { get; set; }

        public Data(DateTime Read, double temperature, string temperatureMU, double humidity, string humidityMU)
        {
            this.Read = Read;
            this.Temperature = temperature;
            this.TemperatureMU = temperatureMU;
            this.Humidity = humidity;
            this.HumidityMU = humidityMU;
        }

        [JsonConstructor]
        public Data(double temperature, double moisture)
        {
            this.Read = DateTime.Now;
            this.Temperature = temperature;
            this.TemperatureMU = GlobalVars.DefaultTemperatureMU;
            this.Humidity = moisture;
            this.HumidityMU = GlobalVars.DefaultHumidityMU;
        }
    }
}
