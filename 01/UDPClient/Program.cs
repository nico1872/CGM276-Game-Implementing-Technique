using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            String server = "10.1.116.239";

            int servPort=5000;
            String message="Nicolas 5902828";
            byte[] sendPacket= Encoding.ASCII.GetBytes(message);
            UdpClient client = new UdpClient();
            
            try{
                    client.Send(sendPacket,sendPacket.Length,server,servPort);

                   
                }catch(SocketException e){
                        Console.WriteLine(e.ErrorCode+" "+e.Message);
                }
        }
    }
}
