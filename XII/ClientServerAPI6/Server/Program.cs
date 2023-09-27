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
        static List<User> users = new List<User>();
        static List<Message> messages = new List<Message>();

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
                        binaryObject = ServerManager.WaitForMessage(); // Get client operation and data

                        ProcessClientOperation();

                        if (!ServerManager.CommunicationIsActive)
                        {
                            //EndCommunication();
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
            // Create User, Create Message, View Users, View Messages
            // SendMessageToUser, View User (by ID), View Message (by ID), Exit (=8)
            Message message = null;
            User user = null;
            int index;

            int operation = binaryObject.Operation;

            switch (operation)
            {
                case 1: user = binaryObject.Data as User;
                    users.Add(user);
                    Console.WriteLine("User added successfully!");
                    break;

                case 2: message = binaryObject.Data as Message;
                    messages.Add(message);
                    Console.WriteLine("Message added successfully!");
                    break;

                case 3: dataToSend = TransformDataManager.Serialize(new BinaryObject(3, users));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 4: dataToSend = TransformDataManager.Serialize(new BinaryObject(4, messages));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 5: message = binaryObject.Data as Message;
                    Console.WriteLine("Message: #{0} ::: {1}", message.ID, message.Text);
                    Console.WriteLine("Sender: #{0} ::: {1}", message.Sender.ID, message.Sender.Name);
                    Console.WriteLine("Reciever: #{0} ::: {1}", message.Receiver.ID, message.Receiver.Name);
                    break;

                case 6: index = Convert.ToInt32(binaryObject.Data);
                    user = users[index];
                    dataToSend = TransformDataManager.Serialize(new BinaryObject(6, user));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 7: index = Convert.ToInt32(binaryObject.Data);
                    message = messages[index];
                    dataToSend = TransformDataManager.Serialize(new BinaryObject(7, message));
                    ServerManager.SendMessage(dataToSend);
                    break;

                case 8: ServerManager.CommunicationIsActive = false;
                    break;

                default:
                    break;
            }

        }

        public static void EndCommunication()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(6, null));
            ServerManager.SendMessage(dataToSend);
        }

    }
}
