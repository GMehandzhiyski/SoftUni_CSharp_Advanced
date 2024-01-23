
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

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

            //using StreamReader readerWords = new (wordsFilePath);
            //{   
            //    while ((currWord = readerWords.ReadLine()) != null)
            //    {
            //        string[] token = currWord
            //            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            //            .ToArray();
            //        foreach (var currToken in token)
            //        {
            //            keyWords.Add(currToken, 0);
            //        }
                   
            //    }
            //}

            using StreamReader readerText = new(textFilePath);
            {
                string textToLower = File.ReadAllText(textFilePath).ToString().ToLower();
                var  words = File.ReadAllText(wordsFilePath)
                                   .Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    string pattern = @$"\b{word}\b";
                    Regex regex = new Regex(pattern);

                    MatchCollection matchCollection = regex.Matches(textToLower);

                    if (!keyWords.ContainsKey(word))
                    {
                        keyWords[word] = matchCollection.Count;
                    }
                }
                

                using StreamWriter writer = new(outputFilePath);
                {
                    foreach (var curWord in keyWords.OrderByDescending(c => c.Value))
                    {
                        writer.WriteLine($"{curWord.Key} - {curWord.Value}");
                    }

                }
            }
        }
    }
}
