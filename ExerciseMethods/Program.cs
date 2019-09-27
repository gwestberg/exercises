using System;

namespace ExerciseMethods
{
    class Program
    {
 //--------------------------------------------------------------------------------

        /*static void Main(string[] args)
        {
            //---------------------------------------------
            //Exercise 1, input
            //----------------------------------------------
            System.Console.WriteLine("Hello, what is your name?");
            string nameinput = Console.ReadLine();
            Hello(nameinput);
        }
        static void Hello(string name)
        {
            System.Console.WriteLine("Hello {0}, nice to see you!",name);
        }*/

 //-----------------------------------------------------------------------

        /*  static void Main(string[] args)
        {
            //-------------------------------------------------
            // Exercise 2, input and output. 
            //------------------------------------------------------
             System.Console.Write("Hello, what is you name? : "); 
            string nameInput =Console.ReadLine();
            System.Console.Write("How is your mood today? : "); 
            string wellbeingInput = Console.ReadLine();
            HelloHowAreYou(nameInput,wellbeingInput);
            //-------------------------------------------------------
        }
        static void HelloHowAreYou(string name , string wellBeing)
        {
            System.Console.WriteLine("Hello {0}, so you are in a {1} mood today.",name,wellBeing);
        }*/


//-------------------------------------------------------------------------------------------------


       /* static void Main(string[] args)
        {
            //----------------------------------------------------------
            //Exercise 3; Returning the sum of two integers.
            // (It does what it's supposed to do, though there should be a try/catch on each of the convert.int32 places.)
            //--------------------------------------------------------
            
            bool onlyNumbers = false;
            while (onlyNumbers == false)
            {
            try
            {
            System.Console.Write("The first number: "); 
            int inputNrOne = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("The second number: "); 
            int inputNrTwo = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("the sum of {0} and {1} is {2}",inputNrOne , inputNrTwo,Returningsum(inputNrOne,inputNrTwo));
            onlyNumbers = true;
            }
            catch
            {
                System.Console.WriteLine("only integers are allowed");
                onlyNumbers = false;
            }
            }

            //-------------------------------------------------------
        }
        static int Returningsum(int nrOne, int nrTwo)
        {
            int sum = nrOne + nrTwo;
            return sum;
        } *7


//---------------------------------------------------------------------------------------------------

        /*
        static void Main(string[] args)
        {
            //--------------------------------------------
            // exercise 4 , add taxes (25%)
            //--------------------------------------------
            bool convertDouble = false;
            while( convertDouble == false)
            {
            try{
            Console.Write("Enter the price to calculate price incl. taxes: ");
            double taxes= Convert.ToDouble (Console.ReadLine());
            System.Console.WriteLine( "The price, including taxes will be: {0}",ReturnAddedTaxes(taxes));
            convertDouble = true;
            }
            catch
            {
                System.Console.WriteLine("You can onnly use numbers and the comma-sign ( , )");
                convertDouble = false;
            }
            }
        }

        static double ReturnAddedTaxes(double addTaxes)
        {
            double taxesAdded = addTaxes * 1.25;
            taxesAdded = Math.Round(taxesAdded, 2);
            return taxesAdded;
        }
         */

         
//-----------------------------------------------------------------------------------
    
     /*static void Main(string[] args)

    //---------------------------------------------------
    //Exercise 5 - calculate price with custom taxes.
    //---------------------------------------------------

        {
            System.Console.Write("price: ");
            double userPrice = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("taxes: ");
            double userTaxes = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("The price, inluding the taxes is: {0}",addedInputTaxes(userPrice,userTaxes));
        }

    
    static double addedInputTaxes(double inputPrice, double inputTaxes)
    {
        double priceAddedtaxes;
        double inputTaxesPercentage = (inputTaxes * 0.01)+1;
        priceAddedtaxes = inputPrice * inputTaxesPercentage;
        priceAddedtaxes = Math.Round(priceAddedtaxes,2);
        return priceAddedtaxes;
    }*/
        
//------------------------------------------------------------------------------------------------------------

    /*static void Main(string[] args)

    //-----------------------------------------
    // Exercise 6 - convert decimal to integer
    //------------------------------------------

    {
        System.Console.Write("Write a decimal number: ");
        double decimalNr = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine( "The number rounded at the middle will be: {0}" ,returnInt(decimalNr));
    }

    static double returnInt(double decimalNrInt)
    {
        double roundedDouble= Math.Round(decimalNrInt, MidpointRounding.ToEven);
        int convertedInt = Convert.ToInt32(roundedDouble);

        return convertedInt;
    }*/

//---------------------------------------------------------------------------------------------------------------


    /*static void Main(string[] args)
    {
        //--------------------------------------
        //Exercise 7 - Check age if legal or not
        //--------------------------------------
        System.Console.Write("Welcome to your local pub! \nHow old are you? ");
        int LegalorNot = Convert.ToInt32(Console.ReadLine());
        isLegalorNot(LegalorNot);
        
    }
    static int isLegalorNot(int legalint)
    {
            if (legalint >= 18)
            {
                System.Console.WriteLine("You are of drinking age, welcome in!");
            }
            else
            {
                System.Console.WriteLine("You are not old enough to drink at this pub, Welcome back when you turn 18.");
            }
            return legalint;
    }*/
        
    }
}
