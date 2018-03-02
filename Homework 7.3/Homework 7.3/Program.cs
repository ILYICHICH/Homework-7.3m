using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 3, 2, 1 };

            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
            Console.WriteLine(' ');
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
        }
    }
}
