using Core;
using Core.Engines;
using Core.Interfaces.Engines;
using System;
using System.IO.Ports;

namespace CLI
{
    public static class Interface
    {
        private static IEngine _engine;

        public static void Configure(IEngine engine)
        {
            _engine = engine;
        }

        public static void RequestAuthentication()
        {
            Console.Write("Username: ");
            GlobalVars.ServerUsername = Console.ReadLine();
            Console.Write("Password: ");
            GlobalVars.ServerPassword = Console.ReadLine();
            GlobalVars.DefaultTemperatureMU = "°C";
            GlobalVars.DefaultHumidityMU = "%";
            Console.Clear();
        }

        public static void ShowData()
        {
            var datas = _engine.GetData();

            if (datas == null || datas.Count == 0)
            {
                return;
            }

            for (int i = datas.Count; i >= 0; i--)
            {
                Console.WriteLine($"{datas[0].Read} - {datas[0].Temperature}{datas[0].TemperatureMU}\t{datas[0].Humidity}{datas[0].HumidityMU}");
            }
        }

        public static void ShowHighestLowest()
        {
            double highest = _engine.GetHighestTemperature();
            double lowest = _engine.GetLowestTemperature();

            Console.WriteLine($"\tMin.: {lowest}\t\tMax.: {highest}");
        }
    }
}
