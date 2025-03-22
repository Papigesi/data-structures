using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class District
    {
        public string districtName;
        public int distance;

        public District(string districtName, int distance)
        {
            this.districtName = districtName;
            this.distance = distance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] districtNames = { "Balçova", "Bornova", "Bayraklı", "Buca", "Çiğli", "Gaziemir", "Güzelbahçe", "Karşıyaka", "Konak", "Narlıdere", "Aliağa", "Bayındır", "Bergama", "Beydağ", "Çeşme", "Dikili", "Foça", "Karaburun", "Kemalpaşa", "Kınık", "Kiraz", "Menderes", "Menemen", "Ödemiş", "Seferihisar", "Selçuk", "Karabağlar", "Tire", "Torbalı", "Urla" };
            int[] distances = { 14, 4, 9, 10, 11, 8, 30, 6, 0, 17, 53, 78, 102, 141, 88, 105, 64, 107, 24, 119, 142, 23, 29, 113, 52, 76, 25, 84, 46, 42 };

            ArrayList al = new ArrayList();
            List<District> districts;
            District district;

            int counter = 0;
            int exponent = 0;

            while (counter < districtNames.Length)
            {
                districts = new List<District>();
                int listLength = (int)Math.Pow(2, exponent);

                for (int i = 0; i < listLength && counter < districtNames.Length; i++)
                {
                    if (counter < districtNames.Length)
                    {
                        district = new District(districtNames[counter], distances[counter]);
                        districts.Add(district);
                        counter++;
                    }
                }
                al.Add(districts);
                exponent++;
            }

            foreach (List<District> l in al)
            {
                foreach (District d in l)
                {
                    Console.WriteLine("İlçe adı: {0} --- Merkeze uzaklık: {1}", d.districtName, d.distance);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
