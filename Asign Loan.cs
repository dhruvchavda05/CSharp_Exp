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
            Customer customer = new Customer(25);
            Console.WriteLine(customer.getData());
            Customer customerOne = new Customer(30);
            Console.WriteLine(customerOne.getData());
            Customer customerTwo = new Customer(55);
            Console.WriteLine(customerTwo.getData());
            Customer customerThree = new Customer(70);
            Console.WriteLine(customerThree.getData());
        }

        struct Customer
        {
            public int hasAmount;
            public float age;
            public float loan;
            public Customer(int age)
            {
                this.age = age;
                this.hasAmount = 50000;

                int caseVal = 0;

                if (age > 0 && age <= 25)
                {
                    caseVal = 1;
                }
                else if (age > 25 && age <= 50)
                {
                    caseVal = 2;
                }
                else
                {
                    caseVal = 3;
                }

                switch (caseVal)
                {
                    case 1:
                        this.loan = 15;
                        break;
                    case 2:
                        this.loan = 30;
                        break;
                    case 3:
                        this.loan = 50;
                        break;
                    default:
                        this.loan = 50;
                        break;
                }
            }
            public string getData()
            {
                return $"You will get {loan}% of amount of your wealth({hasAmount}) which is {(loan / 100) * hasAmount} as your age is {age}";
            }
        }
    }
}
