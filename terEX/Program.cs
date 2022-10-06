using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terEX
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "corkx";
            int cost = 20;

            string country = (city == "cork" ? "Ireland" : "Unknown" );

            Console.WriteLine(country);

            int price = (cost < 25 ? 20 : 30);
            Console.WriteLine(price);

            Console.ReadLine();

        }
    }
}
