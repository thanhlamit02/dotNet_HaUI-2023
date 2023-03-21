using System;

namespace CopyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"C:\source\hello.txt";
            string destinationFile = @"D:\target\world.txt";
            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
