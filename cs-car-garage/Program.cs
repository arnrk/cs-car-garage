using System;

namespace cs_car_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Car car = new Car();

            Console.WriteLine("Welcome to My Car Garage");
            Console.WriteLine("*******************************");

            bool playGame = true;
            do
            {
                Console.WriteLine();
                string menuSelection = ShowMainMenu();

                switch (menuSelection)
                {
                    case "1":
                        Console.Write("What is the make of your car? ");
                        string carMake = Console.ReadLine();
                        Console.Write("What is the model of your car? ");
                        string carModel = Console.ReadLine();
                        garage.AddCar(carMake, carModel);
                        break;
                    case "2":
                        int carIndex = SelectCarMenu(garage);
                        garage.RemoveCar(carIndex);
                        break;
                    case "3":
                        Console.WriteLine("Not Implemented");
                        break;
                    case "4":
                        Console.WriteLine("Not Implemented");
                        break;
                    case "5":
                        Console.WriteLine("Not Implemented");
                        break;
                    default:
                        playGame = false;
                        Console.WriteLine("Good bye!");
                        break;
                }
            } while (playGame);
        }

        static string ShowMainMenu()
        {
            Console.WriteLine("1. Add a car to the garage");
            Console.WriteLine("2. Remove a car from the garage");
            Console.WriteLine("3. Test drive a car");
            Console.WriteLine("4. Fuel all cars in the garage");
            Console.WriteLine("5. Show stats of all cars in the garage");
            Console.WriteLine("6. Exit game");
            Console.WriteLine();
            Console.Write("Please enter the number of your selection: ");
            return Console.ReadLine();
        }

        static int SelectCarMenu(Garage garage)
        {
            Console.WriteLine("Please select a car:");
            int carNumber = 1;
            foreach (Car car in garage.Cars)
            {
                //Console.WriteLine(car.Make + ", " + car.Model);
                Console.WriteLine($"{carNumber}. {car.Make}, {car.Model}");
                carNumber++;
            }

            int selectedCarNumber = Convert.ToInt32(Console.ReadLine());

            return (selectedCarNumber - 1);
        }
    }
}
