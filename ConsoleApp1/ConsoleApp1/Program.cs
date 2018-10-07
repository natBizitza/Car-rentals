using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, licenseAnswer;
            int age;
            bool drivLicense = false;

            //name of the client
            Console.WriteLine("Please, introduce your name");
            name = Console.ReadLine();

            //client´s age
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Client " + name + " " + age + " years old.");

            //Driver License

            Console.WriteLine("Do you own a driver license (Y/N)?");
            licenseAnswer = Console.ReadLine();

            if(licenseAnswer.ToLower() == "y")
            {
                drivLicense = true;
                Console.WriteLine("Client " + name + " " + age + " years old with driver license.");
            }
            else if (licenseAnswer.ToLower() == "n")
            {
                drivLicense = false;
                Console.WriteLine("Client " + name + " " + age + " years old without driver license.");
            }

            if(!drivLicense|| age < 18)
            {
                Console.WriteLine("You can´t rent a car. Sorry.");
            } else
            {
                Console.WriteLine("Where do you want to pick up a car?");
            }



            Console.ReadLine();

        }
    }
}
