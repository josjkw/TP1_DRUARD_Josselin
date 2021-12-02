
using System;

namespace TRY_CATCH
{
    public class Catch_Me_If_You_Can
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void calc_function()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    int func_result = PowerFunction(i);
                    Console.WriteLine("x = " + i + " -> 10/" + func_result + " = " + 10 / func_result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("x = " + i + " results in a DivideByZeroException, please be a better developer");
                }
            }
        }
        public static void run_EXO_3(){
            Console.WriteLine("\nEXO 3\n");
            Catch_Me_If_You_Can.calc_function();
        }
    }
}