using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class printArray<T>
    {
        private T[] inputArray;//instance variable
        public printArray(T[] inputArray) // constructor
        {
            this.inputArray = inputArray;
        }
        public void toPrint() //method
        {
            foreach (var element in inputArray)
            {

                Console.WriteLine(element);
            }
            Console.WriteLine("----------------");
        }
    }
}
