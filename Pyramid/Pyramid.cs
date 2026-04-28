using System;

/*

    *
   ***
  *****
 *******
*********

ACCEPTANCE CRITERIA:
Write a script to output this pyramid on console (with leading spaces)

*/
namespace Pyramid
{
    public class Program
    {
        private static void Pyramid(int height)
        {
            for (var i = 1; i <= height; i++)
            {
                var spaces = new string(' ', height - i);
                var stars  = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
        }

        public static void Main(string[] args)
        {
            Pyramid(5);
        }
    }
}