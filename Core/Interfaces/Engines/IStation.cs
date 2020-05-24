using System.IO.Ports;
using System.Threading.Tasks;

namespace Core.Interfaces.Engines
{
    public interface IStation
    {
        public void GetData(object sender, SerialDataReceivedEventArgs e);
    }
}
