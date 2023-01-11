using LibraryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Project2App
    {
        private readonly IFormsServices _formsServices;

        public Project2App(IFormsServices formsServices)
        {
            _formsServices = formsServices;
        }

        public void Project2ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Shapes app!");
            Console.WriteLine("==============================");
            Console.WriteLine("1: Square");
            Console.WriteLine("0: Exit");

            if (Console.ReadLine() == "1")
            {
                // Jag lägger in alla values per automatik för att spara tid
                // Egentligen ska man fråga användaren så klart :)
                var response = _formsServices.SquareArea(4, 8);

                Console.WriteLine($"Resultat Square area: 4(h) * 8(w) = {response}");
                Console.ReadLine();
            }
        }
    }
}
