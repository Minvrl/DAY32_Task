using DAY19.Task;
using System;

namespace DAY32.Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            City city = new City();


            ChinaCity[] chinaCities = new ChinaCity[0];

            int sum = 0;
            Console.WriteLine("How many cities will be added ? ");
            byte count = byte.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string name;
                do
                {
                    Console.Write("Enter city name - ");
                    name = Console.ReadLine();

                } while (string.IsNullOrEmpty(name));

                string populationStr;
                int population;
                do
                {
                    Console.Write("  Enter population - ");
                    populationStr = Console.ReadLine();

                } while (!int.TryParse(populationStr, out population));

                sum += population;


                ChinaCity chinaCity = new ChinaCity { Name = name, Population = population };

                Array.Resize(ref chinaCities, chinaCities.Length + 1);
                chinaCities[chinaCities.Length - 1] = chinaCity;

            }

            Console.WriteLine($"\nPopulation Average : {sum / count}");


            Console.WriteLine("\n>>>Cities you added :");
            for (int i = 0; i < chinaCities.Length; i++)
            {
                Console.WriteLine($"Name - {chinaCities[i].Name}, Population - {chinaCities[i].Population}");
            }


        }
    }
}
