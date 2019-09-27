using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
			//exercise();
            //exercise2();
            //exercise3();
            //exercise4();
            //exercise5();
            //exercise6();
            //exercise7();
            //exercise8();
            //exercise9();
            //exercise10();
            //exercise11();

            
        }

        static void exercise()
        {
            // Din egen lösning på övning 1
            Console.Write("Tal 1: ");
			string inputOne = Console.ReadLine();
			Console.Write("Tal 2: ");
			string inputTwo = Console.ReadLine();

			int numberOne = Convert.ToInt32(inputOne);
			int numberTwo = Convert.ToInt32(inputTwo);
			int sum = numberOne + numberTwo;

            Console.WriteLine("Summan är: " + sum);
        }

        static void exercise2()
        {
            //konvertera decimaltal till heltal
            System.Console.Write("Please enter a decimal number: ");
            double deci= Convert.ToDouble(Console.ReadLine());
            double convertedDeci= Math.Round(deci);
            System.Console.WriteLine("{0} = {1}", deci,convertedDeci);
            Console.ReadLine();
        }

        static void exercise3()
        {
            // tar in två textsträngar och skriver ut dessa i en mening.
            System.Console.WriteLine("Welcome, to the interactive story\n");
            System.Console.Write("Please tell us the name of your main character: ");
            string name1= Console.ReadLine();

            System.Console.Write("So this is a atory about {0}, what is the name of {0}'s best friend? : \n",name1);
            string name2=Console.ReadLine();

            System.Console.WriteLine("So this is the story about when {0} and {1} got into alot of trouble...",name1,name2);
            Console.ReadLine();
        }

        static void exercise4()
        {
            //Chars

        }

        static void exercise5()
        {
            //Inmatning - utmatning, 
            System.Console.Write("Hello!\nWhat is your name?:");
            string name1=Console.ReadLine();

            System.Console.Write("Welcome {0}! How old might you be? (answer in years): ",name1);
            int age= Convert.ToInt32(Console.ReadLine());

            //halvhyfsad uträkning för att räkna ut dagar inklusive skottår.
            int dayslived= age*365+(age/4);
            System.Console.WriteLine("{0}, you have been alive for {1} days",name1,dayslived); 
        }

        static void exercise6()
        {
            // del 1, ställ frågan om vädret.
            //del 2 skapa alternativ för dåligt väder samt hantera stor/liten bokstav.
            //del 3, hantera felaktig inmatning(ingen loop)
            System.Console.Write("Is the weather nice today? Y/N answer: ");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();

            if(answer == "Y")
            {
                System.Console.WriteLine("\nLet's go for a picnic!");
            }
            else if(answer =="N")
            {
                System.Console.WriteLine("Let's stay inside and read a book instead.");
            }
            else
            {
                System.Console.WriteLine("Wrong input");
            }
        }

        static void exercise7()
        {
            // Ingen if-sats bifogad. ;)
        }

        static void exercise8()
        {
            //Banksimulatorn
        }

        static void exercise9()
        {
            int i =0;
            for (i = 0; i < 11; i++)
            System.Console.WriteLine(i);
        }
        static void exercise10()
        {
            int i =0;
            for (i = 40; i > 29; i--)
            System.Console.WriteLine(i);
        }
        static void exercise11()
        {
            int sum=0;
            int i=0;
            int x = 0;
            int y = 0;
            System.Console.Write("skriv in tal 1:");
            x = int.Parse(Console.ReadLine());
            System.Console.Write("skriv in tal 2:");
            y = int.Parse(Console.ReadLine());

            for(i =x; i <= y ;i++)
            {
                System.Console.WriteLine("{0}\n",i);
                sum+=i;
            }
            System.Console.WriteLine("{0}",sum);

        }

    }  
}
