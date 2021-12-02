
using System;
using System.Collections.Generic;
using MULT_TABLES;

namespace RECTANGLE
{
    public class Rectangle
    {
        private static IDictionary<string, int> set_dimensions()
        {
            IDictionary<string, int> dimensions = new Dictionary<string, int>();

            int N = Tables.AskUserForParameter("Enter the N :");

            while (N < 1 || N > 1000)
            {
                N = Tables.AskUserForParameter("Enter the N :");
            }

            int M = Tables.AskUserForParameter("Enter the M :");

            while (M < 1 || M > 1000)
            {
                M = Tables.AskUserForParameter("Enter the M :");
            }

            dimensions.Add("N", N);
            dimensions.Add("M", M);

            return dimensions;
        }
        private static string draw_end_lines(int N)
        {
            //draw lines by just adding 0 at the ends and filling with -
            string end_line = "0";
            if (N > 1)
            {
                for (int i = 1; i <= N - 2; i++)
                {
                    end_line = end_line + "-";
                }

                return end_line + "0";
            }
            else
            {
                return end_line;
            }
        }

        private static string draw_inside_lines(int offset, int N)
        {
            //set a string to | filled with spaces
            string str_inside_line = "|";

            for (int i = 1; i < N - 1; i++)
            {
                str_inside_line = str_inside_line + " ";
            }

            str_inside_line = str_inside_line + "|";

            //convert to a char array in order to modify the components of the string
            char[] arr_inside_line = str_inside_line.ToCharArray();

            //track the positions of * using % operator and an offset changing each iteration
            for (int pos_str = 1; pos_str < str_inside_line.Length - 1; pos_str++)
            {
                if ((pos_str % 3) - offset == 0)
                {
                    arr_inside_line[pos_str] = '*';
                }
            }

            str_inside_line = new string(arr_inside_line);

            return str_inside_line;
        }

        private static void run_insideLines(int N, int M)
        {
            //draw insides lines 
            for (int i = 1; i <= M - 2; i++)
            {
                Console.WriteLine(draw_inside_lines(( i % 3), N));
            }
        }
        public static void draw_rectangle()
        {
            Console.WriteLine("\nEXO 4\n");
            IDictionary<string, int> dimensions = set_dimensions();

            Console.WriteLine(draw_end_lines(dimensions["N"]));
            run_insideLines(dimensions["N"], dimensions["M"]);
            if (dimensions["M"] > 1)
            {
                Console.WriteLine(draw_end_lines(dimensions["N"]));
            }
        }
    }
}