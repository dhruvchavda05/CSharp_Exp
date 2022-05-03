using System;
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
            Console.Write("Enter birthdate in DD/MM/YYYY format: ");
            DateTime input = DateTime.Parse(Console.ReadLine());
            float age = DateTime.Now.Subtract(input).Days;
            Console.WriteLine($"{age/365} Years old.");
        }
    }
}