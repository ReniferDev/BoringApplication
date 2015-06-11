using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;



namespace BoringApplication.Classes
{
    class UDP
    {
        private Socket _UdpSocket;

        private void udpSocketInit()
        {
            _UdpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }
    }
}
