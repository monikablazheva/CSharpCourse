using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using BusinessLayer;

namespace Server
{
    public static class ServerManager
    {
        static TcpListener server;
        static Socket serverSocket, clientSocket;
        static IPAddress serverIPAddress;
        static int maxConnections, serverPort;
        static string serverIP;
        public static bool CommunicationIsActive = true;

        public static void InitializeServer()
        {
            Console.Write("Enter server IP address to use (or nothing for local IP): ");
            serverIP = Console.ReadLine();
            serverIP = (serverIP != string.Empty) ? serverIP : "127.0.0.1";

            Console.Write("Enter server port to use: ");
            serverPort = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter maximum clients: ");
            maxConnections = Convert.ToInt32(Console.ReadLine());

            serverIPAddress = IPAddress.Parse(serverIP);
            server = new TcpListener(serverIPAddress, serverPort);

            serverSocket = server.Server;

            server.Start(maxConnections);

            Console.WriteLine("Socket local endpoint: {0}", serverSocket.LocalEndPoint.ToString());
        }

        public static void ListenForNewConnections()
        {
            clientSocket = server.AcceptSocket();

            Console.WriteLine("Socket connected: {0}", clientSocket.Connected);
            Console.WriteLine("Socket remote endpoint: {0}", clientSocket.RemoteEndPoint.ToString());
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

        public static void SendMessage(BinaryMessage binaryMessage)
        {
            clientSocket.Send(binaryMessage.Data);

            Console.WriteLine("Server sent {0} bytes to the client!", binaryMessage.Data.Length);
        }

        public static void CloseConnection()
        {
            server.Stop();
        }

    }
}