using BusinessLayer;
using System;

namespace PresentationLayerV4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerView cv = new CustomerView();
            //ProductView pv = new ProductView();
            //OrderView ov = new OrderView();

            int choice, crudChoice;
            bool crudFlagChoice;

            do
            {
                try
                {
                    Console.WriteLine("1) Customer Menu");
                    Console.WriteLine("2) Product Menu");
                    Console.WriteLine("3) Order Menu");
                    Console.WriteLine("4) Exit");

                    choice = EnterChoice();

                    if (choice == 4)
                    {
                        break;
                    }

                    crudFlagChoice = true;

                    do
                    {
                        switch (choice)
                        {
                            case 1:
                                PrintSubMenu("Customer");

                                crudChoice = EnterChoice();

                                switch (crudChoice)
                                {
                                    case 1: cv.Create(); break;
                                    case 2: cv.Read(); break;
                                    case 3: cv.ReadAll(); break;
                                    case 4: cv.Update(); break;
                                    case 5: cv.Delete(); break;
                                    case 6: crudFlagChoice = false; break;
                                    default:
                                        Console.WriteLine("Enter number from [1;6]!");
                                        continue;
                                }

                                break;

                            case 2:
                                PrintSubMenu("Product");

                                crudChoice = EnterChoice();

                                /*
                                switch (crudChoice)
                                {
                                    case 1: pv.Create(); break;
                                    case 2: pv.Read(); break;
                                    case 3: pv.ReadAll(); break;
                                    case 4: pv.Update(); break;
                                    case 5: pv.Delete(); break;
                                    case 6: crudFlagChoice = false; break;
                                    default:
                                        Console.WriteLine("Enter number from [1;6]!");
                                        continue;
                                }
                                */
                                break;

                            case 3:
                                PrintSubMenu("Order");

                                crudChoice = EnterChoice();
                                /*
                                switch (crudChoice)
                                {
                                    case 1: ov.Create(); break;
                                    case 2: ov.Read(); break;
                                    case 3: ov.ReadAll(); break;
                                    case 4: ov.Update(); break;
                                    case 5: ov.Delete(); break;
                                    case 6: crudFlagChoice = false; break;
                                    default:
                                        Console.WriteLine("Enter number from [1;6]!");
                                        continue;
                                }
                                */
                                break;

                            default:
                                Console.WriteLine("Enter number from [1;4]!");
                                crudFlagChoice = false;
                                break;
                        }

                        if (!crudFlagChoice)
                        {
                            break;
                        }

                        ClearMenu();

                    } while (true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                ClearMenu();

            } while (true);
            
        }

        private static void PrintSubMenu(string type)
        {
            Console.WriteLine("1) Create {0}", type);
            Console.WriteLine("2) Read {0}", type);
            Console.WriteLine("3) Read All {0}", type);
            Console.WriteLine("4) Update {0}", type);
            Console.WriteLine("5) Delete {0}", type);
            Console.WriteLine("6) Exit");
        }

        private static int EnterChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return choice;
        }

        private static void ClearMenu()
        {
            Console.WriteLine("Press any key to clear the console and continue working!");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
