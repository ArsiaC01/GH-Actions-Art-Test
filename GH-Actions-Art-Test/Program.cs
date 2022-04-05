using GH_Actions_Art_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        // Main method for class.
        static void Main()
        {
            // Declares an array of 10 Square objects.
            Square[] squareArray = new Square[10];
            // Creates 10 Square objects with values 1 through 10 and assigns them to the array.
            for (int i = 0; i < squareArray.Length; i++)
            {
                squareArray[i] = new Square(i + 1);
            }
            // Display the values for each Square object in the array using for loop.
            for (int i = 0; i < squareArray.Length; i++)
            {
                Console.WriteLine("Side = {0}, Area = {1}", squareArray[i].Side, squareArray[i].Area);
            }

            Console.ReadKey();
        }
    }
}