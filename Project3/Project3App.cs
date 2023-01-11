using LibraryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Project3App
    {
        private readonly IRPSServices _rpsServices;

        public Project3App(IRPSServices rpsServices)
        {
            _rpsServices = rpsServices;
        }
        public void Project3ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("==============================");
            Console.WriteLine("1: Play");
            Console.WriteLine("0: Exit");

            if (Console.ReadLine() == "1")
            {
                // Logik här som ta emot player och computer val
                
                // Sedan kan vi anropa services för att kontrollera vem som har vunnit
                var response = _rpsServices.DidIWin("rock", "paper");

                Console.WriteLine($"Did I win? {response}");
                Console.ReadLine();
            }
        }
    }
}
