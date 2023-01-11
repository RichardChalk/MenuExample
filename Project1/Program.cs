using LibraryServices;
using Project1;

public class Program
{
    
    static void Main()
    {
        // Eftersom vi anropa Project1ShowMenu() från vår klient projekt
        // ... "MenuExample" behöver inte vi dessa rader alls

        // Om man hade Project1 som startup projekt skulle man
        // Behöva skapa detta object och anropa Project1ShowMenu()
        // ... för att komma igång 


        //var calcServices = new CalculatorServices();
        //var start = new Project1App(calcServices);
        //start.Project1ShowMenu();
    }
}
