using Core.Interfaces.Engines;
using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace Core.Engines
{
    public static class Station
    {
        private static SerialPort _serialPort;
        private static IEngine _engine;

        public static SerialPort SerialPort { get => _serialPort; set => _serialPort = value; }
        public static IEngine Engine { get => _engine; set => _engine = value; }

        public static void Configure(IEngine engine)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM3";
            _serialPort.BaudRate = 9600;
            //_serialPort.DataReceived += new SerialDataReceivedEventHandler(RecieveData);
            _serialPort.Open();
            _engine = engine;
        }

        public static void RecieveData()
        {
            string json = _serialPort.ReadLine();
            _engine.PostAsync(json);
        }
    }
}