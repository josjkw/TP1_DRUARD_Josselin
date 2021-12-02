using System;
using MULT_TABLES;

namespace XTREE
{
    public class XTree
    {
        public static void generate_tree(int number_of_lines, int decorate_tree)
        {
            string star_line = "";
            int star_ctr = 1;

            for (int i = 0; i < number_of_lines - 1; i++)
            {
                star_line = "";
                //create a string with 1 + 2n stars
                for (int j = 0; j <= star_ctr - 1; j++)
                {
                    star_line = star_line + '*';
                }
                
                //decorate the tree if the option is chosen
                if(decorate_tree == 1){
                    star_line = decorate_line(star_line);
                }

                star_ctr = star_ctr + 2;

                Console.WriteLine(star_line.PadLeft(number_of_lines + i));
            }
            print_trunk((double)number_of_lines);
        }

        private static void print_trunk(double number_of_line)
        {
            string trunk = "| |";
            Console.WriteLine(trunk.PadLeft((int)Math.Floor(number_of_line) + 1));
        }
        private static string decorate_line(string curr_line)
        {

            char[] arr_line = curr_line.ToCharArray();
            int ctr_deco = 2;

            //loops back through the stars and adds decoration based on the given pattern
            for (int i = curr_line.Length - 1; i >= 0; i--)
            {
                //create the patter using a counter that reset every 3 char
                if (ctr_deco == 0)
                {
                    //randomize the type of decoration
                    Random deco_type = new Random();

                    if (deco_type.Next(0, 4) < 3)
                    {
                        arr_line[i] = 'i';
                    }
                    else
                    {
                        arr_line[i] = 'o';
                    }
                    ctr_deco = 3;
                }
                ctr_deco--;
            }
            curr_line = new string(arr_line);
            return curr_line;
        }
        public static void draw_tree()
        {
            Console.WriteLine("\nEXO 5\n");

            int tree_size = 0;

            //take care of staying in bounds
            do
            {
                tree_size = Tables.AskUserForParameter("Please enter the size of the tree, must be between 3 and 20");

            } while (tree_size < 3 || tree_size > 20);

            int decorate_tree = 0;

            do
            {

                decorate_tree = Tables.AskUserForParameter("Do you want to decorate the tree ? Tap 1 for yes, 0 for no");

            } while (decorate_tree != 0 && decorate_tree != 1);

            XTree.generate_tree(tree_size, decorate_tree);
        }
    }
}