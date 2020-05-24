using Core.Models;
using System.Collections.Generic;

namespace Core.Interfaces.Engines
{
    public interface IEngine
    {
        public void PostAsync(string json);
        public IList<Data> GetData();
        public double GetHighestTemperature();
        public double GetLowestTemperature();
    }
}
