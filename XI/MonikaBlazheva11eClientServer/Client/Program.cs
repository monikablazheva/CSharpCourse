using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Client
{
    class Program
    {
        static Dictionary<Type, object> recievedOperation = new Dictionary<Type, object>();
        static Dictionary<Type, object> recievedData = new Dictionary<Type, object>();
        static BinaryMessage operationToSend = new BinaryMessage();
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

                } while (ClientManager.ContinueCommunicating());

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
            Console.WriteLine("1) Create Teacher");
            Console.WriteLine("2) Create Subject");
            Console.WriteLine("3) View Teachers");
            Console.WriteLine("4) View Subjects");
            Console.WriteLine("5) Exit");

            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateTeacher(); break;
                case 2: CreateSubject(); break;
                case 3: ViewTeachers(); break;
                case 4: ViewSubjects(); break;
                case 5: ClientManager.CommunicationIsActive = false; break;
                default: throw new ArgumentException("Invalid option!");
            }
        }

        private static void CreateTeacher()
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Experience: ");
            string experience = Console.ReadLine();

            Teacher teacher = new Teacher(name, age, experience);

            operationToSend = TransformDataManager.Serialize(1);
            dataToSend = TransformDataManager.Serialize(teacher);

            ClientManager.SendMessage(operationToSend);
            ClientManager.SendMessage(dataToSend);
        }

        private static void CreateSubject()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Type: ");
            string type = Console.ReadLine();

            Subject subject = new Subject(title, type);

            operationToSend = TransformDataManager.Serialize(2);
            dataToSend = TransformDataManager.Serialize(subject);

            ClientManager.SendMessage(operationToSend);
            ClientManager.SendMessage(dataToSend);
        }

        private static void ViewTeachers()
        {
            operationToSend = TransformDataManager.Serialize(3);
            dataToSend = TransformDataManager.Serialize(string.Empty);

            ClientManager.SendMessage(operationToSend);
            ClientManager.SendMessage(dataToSend);

            recievedData = ClientManager.WaitForMessage();

            List<Teacher> teachers = recievedData[typeof(List<Teacher>)] as List<Teacher>;

            Console.WriteLine(Environment.NewLine + "Teachers Information:");

            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine("ID: {0}", teacher.ID);
                Console.WriteLine("Age: {0} # Name: {1} # Experience: {2}", teacher.Age, teacher.Name, teacher.Experience);
            }
            Console.WriteLine();
        }

        private static void ViewSubjects()
        {
            operationToSend = TransformDataManager.Serialize(4);
            dataToSend = TransformDataManager.Serialize(string.Empty);

            ClientManager.SendMessage(operationToSend);
            ClientManager.SendMessage(dataToSend);

            recievedData = ClientManager.WaitForMessage();

            List<Subject> subjects = recievedData[typeof(List<Subject>)] as List<Subject>;

            Console.WriteLine(Environment.NewLine + "Subjects Information:");

            foreach (Subject subject in subjects)
            {
                Console.WriteLine("ID: {0}", subject.ID);
                Console.WriteLine("Title: {0} # Type: {1}", subject.Title, subject.Type);
            }
            Console.WriteLine();
        }

        public static void EndCommunication()
        {
            operationToSend = TransformDataManager.Serialize(5);
            dataToSend = TransformDataManager.Serialize(string.Empty);

            ClientManager.SendMessage(operationToSend);
            ClientManager.SendMessage(dataToSend);
        }

    }
}
