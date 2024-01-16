namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentNumber = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentNumber; i++)
            {
                string[] inputString = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = inputString[0];
                double studentGrade = double.Parse(inputString[1]);

                if (!students.ContainsKey(studentName))
                {
                   students.Add(studentName, new List<double>());
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
            }

            foreach (var (currStudent,currGrades) in students)
            {
                double averageGrade = currGrades.Average();
                Console.Write($"{currStudent} -> ");

                foreach (var currGrade in students)
                {
                    Console.WriteLine($"{currGrade.Value}:f2");
                }
                Console.WriteLine($"(avr:{averageGrade:f2})");
            }
        }
    }
}