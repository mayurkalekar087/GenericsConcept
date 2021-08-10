using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1,2,3,4,5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'o' };
            Console.WriteLine("--------------------");
            new printArray<int>(intArray).toPrint();
            new printArray<double>(doubleArray).toPrint();
            new printArray<char>(charArray).toPrint();
           
        }
       
    }
}

