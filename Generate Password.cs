using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace my_first_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number: ");
            int phone = Convert.ToInt32(Console.ReadLine());
            string pass = GeneratePassword(10);
            Console.WriteLine();
            Console.WriteLine("Press enter to proced");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Name: {fName} {lName}");
            Console.WriteLine($"Mobile: {phone}");
            Console.WriteLine($"System Generated Password: {pass}");
            Console.WriteLine();
            Console.WriteLine("Press enter to proced");
            Console.ReadLine();

            Console.Clear();
            Console.Write("Enter New password:");
            string newPass = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to proced");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Name: {fName} {lName}");
            Console.WriteLine($"Mobile: {phone}");
            Console.WriteLine($"Password: {newPass}");
        }
        private static string GeneratePassword(int length)
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer).Remove(length);
            }
        }
    }
}

