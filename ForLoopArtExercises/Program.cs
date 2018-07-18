using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopArtExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pattern A:");

            for (int i = 1; i <= 8; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Pattern B:");

            for (int i = 8; i >=1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Pattern C: ");

            

            for (int i = 1; i <= 8; i++)
            {

                for (int j = 1; j <=i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 8; k >= i; k--)
                {
                    Console.Write("#");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Pattern D: ");

            for (int i = 1; i <= 8; i++)
            {

                for (int j = 8; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Pattern E: ");

            for (int i = 1; i <= 7; i++)
            {

                for (int j = i; i <= 7; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
                for (int k = 2; k <= 6; k++)
                {
                    Console.WriteLine("#     #");
                }
                for (int m = 7; m >= 1; m--)
                {
                    Console.Write("#");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("Pattern F: ");

            Console.WriteLine("# # # # # # #");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }
                Console.Write("#");
                Console.WriteLine("");
            }
            Console.WriteLine("# # # # # # #");

            Console.WriteLine("");
            Console.WriteLine("Pattern G: ");

            Console.WriteLine("#######");
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 5; j >= i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("#");
                Console.WriteLine("");
            }
            Console.WriteLine("#######");
            Console.ReadKey();
        }
    }
}
