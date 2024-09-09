using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redovisningsuppgift
{
    internal class MenuChoices
    {
        public static void ControlWeather() // Uppgift 3.4 Kontrollera vädret
        {
            Console.WriteLine("Är det fint väder idag?"); 
            Console.Write("Svara j för ja och n för nej: "); 
            string answer = Console.ReadLine(); // Deklarerar en variabel för att spara användarens input 

            if (answer == "j" || answer == "J") // Om "answer" är samma som j eller J
            {
                Console.WriteLine("Vi går på picknick!"); 
            }
            else if (answer == "n" || answer == "N") // Om "answer" är samma som n eller N
            {
                Console.WriteLine("Vi stannar inne och läser en bok!"); 
            }
            else // Annars 
            {
                Console.WriteLine("Felaktig inmatning, svara j för ja och n för nej"); 
            }
            
            Console.ReadKey();
        }
        
        public static void ColdestCity() //Uppgift 3.7 Var är det kallast? (sparad som 3.6)
        {
            Console.Write("Skriv in temperaturen i Göteborg: "); 
            int gothenburg = int.Parse(Console.ReadLine()); //Deklarerar en variabel och tilldelar den värdet som användaren skriver in 

            Console.Write("Skriv in temperaturen i Stockholm: "); 
            int stockholm = int.Parse(Console.ReadLine()); //Deklarerar en variabel och tilldelar den värdet som användaren skriver in 

            Console.Write("Skriv in temperaturen i Uppsala: "); 
            int uppsala = int.Parse(Console.ReadLine()); //Deklarerar en variabel och tilldelar den värdet som användaren skriver in 


            if (stockholm < gothenburg && stockholm < uppsala) // Om "stockholm" är kallare än "gothenburg" och "uppsala"
            {
                Console.WriteLine("Det är kallast i Stockholm"); 
            }
            else if (gothenburg < stockholm && gothenburg < uppsala)  // Om "gothenburg" är kallare än "stockholm" och "uppsala"
            {
                Console.WriteLine("Det är kallast i Göteborg"); 
            }
            else if (uppsala < gothenburg && uppsala < stockholm) // Om "uppsala" är kallare än "gothenburg" och "stockholm"
            {
                Console.WriteLine("Det är kallast i Uppsala"); 
            }

            Console.ReadKey();
        }

        public static void FlipCoin() //Uppgift 4.3 Krona Klave 
        {
            Console.Write("Hur många gånger vill du singla slant?: "); 
            int times = int.Parse(Console.ReadLine()); // Deklarerar en variabel och tilldelar den värdet som användaren skriver in 

            Random rnd = new Random(); // Skapar ett objekt för att generera slumpmässiga tal 

            for (int i = 0; i < times; i++) // Skapar en for-loop som loopar så länge värdet i är mindre än "times". Efter varje iteration av loopen ökar värdet i med 1
            {
                int flipCoin = rnd.Next(1, 3); // Genererar ett slumpmässigt tal mellan 1-2

                if (flipCoin == 1) // Om "flipCoin" är samma som 1
                {
                    Console.WriteLine("Krona"); 
                }
                else if (flipCoin == 2) // Om "flipCoin" är samma som 2
                {
                    Console.WriteLine("Klave"); 
                }
            }
            
            Console.ReadKey();

        }

        public static void GuessNumber() //Uppgift 2 Gissa talet, komplexa uppgifter
        {
            Random rnd = new Random(); // Skapar ett objekt för att generera slumpmässiga tal 
            int slumpTal = rnd.Next(1, 101); // Genererar ett slumpmässigt tal mellan 1-100 och tilldelar värdet till "slumpTal"
            int nrGuesses = 0; // Deklarerar en variabel för att kunna räkna antalet gissningar 
            int guess; // Deklarerar en variabel som ska hålla användarens gissning 
            
            Console.Write("Gissa på ett tal mellan 1-100: "); 

            do
            {
                guess = int.Parse(Console.ReadLine()); // Tilldelar "guess" användarens input 
                nrGuesses++; // Ökar antalet gissningar med 1

                if (guess == slumpTal) // Om "guess" är samma som "slumptal"
                {
                    Console.WriteLine($"Rätt! Du klarade det på {nrGuesses} försök!"); 
                }
                else if (guess < slumpTal) // Om "guess" är mindre än "slumptal"
                {
                    Console.Write("Fel! Mitt tal är större. Gissa igen: "); 
                }
                else if (guess > slumpTal) // Om "guess" är större än "slumptal"
                {
                    Console.Write("Fel! Mitt tal är mindre. Gissa igen: ");
                }
            
            } while (slumpTal != guess); // Loopar tills användaren gissar rätt 

            Console.ReadKey();

        }

        public static void RaiseNumber() //Uppgift 3 Höja talet, komplexa uppgifter 
        {
            int maxValue = 21; //Deklarerar en variabel och tilldelar den värdet 21
            int increase = 0; //Deklarerar en variabel som hålla input från spelarna 
            string player1 = "Spelare 1"; //Deklarerar en variabel och tilldelar den värdet "Spelare 1"
            string player2 = "Spelare 2"; //Deklarerar en variabel och tilldelar den värdet "Spelare 2"
            bool currentPlayer1 = true;//Deklarerar en bool och tilldelar den värdet true 

            Console.WriteLine("Den som skriver in 21 eller högre förlorar."); 
            Console.WriteLine("Spelare 1 börjar."); 


            do // En loop som körs så länge "increase" är mindre än eller lika med "maxValue" 
            {

                //string currentPlayer = currentPlayer1 ? player1 : player2; //Beroende på värdet av "currentPlayer1" tilldelas antingen "player1" eller "player2" till "currentPlayer"
                string currentPlayer; //testa att ersätta med en if-sats istället 


                if (increase < 20) //Om "increase" är mindre än 20
                {
                    Console.Write($"{currentPlayer}, välj {increase + 1}, {increase + 2} eller {increase + 3}: "); // Skriver ut 
                    increase = int.Parse(Console.ReadLine()); // Läser in ett heltal från användaren och tilldelar det till "increase"

                }
                else if (increase == 20) //Om "increase" är samma som 20
                {
                    Console.Write($"{currentPlayer} välj 21 och förlora sen!!: "); // Skriver ut 
                    increase = int.Parse(Console.ReadLine()); // Läser in ett heltal från användaren och tilldelar det till "increase"}
                }
                else if (increase == maxValue) //Om "increase" är samma som 21
                {
                    Console.WriteLine($"{currentPlayer} vann! Grattis!"); // Skriver ut 
                    break;
                }
                currentPlayer1 = !currentPlayer1; // Växlar spelare genom att ändra värdet på "currentPlayer1"

            } while (increase <= maxValue);

            Console.ReadKey();
        }


           
            
        
}

} 



