using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace Client
{
    class Program
    {
        static BinaryObject binaryObject;
        static BinaryMessage dataToSend = new BinaryMessage();

        static void Main(string[] args)
        {
            try
            {
                ClientManager.InitializeClient();

                do
                {
                    ShowMenu();

                    if (!ClientManager.CommunicationIsActive)
                    {
                        break;
                    }

                } while (true);

                EndCommunication();

                Console.WriteLine("Press any key to close the client API!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to close the program");
                Console.ReadKey();
            }
            finally
            {
                ClientManager.CloseConnection();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Select option:");
            Console.WriteLine("1) Create User");
            Console.WriteLine("2) Create Message");
            Console.WriteLine("3) View Users");
            Console.WriteLine("4) View Messages");
            Console.WriteLine("5) Send Message to User via Server");
            Console.WriteLine("6) Exit");

            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateUser(); break;
                case 2: CreateMessage(); break;
                case 3: ViewUsers(); break;
                case 4: ViewMessages(); break;
                case 5: SendMessageToUser(); break;
                case 6: ClientManager.CommunicationIsActive = false; break;
                default: throw new ArgumentException("Invalid option!");
            }
        }

        private static void CreateUser()
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            User user = new User(age, name);

            dataToSend = TransformDataManager.Serialize(new BinaryObject(1, user));

            ClientManager.SendMessage(dataToSend);
        }

        private static void CreateMessage()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Text: ");
            string text = Console.ReadLine();

            Console.Write("Sender [enter the index of the Users array]: ");
            int index = Convert.ToInt32(Console.ReadLine());

            dataToSend = TransformDataManager.Serialize(new BinaryObject(6, index));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();

            User sender = binaryObject.Data as User;

            Message message = new Message(title, text, sender);

            dataToSend = TransformDataManager.Serialize(new BinaryObject(2, message));

            ClientManager.SendMessage(dataToSend);
        }

        private static void ViewUsers()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(3, null));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();

            List<User> users = binaryObject.Data as List<User>;

            Console.WriteLine(Environment.NewLine + "Users Information:");

            foreach (User user in users)
            {
                Console.WriteLine("ID: {0}", user.ID);
                Console.WriteLine("Age: {0} # Name: {1}", user.Age, user.Name);
            }
            Console.WriteLine();
        }

        private static void ViewMessages()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(4, null));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();

            List<Message> messages = binaryObject.Data as List<Message>;

            Console.WriteLine(Environment.NewLine + "Messages Information:");

            foreach (Message message in messages)
            {
                Console.WriteLine("ID: {0}", message.ID);
                Console.WriteLine("Title: {0} # Text: {1}", message.Title, message.Text);
            }
            Console.WriteLine();
        }

        private static void SendMessageToUser()
        {
            Console.Write("Message [enter the index of the Messages array]: ");
            int messageIndex = Convert.ToInt32(Console.ReadLine());

            dataToSend = TransformDataManager.Serialize(new BinaryObject(7, messageIndex));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();
            Message message = binaryObject.Data as Message;

            Console.Write("Sender [enter the index of the Users array]: ");
            int senderIndex = Convert.ToInt32(Console.ReadLine());

            dataToSend = TransformDataManager.Serialize(new BinaryObject(6, senderIndex));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();
            User sender = binaryObject.Data as User;

            Console.Write("Receiver [enter the index of the Users array]: ");
            int receiverIndex = Convert.ToInt32(Console.ReadLine());

            dataToSend = TransformDataManager.Serialize(new BinaryObject(6, receiverIndex));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();
            User receiver = binaryObject.Data as User;

            Message messageToSend = new Message(message.Title, message.Text,
                sender, receiver);

            dataToSend = TransformDataManager.Serialize(new BinaryObject(5, messageToSend));

            ClientManager.SendMessage(dataToSend);
        }

        public static void EndCommunication()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(8, null));
            ClientManager.SendMessage(dataToSend);
        }

    }
}
