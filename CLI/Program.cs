using Core;
using Core.Engines;
using Core.Models;
using System;
using System.Threading;

namespace CLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Interface.RequestAuthentication();

            var engine = new Engine();
            Station.Configure(engine);
            Interface.Configure(engine);

            while (true)
            {
                Station.RecieveData();
                Console.Clear();
                Interface.ShowHighestLowest();
                Console.WriteLine();
                Interface.ShowData();

                Thread.Sleep(3000);
            }
        }
    }
}
