using System;

namespace Arrays
{
    class Program
    {
        // ## Arrays
        // ## OBS! I dessa övningar ska du använda dig av undantagshantering i form av try & catch

         static void Main(string[] args)
        {
            //namearray();
            //numberarray();
            //weatherstation();
        }

            static void numberarray()
            {
            // ## Övning 1

            //  - Skriv ett program som hämtar flera tal från användaren, och som sedan skriver ut talen samt deras sammanlagda summa. 
            // Ni kan välja om ni vill använda hel eller decimaltal men ni måste använda en vektor för att spara undan talen. 
            // Använd for loop!
            int[] numberArray = new int[5];
            
             for(int i = 0; i < numberArray.Length; i++)
            {
                System.Console.Write("Ange ett heltal för plats nummer {0}: ",i+1);
                try
                {
                int number = Convert.ToInt32 (Console.ReadLine());
                numberArray[i] = number;  
                }
                catch
                {
                    System.Console.WriteLine("\nFel inmanting, du kan endast ange heltal, försök igen.");
                    i--;
                }
            }

                System.Console.WriteLine("\n");

            for(int i = 0; i < numberArray.Length; i++)
            {
                System.Console.WriteLine("{0}. {1} \n", i+1, numberArray[i]);  
            }
            }
            static void namearray()
            {
                // ## Övning 2 

                //  - Alla namn (del 1)
                // Skapa en string array med fem element. 
                //Användaren får mata in fem namn via en for-loop. 
                //Programmet skriver sedan ut dessa namn med hjälp av en for-loop. 

                //  - Alla namn (del 2)
                // Efter att alla namn skrivits ut, ska användaren kunna skriva ett index och därefter ett annat namn. 
                //Personen på detta index i arrayen byts då ut och alla namn skrivs ut igen. 
                //Om användaren istället skriver ”q” eller ”Q” så avslutas programmet direkt. 

            
            string[] nameArray = new string[5];
            
             for(int i = 0; i < nameArray.Length; i++)
            {
                System.Console.Write("Ange namn för person nummer {0}: ",i+1);
                 string name = Console.ReadLine();
                nameArray[i] = name;  
            }

            Console.WriteLine("\n");

            for(int i = 0; i < nameArray.Length; i++)
            {
                System.Console.WriteLine("{0}. {1} \n", i+1, nameArray[i]);  
            }


            System.Console.Write("Välj en siffra där du vill byta ut namnet (1-5): ");
            int inputNr = int.Parse (Console.ReadLine());
            System.Console.Write("välj ett nytt namn på {0}: ",nameArray [inputNr-1]);
            string newName = Console.ReadLine();
            nameArray[inputNr-1] = newName;
            System.Console.WriteLine("\n");

            for (int i = 0; i < nameArray.Length; i++)
            {
                System.Console.WriteLine("{0}. {1}", i+1, nameArray[i]);
            }

            
        }
            static void weatherstation()
            {

            // ## Övning 3

            //  - Väderstationen
            // Denna övning påminner om den förra, men man skriver inte i början hur många mätningar som ska göras. 
            // Allt sköts via en meny istället.
            // När man väljer att ta bort en temperaturmätning, så anger man vilken mätning man vill ta bort med hjälp av index. 
            // Bestäm själv om du använder for eller foreach. Motivera gärna ditt val i koden. 
            string[] nameArray = new string[5];
            
            System.Console.WriteLine("Menu:");
            System.Console.WriteLine("[A]dd a temperature.");
            System.Console.WriteLine("[D]elete a temperature.");
            System.Console.WriteLine("[Q]uit");
            string menuOption = Console.ReadLine();



            switch (menuOption)
            {
                case "A":
                {
                    //add temperature and city.
                    for(int i = 0; i < nameArray.Length; i++)
                    {
                    System.Console.Write("Ange namn för person nummer {0}: ",i+1);
                    string name = Console.ReadLine();
                    nameArray[i] = name;  
            }

            Console.WriteLine("\n");

            for(int i = 0; i < nameArray.Length; i++)
            {
                System.Console.WriteLine("{0}. {1} \n", i+1, nameArray[i]);  
            }
                } break;

                case "D":
                {
                    //Delete a temperature.
                    System.Console.Write("Välj en siffra där du vill byta ut namnet (1-5): ");
                    int inputNr = int.Parse (Console.ReadLine());
                    System.Console.Write("välj ett nytt namn på {0}: ",nameArray [inputNr-1]);
                    string newName = Console.ReadLine();
                    nameArray[inputNr-1] = newName;
                    System.Console.WriteLine("\n");

                    for (int i = 0; i < nameArray.Length; i++)
                    {
                    System.Console.WriteLine("{0}. {1}", i+1, nameArray[i]);
                    }
                }break;

                case "Q":
                {
                    //Quit the program.
                    System.Console.WriteLine("");
                    return;
                }break;
            }
            }
       
}
}
