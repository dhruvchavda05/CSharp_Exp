using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_app
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int SN = 101;
            int ID = 11;
            string userId = "admin";
            string userPass = "admin";

            IDictionary<string, string> container = new Dictionary<string, string>();
            container.Add("10", "Container10");
            container.Add("20", "Container20");
            container.Add("30", "Container30");
            container.Add("40", "Container40");
            container.Add("50", "Container40");

            Dictionary<int, Dictionary<string, string>> cart = new Dictionary<int, Dictionary<string, string>>();
            cart.Add(901, new Dictionary<string, string> { { "10", "Container10" } });
            cart.Add(902, new Dictionary<string, string> { { "20", "Container20" } });


            while (true)
            {
                Console.Write("Enter UserId: ");
                string id = Console.ReadLine();
                Console.Write("Enter Password: ");
                string pass = Console.ReadLine();

                if (id == userId && pass == userPass)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("Book Containers | Old Transaction | Logout (B/O/L)");
                        string ansBOL = Console.ReadLine();
                        if (ansBOL == "B")
                        {
                            Console.Clear();
                            Console.WriteLine("-----------");
                            Console.WriteLine("id - Name  ");
                            Console.WriteLine("-----------");
                            foreach (KeyValuePair<string, string> kvp in container)
                            {
                                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                            }
                            Console.WriteLine("-----------");
                            Console.WriteLine("Enter id of container you want to book: ");
                            string ansB = Console.ReadLine();
                            cart.Add(SN, new Dictionary<string, string> { { ansB, container[ansB] } });
                            Console.WriteLine($"You have successfully booked the {container[ansB]}");
                            SN++;
                            ID++;
                            Console.WriteLine();
                            Console.WriteLine("Press enter to proceed");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (ansBOL == "O")
                        {
                            Console.Clear();
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("SN   |  id  |  Name       ");
                            Console.WriteLine("--------------------------");
                            foreach (KeyValuePair<int, Dictionary<string, string>> ele in cart)
                            {
                                foreach (KeyValuePair<string, string> innerDict in ele.Value)
                                {
                                    Console.WriteLine($"{ele.Key}  |  {innerDict.Key}  |  ${innerDict.Value}");
                                }
                            }
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to proceed");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (ansBOL == "L")
                        {
                            Console.Clear();
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong id or password!");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to proceed");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}

