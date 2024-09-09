using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Redovisningsuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true; //Deklarera en bool och tilldena den värdet true för att programmet ska gå att avsluta 

            while (run) // Loopa så länge "run" är true
            {
                Console.WriteLine("Gör ett val i menyn:"); //Skriv ut 
                Console.WriteLine("1. Kontrollera vädret"); 
                Console.WriteLine("2. Vilken är den kallaste staden?"); 
                Console.WriteLine("3. Singla slant"); 
                Console.WriteLine("4. Gissa talet");
                Console.WriteLine("5. Höja talet");
                Console.WriteLine("6. Avsluta");
                Console.Write("Ditt val: ");

                
                int choice = Convert.ToInt32(Console.ReadLine()); // Deklarera en variabel som håller användarens val samt konverterar från string till int

                switch (choice)
                {
                    case (1): // Om använderen väljer val 1 anropa metoden "ControlWeather"
                        MenuChoices.ControlWeather();
                        break;
                    case (2): // Om använderen väljer val 2 anropa metoden "ColdestCity"
                        MenuChoices.ColdestCity();
                        break;
                    case (3): // Om använderen väljer val 3 anropa metoden "FlipCoin"
                        MenuChoices.FlipCoin();
                        break;
                    case (4): // Om använderen väljer val 4 anropa metoden "GuessNumber"
                        MenuChoices.GuessNumber();
                        break;
                    case (5): // Om användaren väljer val 5 anropa metoden "RaiseNumber"
                        MenuChoices.RaiseNumber();
                        break;
                    case (6): //Om användaren väljer val 6 avsluta programmet 
                        run = false;
                        break;
                    default: 
                        Console.WriteLine("Fel inmatning, gör ett val i menyn");
                        break;

                }
               
                Console.ReadKey();
            }
            
    }   }
}

    

