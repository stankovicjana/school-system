using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class Server
    {
        Socket soket;
        public static List<NetworkStream> listaTokova = new List<NetworkStream>();

        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);

                ThreadStart ts = osluskuj;
                new Thread(ts).Start();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool zaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        void osluskuj()
        {
            try
            {
                while (true)
                {
                    soket.Listen(8);
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    listaTokova.Add(tok);
                    new ObradaKlijenta(tok);
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
