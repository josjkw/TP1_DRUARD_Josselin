
using System;
using MULT_TABLES;

namespace MORE_MATH
{
    public class Quick_Math
    {
        public static void Prime()
        {
            //naive algorithm to get prime number. It checks whether or not
            // x have any divider (using the %) between 1 and sqrt(x)
            for (int i = 1; i <= 1000; i++)
            {
                bool is_prime = true;

                for (int j = 2; j <= System.Math.Sqrt(i) + 1; j++)
                {
                    if (i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }
                if (is_prime)
                {
                    Console.WriteLine(i + " is prime");
                }
            }
        }
        public static void F(int f_step)
        {
            while(f_step <2){
                f_step = Tables.AskUserForParameter("Fibbonacci, please enter a number >= 2 : ");
            }

            int n_1 = 1;
            int n_2 = 1;
            int n = 0;

            if (f_step >= 2)
            {
                for (int i = 2; i <= f_step; i++)
                {
                    //next n is computed
                    //new n-2 is current n-1
                    //new n-1 is current n
                    n = n_1 + n_2;
                    n_2 = n_1;
                    n_1 = n;
                }
                Console.WriteLine("F(" + f_step + ") = " + n);
            }
            else
            {
                Console.WriteLine("Please enter a number >=2");
            }
        }

        public static int factorial(int facto_number)
        {
            if (facto_number <= 1)
            {
                return 1;
            }
            else
            {
                return facto_number * factorial(facto_number - 1);
            }
        }

        public static void run_EXO_2(){
            Console.WriteLine("\nEXO 2.1\n");
            Quick_Math.Prime();
            Console.WriteLine("\nEXO 2.2\n");
            Quick_Math.F(Tables.AskUserForParameter(display_text:"Fibbonacci, please enter a number >= 2 : "));
            Console.WriteLine("\nEXO 2.3\n");
            Console.WriteLine(Quick_Math.factorial(Tables.AskUserForParameter("Enter the number you want the factorial of :")));
        }
    }
}