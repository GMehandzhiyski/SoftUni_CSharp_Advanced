using System.Reflection.PortableExecutable;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);

        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<char> firstNumber = new List<char>();
            List<char> secondNumber = new List<char>();
            List<char> finalNumber = new List<char>();

            string argumets = string.Empty;

            using StreamReader firstReader = new(firstInputFilePath);
            {
                while ((argumets = firstReader.ReadLine()) != null)
                {
                    foreach (var currNum in argumets)
                    {
                        firstNumber.Add(currNum);
                    }
                   
                }
                
            }
            using StreamReader secondReader = new(secondInputFilePath);
            {
                while ((argumets = secondReader.ReadLine()) != null)
                {
                    foreach (var currNum in argumets)
                    {
                        secondNumber.Add(currNum);
                    }
                }
            }
            using StreamWriter outputWriter = new (outputFilePath);
            {
                int firstCout = 0;
                int secondCout = 0;
                for (int i = 0; i < (firstNumber.Count + secondNumber.Count); i++)
                {

                    if (i % 2 == 0
                        && firstNumber.Count > firstCout)
                    {
                        finalNumber.Add(firstNumber[firstCout]);
                        firstCout++;
                    }
                    else
                    {
                        finalNumber.Add(secondNumber[secondCout]);
                        secondCout++;
                    }
                }


                for (int i = 0; i < finalNumber.Count; i++)
                {
                    outputWriter.WriteLine(finalNumber[i]);
                }
            }

        }
    }
}
