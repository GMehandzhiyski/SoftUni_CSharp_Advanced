
using System.Reflection.PortableExecutable;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> keyWords = new();
            string currWord = String.Empty;
            List<string> wordsText = new();

            using StreamReader readerWords = new (wordsFilePath);
            {   
                while ((currWord = readerWords.ReadLine()) != null)
                {
                    string[] token = currWord
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    foreach (var currToken in token)
                    {
                        keyWords.Add(currToken, 0);
                    }
                   
                }
            }

            using StreamReader readerText = new(wordsFilePath);
            {
               
                string argumets = string.Empty;

                while ((argumets = readerText.ReadLine()) != null) 
                {
                    string[] toknen =  argumets
                        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();


                }





                using StreamWriter writer = new(outputFilePath);
                { 
                    
                
                }
            }
        }
    }
}
