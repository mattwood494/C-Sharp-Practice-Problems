using System;
using System.IO;

namespace Files
{

    /*
     * Create a program that has 2 options for a user to select.
       The first option accepts information from the user and then save that data to a file on disk.

       The second option loads all data stored on that file.
     */
    class HW5Program
    {
        static void Main(string[] args)
        {
            Document textFile = new Document();

            textFile.WriteToDoc();


            Console.WriteLine();
            Console.WriteLine();

            textFile.OpenAndRead();
        }
    }

    public class Document
    {

        // store text that was written to a file
        public string _text { get; set; }


        

        //where the file will be stored
        public string path = "doc.txt";



        public void WriteToDoc()
        {

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                _text = Console.ReadLine();

                // Write _text to a new file named "doc.txt".
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(_text);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());

            }


            


        }

        

        public void OpenAndRead()
        {
            // Open the stream and read it back.    
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }





    }
}
