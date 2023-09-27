using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using BusinessLayer;

namespace Client
{
    public static class ClientManager
    {
        static TcpClient client;
        static Socket clientSocket;
        static IPAddress clientIPAddress, serverIPAddress;
        static int clientPort, serverPort;
        static string clientIP, serverIP;
        public static bool CommunicationIsActive = true;

        public static void InitializeClient()
        {
            Console.Write("Enter server IP address to use (or nothing for local IP): ");
            serverIP = Console.ReadLine();
            serverIP = (serverIP != string.Empty) ? serverIP : "127.0.0.1";

            Console.Write("Enter server port to use: ");
            serverPort = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter client IP address to use (or nothing for local IP): ");
            clientIP = Console.ReadLine();
            clientIP = (clientIP != string.Empty) ? clientIP : "127.0.0.1";

            Console.Write("Enter client port to use: ");
            clientPort = Convert.ToInt32(Console.ReadLine());

            serverIPAddress = IPAddress.Parse(serverIP);
            clientIPAddress = IPAddress.Parse(clientIP);

            IPEndPoint endPoint = new IPEndPoint(clientIPAddress, clientPort);
            client = new TcpClient(endPoint);

            clientSocket = client.Client;

            client.Connect(serverIPAddress, serverPort);

            Console.WriteLine("Socket local endpoint: {0}", clientSocket.LocalEndPoint.ToString());
            Console.WriteLine("Socket connected: {0}", clientSocket.Connected);
        }

        public static void SendMessage(BinaryMessage binaryMessage)
        {
            clientSocket.Send(binaryMessage.Data);

            Console.WriteLine("Client sent {0} bytes to the server!", binaryMessage.Data.Length);
        }

        public static BinaryObject WaitForMessage()
        {
            BinaryMessage binaryMessage = new BinaryMessage();

            clientSocket.Receive(binaryMessage.Data);

            return RecieveMessage(binaryMessage);
        }

        private static BinaryObject RecieveMessage(BinaryMessage binaryMessage)
        {
            object obj = TransformDataManager.Deserialize(binaryMessage);

            return obj as BinaryObject;
        }

        public static bool ContinueCommunicating()
        {
            Console.WriteLine("Continue sending data to the server? [y/Y or n/N]");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CloseConnection()
        {
            client.Close();
        }

    }
}
