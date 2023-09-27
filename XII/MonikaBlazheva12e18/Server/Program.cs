using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace Server
{
    class Program
    {
        static BinaryObject binaryObject;
        static BinaryMessage dataToSend = new BinaryMessage();
        static List<Car> cars = new List<Car>();
        static List<Order> orders = new List<Order>();

        static void Main(string[] args)
        {
            try
            {
                ServerManager.InitializeServer();

                while (true)
                {
                    ServerManager.ListenForNewConnections();

                    do
                    {
                        binaryObject = ServerManager.WaitForMessage();

                        ProcessClientOperation();

                        if (!ServerManager.CommunicationIsActive)
                        {
                            break;
                        }
                    } while (true);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to close the program");
                Console.ReadKey();
            }
            finally
            {
                ServerManager.CloseConnection();
            }
        }

        private static void ProcessClientOperation()
        {
            // Add Car, Add Order, View Cars, View Orders
            // SendMessageToUser, View User (by ID), View Message (by ID), Exit (=8)
            Order order = null;
            Car car = null;
            int index;

            int operation = binaryObject.Operation;

            switch (operation)
            {
                case 1:
                    car = binaryObject.Data as Car;
                    cars.Add(car);
                    Console.WriteLine("Car was added successfully!");
                    break;

                case 2:
                    order = binaryObject.Data as Order;
                    orders.Add(order);
                    Console.WriteLine("Order was added successfully!");
                    break;

                case 3:
                    dataToSend = TransformDataManager.Serialize(new BinaryObject(3, cars));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 4:
                    dataToSend = TransformDataManager.Serialize(new BinaryObject(4, orders));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 5:
                    index = Convert.ToInt32(binaryObject.Data);
                    car = cars[index];
                    dataToSend = TransformDataManager.Serialize(new BinaryObject(5, car));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 6:
                    ServerManager.CommunicationIsActive = false;
                    break;

                default:
                    break;
            }

        }

        public static void EndCommunication()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(5, null));
            ServerManager.SendMessage(dataToSend);
        }

    }
}
