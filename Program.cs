using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{

    internal class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Fibonachi sequence revealer, please enter the number of sequences you want.");
                int g = Convert.ToInt32(Console.ReadLine());
                if (g < 0)
                {
                    Console.WriteLine("Negative numbers can not be used in Fibonachi sequence!");
                }
                else
                {
                    for (int i = 0; i <= g; i++)
                    {
                        if (i == g)
                        {
                            Console.Write(Fibonachi(i) + ".");
                        }
                        else
                        {
                            Console.Write(Fibonachi(i) + ", ");
                        }
                    }

                }
                    Console.ReadKey();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Bad input.");
                Console.ReadKey();
            }
            

        }
    }
}
