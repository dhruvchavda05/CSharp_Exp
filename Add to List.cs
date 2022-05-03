using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] male = { };
            string[] female = { };
            List<string> maleList = male.ToList();
            List<string> femaleList = female.ToList();

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Who do you want to add details for?(male/female)");
                string gender = Console.ReadLine();
                if (gender == "male" || gender == "m")
                {
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    maleList.Add(name);
                    male = maleList.ToArray();
                    int index = Array.BinarySearch(male, name);
                    Console.WriteLine($"{name} is at index {index}");
                }
                else if (gender == "female" || gender == "f")
                {
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    femaleList.Add(name);
                    female = maleList.ToArray();
                    int index = Array.BinarySearch(male, name);
                    Console.WriteLine($"{name} is at index {index}");
                }
            }
            for (i = 0; i < male.Length; i++)
            {
                Console.WriteLine($"{male[i]}");
            }
        }
    }
}
