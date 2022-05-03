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
            var data = new List<Data>()
            {
                new Data(){Id = 999}
            };

            int id = 104;

            IDictionary<int, int> distance = new Dictionary<int, int>();
            distance.Add(11, 13568);
            distance.Add(12, 13081);
            distance.Add(21, 7658);
            distance.Add(22, 8141);

            IDictionary<string, string> ports = new Dictionary<string, string>();
            ports.Add("$10", "Port10");
            ports.Add("$20", "Port20");
            ports.Add("$30", "Port30");
            ports.Add("$40", "Port40");

            Dictionary<int, Dictionary<string, int>> info = new Dictionary<int, Dictionary<string, int>>();
            info.Add(101, new Dictionary<string, int> { { "USA => IND", 30000 } });
            info.Add(102, new Dictionary<string, int> { { "UAE => AUS", 40000 } });
            info.Add(103, new Dictionary<string, int> { { "USA => AUS", 25000 } });

            while (true)
            {
                Console.WriteLine($"Your ID => {data[0].Id}");
                Console.WriteLine($"Import | Export | Old Transaction | Change Destination ? (I/E/O/C)");
                Console.WriteLine();
                string ansIEOC = Console.ReadLine();

                Console.Clear();
                if (ansIEOC == "I")
                {
                    Console.WriteLine($"Your ID => {data[0].Id}");
                    Console.WriteLine();
                    Console.WriteLine("What is your location?");
                    Console.WriteLine("Press ==> 1 For USA");
                    Console.WriteLine("Press ==> 2 For UK");
                    int ansI = Convert.ToInt32(Console.ReadLine());
                    switch (ansI)
                    {
                        case 1:
                            data[0].From = "USA";
                            break;
                        case 2:
                            data[0].From = "UAE";
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine($"Your ID => {data[0].Id}");
                    Console.WriteLine();
                    Console.WriteLine("From where you want to import?");
                    Console.WriteLine("Press ==> 1 For IND");
                    Console.WriteLine("Press ==> 2 For AUS");
                    switch (ansI)
                    {
                        case 1:
                            data[0].To = "IND";
                            break;
                        case 2:
                            data[0].To = "AUS";
                            break;
                    }
                    int ansF = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Enter port id: ");
                    string ansP = Console.ReadLine();
                    Console.WriteLine($"You have selected {ports[ansP]} for import.");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to proceed:");
                    Console.ReadLine();
                    Console.Clear();
                    int ansFT = Convert.ToInt32(string.Format("{0}{1}", ansI, ansF));
                    Console.WriteLine($"Your ID => {data[0].Id}");
                    Console.WriteLine();
                    Console.WriteLine($"From: {data[0].From} => To: {data[0].To}");
                    Console.WriteLine($"Selected port: {ports[ansP]}");
                    Console.WriteLine($"Distance is: {distance[ansFT]}");
                    Console.WriteLine($"Fees are: ${distance[ansFT] * 2}");
                    Console.WriteLine();
                    Console.WriteLine("Thank You!");

                    info.Add(id, new Dictionary<string, int> { { $"{ data[0].From } => { data[0].To}", distance[ansFT] } });
                    id++;
                    Console.ReadLine();

                    Console.Clear();
                }
                else if (ansIEOC == "E")
                {
                    Console.WriteLine($"Your ID => {data[0].Id}");
                    Console.WriteLine();
                    Console.WriteLine("What is your location?");
                    Console.WriteLine("Press ==> 1 For USA");
                    Console.WriteLine("Press ==> 2 For UK");
                    int ansE = Convert.ToInt32(Console.ReadLine());
                    switch (ansE)
                    {
                        case 1:
                            data[0].From = "USA";
                            break;
                        case 2:
                            data[0].From = "UAE";
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine($"Your ID => {data[0].Id}");
                    Console.WriteLine();
                    Console.WriteLine("Where do you want to export?");
                    Console.WriteLine("Press ==> 1 IND");
                    Console.WriteLine("Press ==> 2 AUS");
                    int ansT = Convert.ToInt32(Console.ReadLine());
                    switch (ansT)
                    {
                        case 1:
                            data[0].To = "IND";
                            break;
                        case 2:
                            data[0].To = "AUS";
                            break;
                    }

                    Console.Clear();
                    Console.WriteLine("Enter port id: ");
                    string ansP = Console.ReadLine();
                    Console.WriteLine($"You have selected {ports[ansP]} for import.");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to proceed:");
                    Console.ReadLine();

                    Console.Clear();
                    int ansFT = Convert.ToInt32(string.Format("{0}{1}", ansE, ansT));
                    Console.WriteLine($"Your ID => {data[0].Id}");
                    Console.WriteLine();
                    Console.WriteLine($"From: {data[0].From} => To: {data[0].To}");
                    Console.WriteLine($"Selected port: {ports[ansP]}");
                    Console.WriteLine($"Distance is: {distance[ansFT]}");
                    Console.WriteLine($"Fees are: ${distance[ansFT] * 3}");
                    Console.WriteLine();
                    Console.WriteLine("Thank You!");
                    info.Add(id, new Dictionary<string, int> { { $"{ data[0].From } => { data[0].To}", distance[ansFT] } });
                    Console.ReadLine();
                    id++;
                    Console.Clear();
                }
                else if (ansIEOC == "O")
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("SN   |    From-TO   |  Price ");
                    Console.WriteLine("-----------------------------");
                    foreach (KeyValuePair<int, Dictionary<string, int>> ele in info)
                    {
                        foreach (KeyValuePair<string, int> innerDict in ele.Value)
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
                else if (ansIEOC == "C")
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("SN   |    From-TO   |  Price ");
                    Console.WriteLine("-----------------------------");
                    foreach (KeyValuePair<int, Dictionary<string, int>> ele in info)
                    {
                        foreach (KeyValuePair<string, int> innerDict in ele.Value)
                        {

                            Console.WriteLine($"{ele.Key}  |  {innerDict.Key}  |  ${innerDict.Value}");

                        }
                    }
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Enter SN of booking:");
                    int ansC = Convert.ToInt32(Console.ReadLine());
                    if (info.ContainsKey(ansC))
                    {
                        Console.WriteLine("Enter From: (USA, UAE)");
                        string ansCF = Console.ReadLine();
                        Console.WriteLine("Enter To: (IND, AUS)");
                        string ansCT = Console.ReadLine();
                        info.Remove(ansC);
                        info.Add(ansC, new Dictionary<string, int> { { $"{ansCF} => {ansCT}", 30000 } });
                        Console.WriteLine();
                        Console.WriteLine("Updated Successfully.");
                        Console.WriteLine("Press Enter to proceed");
                        Console.ReadLine();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("SN not found!");
                        Console.WriteLine("Press Enter to proceed");
                        Console.ReadLine();
                        Console.Clear();

                    }
                }
            }
        }
    }

    public class Data
    {
        public int Id;
        public string From;
        public string To;
    }


}

