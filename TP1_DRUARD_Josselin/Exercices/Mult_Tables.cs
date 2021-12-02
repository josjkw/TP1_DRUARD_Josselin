
using System;

namespace MULT_TABLES
{
    public class Tables
    {
        public static void print_tables(bool only_odd = false, int? given_number = null)
        {
            Console.WriteLine("\nEXO 1\n");
            
            for (int i = 1; i <= 10; i++)
            {
                //case where the user don't provide an input
                if (given_number == null)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        //If you only need to print odd numbers
                        if (only_odd == true)
                        {
                            if ((j * i) % 2 == 1)
                            {
                                Console.WriteLine(i + " * " + j + " = " + j * i);
                            }
                        }
                        else
                        {
                            Console.WriteLine(i + " * " + j + " = " + j * i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(i + " * " + given_number + " = " + given_number * i);
                }
            }
        }
        public static int AskUserForParameter(string display_text = "Please write a number and press enter to get its multiplication table :", string str_type = "int")
        {
            bool result = true;
            int user_input = 0;

            do
            {
                Console.WriteLine(display_text);

                result = int.TryParse(Console.ReadLine(), out user_input);

            } while (result == false);

            return user_input;
        }
        public static void run_EXO_1()
        {
            Tables.print_tables();
            Tables.print_tables(only_odd: true);
            Tables.print_tables(given_number: (Tables.AskUserForParameter()));
        }
    }
}