using System;
using System.Collections;

namespace Hash_Table_Practice
{
    /*Problem 3:

      Create a program that will accept from the user the name of an item and the description of that item. 
      Use the HashTable from standard collections.

      The user can then enter the item name of any item and the program will provide the description.
     * 
     */


    class Program
    {
        static void Main(string[] args)
        {
            Hashtable items = new Hashtable();

            bool addMore = true;
            bool retry = true;
            string answer = "";

            while (addMore)
            {
                Console.WriteLine("Enter an item");
                string item = Console.ReadLine();

                Console.WriteLine("Enter a description to that item");
                string itemDescription = Console.ReadLine();

                try
                {
                    items.Add(item, itemDescription);
                }
                catch (Exception)
                {

                    Console.WriteLine("That item already exists...\n\n");
                }
                

                

                retry = true;
                while (retry)
                {

                    Console.WriteLine("Would you like to add another item?");
                    Console.WriteLine("[ Yes ] or [ No ]");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        retry = false;

                    }
                    else if (answer.ToLower() == "no")
                    {
                        addMore = false;
                        retry = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer. Please type Yes or No");
                        retry = true;
                    }


                }
                
            }

            bool seeMore = true;
            retry = true;

            while (seeMore)
            {
                Console.WriteLine("Enter an item to see its description");
                string input = Console.ReadLine();

                try
                {
                    Console.WriteLine(items[input]);
                }
                catch (Exception)
                {

                    Console.WriteLine("That item does not exist");
                }


                retry = true;
                while (retry)
                {
                    Console.WriteLine("Would you like to see a different item description?");
                    Console.WriteLine("[ Yes ] or [ No ]");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        retry = false;

                    }
                    else if (answer.ToLower() == "no")
                    {
                        seeMore = false;
                        retry = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer. Please type Yes or No");
                        retry = true;
                    }

                }
            }
            
        }

        
    }

    
}
