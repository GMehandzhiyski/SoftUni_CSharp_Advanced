namespace CopyDirectory
{
    using System;
    using System.Runtime.CompilerServices;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = $@"{Console.ReadLine()}";
            string outputPath = $@"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            { 
                Directory.Delete(outputPath, recursive:true);
            }

            Directory.CreateDirectory(outputPath);

            string[] files = Directory.GetFiles(inputPath);

            foreach (var file in files)
            {
                string filiName = Path.GetFileName(file);
                string destination = Path.Combine(outputPath, filiName);
                File.Copy(file, outputPath) ;
            }
        }
    }
}
