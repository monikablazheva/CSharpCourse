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
            Console.WriteLine("1) Add Car");
            Console.WriteLine("2) Add Order");
            Console.WriteLine("3) View Cars");
            Console.WriteLine("4) View Orders");
            Console.WriteLine("5) Exit");

            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddCar(); break;
                case 2: AddOrder(); break;
                case 3: ViewCars(); break;
                case 4: ViewOrders(); break;
                case 5: ClientManager.CommunicationIsActive = false; break;
                default: throw new ArgumentException("Invalid option!");
            }
        }

        private static void AddCar()
        {
            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = Convert.ToInt32(Console.ReadLine());
            price = Math.Round(price, 2);

            Console.Write("Color: ");
            string color = Console.ReadLine();

            Car car = new Car(brand, price, color);

            dataToSend = TransformDataManager.Serialize(new BinaryObject(1, car));

            ClientManager.SendMessage(dataToSend);
        }

        private static void AddOrder()
        {
            Console.Write("Customer's name: ");
            string customerName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = Convert.ToInt32(Console.ReadLine());
            price = Math.Round(price, 2);

            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Car [enter the index of the Cars array, starting from 0]: ");
            int index = Convert.ToInt32(Console.ReadLine());

            dataToSend = TransformDataManager.Serialize(new BinaryObject(5, index));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();

            Car car = binaryObject.Data as Car;

            Order order = new Order(customerName, address, price, quantity, car);

            dataToSend = TransformDataManager.Serialize(new BinaryObject(2, order));

            ClientManager.SendMessage(dataToSend);
        }

        private static void ViewCars()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(3, null));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();

            List<Car> cars = binaryObject.Data as List<Car>;

            Console.WriteLine(Environment.NewLine + "Cars Information:");

            foreach (Car car in cars)
            {
                Console.WriteLine("ID: {0}", car.ID);
                Console.WriteLine("| Brand: {0} | Price: {1} | Color: {2} |", car.Brand, car.Price, car.Color);
            }
            Console.WriteLine();
        }

        private static void ViewOrders()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(4, null));

            ClientManager.SendMessage(dataToSend);

            binaryObject = ClientManager.WaitForMessage();

            List<Order> orders = binaryObject.Data as List<Order>;

            Console.WriteLine(Environment.NewLine + "Orders Information:");

            foreach (Order order in orders)
            {
                Console.WriteLine("ID: {0}", order.ID);
                Console.WriteLine("| Customer's name: {0} | Address: {1} | Price: {2} | Quantity: {3} | Car: {4} |", order.CustomerName, order.Address, order.Price, order.Quantity, order.Car.Brand.ToString());
            }
            Console.WriteLine();
        }

        public static void EndCommunication()
        {
            dataToSend = TransformDataManager.Serialize(new BinaryObject(6, null));
            ClientManager.SendMessage(dataToSend);
        }

    }
}
