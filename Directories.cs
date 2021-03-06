using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_sharpAssessment7

{
    public class Directories
    {
        static void Main()

        {
            /* Create Directory*/
            string path = @"F:\C# assessments";
            string directoryPath = @"F:\marks";

            /* Created directory using Directory  */
            DirectoryInfo dir = Directory.CreateDirectory(directoryPath);


            /*gives dir fullname*/
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.Name);



            /*Create directory using DirectoryInfo*/

            DirectoryInfo dirs = new DirectoryInfo(path);


            /* Delete directory*/

            dirs.Delete(true);

            /*Create Directory*/
            dirs.Create();

            /* Directory moved to path2*/

            dirs.MoveTo(directoryPath);

            /* create subDirectory*/

            dirs.CreateSubdirectory("MysubDir");

            Console.WriteLine("Directory Created");
            Console.ReadLine();



        }
    }
}
