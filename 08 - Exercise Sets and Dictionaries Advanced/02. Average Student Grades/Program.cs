namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int studentNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentNumber; i++)
            {
                string[] inputString = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    

                string studentName = inputString[0];
                decimal studentGrade = decimal.Parse(inputString[1]);

                if (!students.ContainsKey(studentName))
                {
                   students.Add(studentName, new List<decimal>());
                   
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var currStudent in students)
            {
                Console.Write($"{currStudent.Key} -> ");

                foreach (var grade in currStudent.Value)
                {
                    Console.Write($"{grade}");
                }

                Console.WriteLine($"avg: { currStudent.Value.Average():f2}");
            }
        }
    }
}