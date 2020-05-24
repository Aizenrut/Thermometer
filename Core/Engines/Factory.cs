using Core.Models;
using Newtonsoft.Json;
using System;

namespace Core.Engines
{
    public class Factory
    {
        public Data BuildData(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<Data>(json);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
