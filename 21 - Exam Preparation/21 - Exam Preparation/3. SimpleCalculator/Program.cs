
string[] inputString = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries);


Stack<string> stackNumber = new Stack<string>(inputString.Reverse());

int reuslt = 0;
int number = 0;
int sum = int.Parse(stackNumber.Pop());


while (stackNumber.Any())
{
    string sumbol = stackNumber.Pop();
    number = int.Parse(stackNumber.Pop());

    if (sumbol == "-")
    {
        sum -= number;
    }
    if (sumbol == "+")
    {
        sum += number;
    }


}

Console.WriteLine(sum);
