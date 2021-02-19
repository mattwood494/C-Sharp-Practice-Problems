using System;
using System.IO;

namespace Document
{
    class HW1Program
    {
        static void Main(string[] args)
        {
            
            //Testing to make sure program functions as it is supposed to
            Document testDoc = new Document();
            Console.WriteLine("Write some text: ");
            testDoc.WriteToDoc();
            testDoc.SignDocument();
            
            testDoc.WriteToDoc();
            testDoc.OpenAndRead();
        }
    }

    public class Document
    {
        
        // store text that was written to a file
        public string _text { get; set; }


        //gives this class the ability to sign doc
        public SignedDocument document = new SignedDocument();

        //where the file will be stored
        public string path = "doc.txt";

        
        
        public void WriteToDoc()
        {
            
            //if the document has not been signed yet, then add text.
            if (document.Signature == null)
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
            else if (true) //message displayed if doc has already been signed
            {
                Console.WriteLine("This document has been signed and is no longer edittable");
            }

            
        }

        public void SignDocument() 
        {
            Console.Write("Signed: ");
            string signature = Console.ReadLine();

            document.Signature = signature; //store signature in instance of SignedDocument class

            
            // add signature to file
            File.AppendAllText(path, signature + Environment.NewLine); 
            signature = Console.ReadLine();
            
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

    public class SignedDocument
    {
        private string _signature = null;

        public string Signature
        {
            
            //allow user to only write a signature once
            get { return _signature; }
            set {
                    if (_signature == null)
                    {
                        _signature = value;
                    }
                }
        }

    }
}
