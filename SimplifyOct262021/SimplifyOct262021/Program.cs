using System;

namespace SimplifyOct262021
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string input = " ";

            while (input != "x")
            {



                Console.WriteLine("\n\n---------------------- \n To Exit -----> 'x'\n\n\n\n Please Enter your numbers in the format num1 / num2 \n\n---------------------------------------------- ");
                input = (Console.ReadLine());



                if (input == "x")
                {
                    Environment.Exit(0);
                }

                try
                {
                   //calling the fraction method to calculate the values inputted by the user
                    Fraction(input);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n\n Error: { e.Message}");
                }

            }//EOM















             static void  Fraction(string input)

              {

                //variable deckaration
                int numerator = 0, denominator = 0, results;

                //denoting the input format 
                string[] sub = input.Split('/');

                numerator = Int32.Parse(sub[0]);
                denominator = Int32.Parse(sub[1]);



                //testing input conditions 
                if (numerator % denominator == 0)
                    {

                        results = numerator / denominator;


                        Console.WriteLine($"\n\nYour Results: {results}");
                    }

                    else if (denominator % numerator == 0)
                    {

                        results = denominator / numerator;


                        Console.WriteLine($"\n\nYour Results: 1/{results}");
                    }

                    else if (numerator % 2 == 0 && denominator % 2 == 0)
                    {
                        numerator  /= 2;
                        denominator /= 2;

                        Console.WriteLine($"\n\nYour Results: {numerator}/{denominator}");
                    }

                    else if (numerator / denominator != 0)
                    {


                        Console.WriteLine($"\n\nYour Results: {numerator}/{denominator}");
                    }

                    else if (denominator / numerator != 0)
                    {

                        Console.WriteLine($"\n\nYour Results: {numerator}/{denominator}");
                    }



                }
                


            }
        









    }//EOC
}//EON
