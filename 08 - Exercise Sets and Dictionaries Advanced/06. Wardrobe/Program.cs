
/*
4
Red->hat
Red->dress,t - shirt,boxers
White -> briefs,tanktop
Blue -> gloves
White tanktop
*/
/*
 5 
Blue -> shoes
Blue -> shoes,shoes,shoes
Blue -> shoes,shoes
Blue -> shoes
Blue -> shoes,shoes
Red tanktop
 */
Dictionary<string, Dictionary <string,int> >  clothes = new ();

int numberOfClothes = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfClothes; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] {" -> ", "," },StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string color = tokens[0];

    if (!clothes.ContainsKey(color))
    {
        clothes.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currWear = tokens[j];

        if (!clothes[color].ContainsKey(currWear))
        {
            clothes[color].Add(currWear, 0);
        }

        clothes[color][currWear]++;


    }
}

string[] searchChois = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

PrintResult(clothes, searchChois);

void PrintResult(Dictionary<string, Dictionary<string, int>> clothes, string[] searchChois)
{
    string searchColor = searchChois[0];
    string searchWear = searchChois[1];   

    foreach (var currClothes in clothes)
    {
        Console.WriteLine($"{currClothes.Key} clothes:");
        foreach (var currWear in currClothes.Value)
        {
            Console.Write($"* {currWear.Key} - {currWear.Value}");
            if (currClothes.Key == searchColor
                && currWear.Key == searchWear)
            {
                Console.Write(" (found!)");
            }
            Console.WriteLine();
        }
    }
}