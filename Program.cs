using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {

            // playing with multidimensional array

            // int[,] array [3, 3] = {
            //   0  { 1, 2, 3 }, [0, y]
            //   1  { 10, 15, 20 }, [1, y]
            //   2  { 30, 40, 50 } [2, y]
            // };      0   1   2
            //    [x, 2] [x, 2] [x, 2]
            int[,] array4 = new int[5, 5] {
                { 1, 2, 3, 4, 5 },
                { 2, 1, 2, 3, 4 },
                { 3, 2, 1, 2, 3 },
                { 4, 3, 2, 1, 2},
                { 5, 4, 3, 2, 1 },
            };
            int x, y;

            //x is Column
            //y is Line

            bool isOpen = true;

            while(isOpen)
            {
                Console.Write("Line: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Column: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(array4[y, x]);

                Console.WriteLine("\n1 - yes \n2 - no");
                Console.Write("Continue? ");
                
                int input = Convert.ToInt32(Console.ReadLine());
                
                if (input == 1)
                {
                    //continue "while" loop
                }

                if (input == 2)
                {
                    //stop the program
                    isOpen = false;
                    break;
                }

                Console.Clear();
            }
            
        }

    }

}
