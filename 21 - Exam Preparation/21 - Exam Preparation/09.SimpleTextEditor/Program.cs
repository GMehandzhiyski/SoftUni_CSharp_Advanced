

int numberOperation = int.Parse(Console.ReadLine());

Stack<string> textStack = new Stack<string>();

string mainString = string.Empty;

for (int i = 0; i < numberOperation; i++)
{
    string[] commands = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = commands[0];

    if (command == "1")
    {
        
    }
    else if (command == "2") { }
    else if (command == "3") { }
    else if(command == "4") { }
}