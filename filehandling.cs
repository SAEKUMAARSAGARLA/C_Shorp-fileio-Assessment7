using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace C_sharpAssessment7
{
    public class FileHandling
    {
        public static void Main()
        {

            string writeText = "Hello World!";  // Create a text string


            File.WriteAllText(@"F:\filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText(@"F:\filename.txt");  // Read the contents of the file


            Console.WriteLine(readText);  // Output the content

            /* Created Copy*/

            File.Copy(@"F:\filename.txt", @"D:\Test.txt");


            File.AppendAllText(@"F:\Test.txt", "Appent this content");



            File.Copy(@"F:\Test.txt", @"D:\Test1.txt");

            /*Delete File*/

            File.Delete(@"F:\Test1.txt");


            File.Encrypt(@"F:\Test.txt");

            /*Decrypt the file*/

            File.Decrypt(@"F:\Test.txt");


            /*Create File Info*/

            string myPath = @"F:\rama\hey.txt";

            FileInfo fileinfo = new FileInfo(myPath);
            /* Created the file using FileInfo*/

            FileStream fs = fileinfo.Create();
            Console.WriteLine("created");




            fs.Close();


            /* to open the text file*/

            StreamReader sr = fileinfo.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }


            sr.Close();




        }
    }
}
