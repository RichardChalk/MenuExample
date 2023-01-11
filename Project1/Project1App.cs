using LibraryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Project1App
    {
        private readonly ICalculatorServices _calcServices;

        public Project1App(ICalculatorServices calcServices)
        {
            _calcServices = calcServices;
        }
        public void Project1ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("==============================");
            Console.WriteLine("1: Addition");
            Console.WriteLine("0: Exit");

            if (Console.ReadLine() == "1")
            {
                // Jag lägger in alla values per automatik för att spara tid
                // Egentligen ska man fråga användaren så klart :)
                var response = _calcServices.Addition(3,5);

                Console.WriteLine($"Resultat Addition: 3 + 5 = {response}");
                Console.ReadLine();
            }
        }
    }
}
