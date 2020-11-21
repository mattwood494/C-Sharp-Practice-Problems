using System;
using System.Collections;

namespace StackPractice
{
    //Create a class that inherits from the standard collection class Stack. Add a method that allows you to retrieve the 
    //last element in the stack.

    class HW4Program
    {
        static void Main(string[] args)
        {
            AdvancedStack test = new AdvancedStack();

            test.Push("first on");
            test.Push("second on");
            test.Push("third on");

            Console.WriteLine(test.RetrieveLastElement() ); 
        }

    }

    public class AdvancedStack : Stack
    {
        public object RetrieveLastElement()
        {
            object[] converted = this.ToArray(); //place contents of stack into an array

            int lastIndex = (converted.Length - 1); //obtain the index number associated with the element that went in first into the stack

            return converted[lastIndex]; //return the element that was at the bottom of the stack
        }
    }
}
