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
            string name, licenseAnswer, confirmAnswer;
            int age, city, totalTime, weeks, days, price;
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

            // chose the city where to pick up the car

            Console.WriteLine("Where would you like to pick up the car?");
            Console.WriteLine("1- Bilbao");
            Console.WriteLine("2- Madrid");
            Console.WriteLine("3- Barcelona");
            Console.WriteLine("4- Santander");

            city = Convert.ToInt32(Console.ReadLine());


            // 
            Console.Write("You will pick up your car in ");
            switch (city)
            {
                case 1:
                    Console.WriteLine("Bilbao");
                    break;
                case 2:
                    Console.WriteLine("Madrid");
                    break;
                case 3:
                    Console.WriteLine("Barcelona");
                    break;
                case 4:
                    Console.WriteLine("Santander");
                    break;
            }

            Console.Write("For how many days would you like to rent it? ");

            totalTime = Convert.ToInt32(Console.ReadLine());

            weeks = totalTime / 7;
            days = totalTime % 7;
            price = totalTime * 10 - 10 * weeks;

            Console.WriteLine("\nClient " + name + " " + age + " years old with driver license. \n");
            Console.WriteLine("You rent the car for " + weeks + " weeks and " + days + " days for " + price + " euros. Pick it up in ");

            switch (city)
            {
                case 1:
                    Console.WriteLine("Bilbao");
                    break;
                case 2:
                    Console.WriteLine("Madrid");
                    break;
                case 3:
                    Console.WriteLine("Barcelona");
                    break;
                case 4:
                    Console.WriteLine("Santander");
                    break;
            }

            Console.WriteLine("\nIs this information correct (Y/N)?");
            confirmAnswer = Console.ReadLine();

            if (confirmAnswer.ToLower() == "y")
               {
                Console.WriteLine("Congratulations! Don´t forget your confirmation ticket.");
               }
            else
                {
                    Console.WriteLine("We are sorry. You have to start again.");
                }


            Console.ReadLine();

        }
    }
}
