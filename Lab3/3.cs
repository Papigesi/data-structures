using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    class CityPair
    {
        public string[] cityNames;
        public int point;

        public CityPair()
        {
            cityNames = new string[2];
            point = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Istanbul", "Roma", "Paris", "Madrid", "New York", "Moskova", "Londra", "Pekin" };

            string[] trip = tripPlan(cities, r);
            CityPair[] combinationCities = combination(trip, r);

            listCities(combinationCities);
            Console.WriteLine();
            listIstanbul(combinationCities, "Istanbul");

            Console.ReadKey();
        }

        static Random r = new Random();
        static string[] tripPlan(string[] cities, Random r)
        {
            string[] citiesCopy = new string[cities.Length];
            Array.Copy(cities, citiesCopy, cities.Length);

            string[] tripPlan = new string[4];
            int maxValue = cities.Length;

            for (int i = 0; i < 4; i++)
            {
                int randomNumber = r.Next(0, maxValue);
                tripPlan[i] = citiesCopy[randomNumber];

                for (int j = randomNumber; j < citiesCopy.Length - 1; j++)
                {
                    citiesCopy[j] = citiesCopy[j + 1];
                }

                maxValue--;
            }

            return tripPlan;
        }

        static CityPair[] combination(string[] tripPlan, Random r)
        {
            CityPair[] cityCombinations = new CityPair[6];
            int count = 0;

            for (int i = 0; i < tripPlan.Length - 1; i++)
            {
                for (int j = i + 1; j < tripPlan.Length; ++j)
                {
                    CityPair cityPair = new CityPair();
                    cityPair.cityNames[0] = tripPlan[i];
                    cityPair.cityNames[1] = tripPlan[j];
                    cityPair.point = r.Next(0, 101);
                    cityCombinations[count] = cityPair;
                    count++;
                }
            }

            return cityCombinations;
        }

        static void listCities(CityPair[] cityCombinations)
        {
            Console.WriteLine("Tüm şehir çiftleri:");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < cityCombinations.Length; i++)
            {
                Console.WriteLine("Şehir çifti {0} - {1}  Puan: {2}", cityCombinations[i].cityNames[0], cityCombinations[i].cityNames[1], cityCombinations[i].point);
            }
        }

        static void listIstanbul(CityPair[] cityCombinations, string city)
        {
            Console.WriteLine("İçinde {0} şehrini barındıran şehir çiftleri:", city);
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < cityCombinations.Length; i++)
            {
                if (cityCombinations[i].cityNames[0].Equals(city) || cityCombinations[i].cityNames[1].Equals(city))
                {
                    Console.WriteLine("Şehir çifti {0} - {1}  Puan: {2}", cityCombinations[i].cityNames[0], cityCombinations[i].cityNames[1], cityCombinations[i].point);
                }
            }
        }
    }
}
