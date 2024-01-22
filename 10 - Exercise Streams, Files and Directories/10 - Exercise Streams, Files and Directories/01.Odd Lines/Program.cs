namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new(inputFilePath))
            { 
                using(StreamWriter writer = new(outputFilePath,true)) 
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream) 
                    {
                        lineNumber++;
                        string line = reader.ReadLine();
                        if (lineNumber % 2 == 1)
                        {
                            continue;
                        }
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
