using System;

namespace LinkedList_FromScratch
{

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine(list.listSize());
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            Console.WriteLine(list.listSize());

        }
    }
}
