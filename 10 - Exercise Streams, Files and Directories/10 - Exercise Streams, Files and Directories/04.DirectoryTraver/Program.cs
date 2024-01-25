namespace DirectoryTraversal
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = @"D:\SoftUni_CSharp_Advanced";
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionFiles = new();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (string file in files) 
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!extensionFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionFiles[fileInfo.Extension].Add(fileInfo);    
            
            }

            StringBuilder sb = new();

            foreach (var extensionFile in extensionFiles.OrderByDescending(e => e.Value.Count))
            {
                sb.AppendLine(extensionFile.Key);

                foreach (var file in extensionFile.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"-{file.Name} - {(double)file.Length/1024:f3}kb");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {

            string filePath = 
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName; 
           File.WriteAllText(filePath, textContent );
        }
    }
}
