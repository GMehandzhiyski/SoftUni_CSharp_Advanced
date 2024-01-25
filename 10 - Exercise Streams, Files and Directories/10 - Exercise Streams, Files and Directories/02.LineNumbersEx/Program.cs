using System.Text;
using System.Xml;

public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\Files\input.txt";
        string outputFilePath = @"..\..\..\Files\output.txt";

        ProcessLines(inputFilePath, outputFilePath);
    }
    public static void ProcessLines(string inputFilePath, string outputFilePath)
    {
        StringBuilder sb = new();

        string[] lines = File.ReadAllLines(inputFilePath);

        for (int i = 0; i < lines.Length; i++)
        {
            int letterCount = lines[i].Count(ch => char.IsLetter(ch));
            int symbolCount = lines[i].Count(sy => char.IsPunctuation(sy));

            sb.AppendLine($"Line {i + 1}: {lines[i]} ({letterCount})({symbolCount})".TrimEnd());
            //Console.WriteLine(($"Line {i + 1}: {lines[i]} ({letterCount})({symbolCount})"));
            using StreamWriter writer = new(outputFilePath);
            {
                writer.WriteLine(sb.ToString().TrimEnd());
            }
        }
        

        //File.WriteAllLines(outputFilePath, sb.ToString().TrimEnd()); // thiss function is not working

    }
}