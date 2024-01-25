namespace CopyDirectory
{
    using System;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"D:\SoftUni_CSharp_Advanced\10 - Exercise Streams, Files and Directories\10 - Exercise Streams, Files and Directories\Test";
            string outputPath = @$"D:\SoftUni_CSharp_Advanced\10 - Exercise Streams, Files and Directories\10 - Exercise Streams, Files and Directories\Test";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(inputPath))
            { 
                Directory.Delete(outputPath, true);
            }
        }
    }
}
