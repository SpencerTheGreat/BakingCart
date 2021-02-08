using System;
using System.IO;

namespace BakeryShoppingCart.FileManager
{
    public class FileManagerClass
    {
        public FileManagerClass()
        {
        }
        public void CreateAFile(string fileName)
        {
            if (File.Exists(fileName))
            {

                Console.WriteLine("File exists");

                DateTime fileCreateOn =
                    File.GetCreationTime(fileName);
                Console.WriteLine("File was created on" +
                    fileCreateOn);

                DateTime modifiedOn =
                    File.GetLastWriteTime(fileName);
                Console.WriteLine("File was modified on" +
                    modifiedOn);
            }
            else
            {

                File.Create(fileName);
                Console.WriteLine("You have created the file: " +
                    fileName);
            }
        }
    }
}
