using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaCarFactoryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Car> carList = new List<Car>();
        
            // ▼ Greeting and first answer part ▼
        GreetingAndAnswer:
            Console.WriteLine("Welcome to the Patika Car Factory Sir/Madam! Do you want to produce car? (Y/N)");
            string userProduceAnswer = Console.ReadLine().ToLower();

            if (userProduceAnswer == "n") // -> If answer n exit the program
            {
                Environment.Exit(0);
            }
            else if (userProduceAnswer == "y")
            {
                goto ProducingCar; // -> If answer is yes going to Producing car block
            }
            else
            {
                Console.WriteLine("Please input 'Y' or 'N'... ");
                goto GreetingAndAnswer; // -> Out of scope y or no so going back
            }

        // ▼ Producing car and adding to car list part ▼
        ProducingCar:
            Console.Write("Your car brand:");
            string brandAnswer = Console.ReadLine();
            Console.Write("Your car model:");
            string modelAnswer = Console.ReadLine();
            Console.Write("Your car color:");
            string colorAnswer = Console.ReadLine();
        doorAnswer: // -> Door count format check block
            try
            {
                Console.Write("Your car door count:");
                int doorAnswer = Convert.ToInt32(Console.ReadLine());
                Car userCar = new Car()
                {
                    Brand = brandAnswer,
                    Color = colorAnswer,
                    DoorCount = doorAnswer,
                    Model = modelAnswer
                };
                carList.Add(userCar);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input a door count you want 'as number' ...");
                goto doorAnswer; // -> Wrong format and going back to block
            }
            bool repeatingCheck = false; // -> Repeating key
            while (!repeatingCheck)
            {
                Console.WriteLine("Do you want produce another car?(Y/N) ");
                string repeatingAnswer = Console.ReadLine().ToLower();
                if (repeatingAnswer=="y")
                {
                    goto ProducingCar;  // -> If user wants to produce again going to ProdicingCar block 
                }
                else
                {
                    repeatingCheck = true;
                }
            }

            // ▼ After all printing all car serial number and brand in List<Car> produced by user
            Console.WriteLine("Produced cars:");
            foreach (Car car in carList) {

                Console.WriteLine($"Serial Number:{car.SerialNumber}\nBrand:{car.Brand}\n*****************");
            }
        }

    }
}
