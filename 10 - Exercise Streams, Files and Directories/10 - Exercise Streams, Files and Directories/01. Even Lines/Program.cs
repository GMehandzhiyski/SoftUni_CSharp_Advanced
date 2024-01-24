namespace EvenLines;

using System;
using System.Data.SqlTypes;
using System.Runtime.ConstrainedExecution;
using System.Text;

public class EvenLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\text.txt";

        Console.WriteLine(ProcessLines(inputFilePath));
    }

    public static string ProcessLines(string inputFilePath)
    {
        StringBuilder sb = new ();

        using StreamReader reader = new(inputFilePath);

        string line = string.Empty;
        int lineNumber = 2;
        while ((line = reader.ReadLine()) != null)
        {
            
            if(lineNumber % 2 == 0)
            { 
                string replacedSymbol = ReplacedSymbol(line);
                string revercedString = RevercedString(replacedSymbol);
                sb.AppendLine(revercedString);
            }
            lineNumber++;
        }

        return sb.ToString().TrimEnd();
    }
    private static string ReplacedSymbol(string line)
    {
        char[] symbols = { '-', ',', '.', '!', '?' };
        foreach (var currsymbol in symbols)
        {
            line = line.Replace(currsymbol, '@');
        }
       
        return line;
    }

    private static string RevercedString(string replacedSymbol)
    {
        string[] revercedString = replacedSymbol
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Reverse()
            .ToArray();
   
        
        return string.Join(" ",revercedString).TrimEnd();
    }

}

