
using System;
using System.Collections.Generic;
/*
Light | George
Dark | Peter
Lumpawaroo

Lighter | Royal
Darker | DCay
John Johnys -> Lighter
DCay -> Lighter
Lumpawaroo
*/

SortedDictionary<string, SortedSet<string>> members = new(); 

string arguments = string.Empty;
while ((arguments = Console.ReadLine()) != "Lumpawaroo")
{
    string[] command = arguments
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (command.Contains("|"))
    {
        string[] token = arguments
            .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string side = token[0];
        string userName = token[1];
        if (!members.Values.Any(u => u.Contains(userName)))
        {
            if (!members.ContainsKey(side))
            {
                members.Add(side, new SortedSet<string>());
            }
            members[side].Add(userName);
        }
       

    }
    else if (command.Contains("->"))
    {
        string[] token = arguments
            .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        string userName = token[0];
        string side = token[1];

        foreach (var currMember in members)
        {
            if (currMember.Value.Contains(userName))
            { 
                currMember.Value.Remove(userName);
                break;
            }
        }

        if(members.ContainsKey(side))
        {
            members[side].Add(userName);
            Console.WriteLine($"{userName} joins the {side} side!");
        }
    } 
    else
    {
        continue;
    }
    
}

PrintResult(members);

void PrintResult(SortedDictionary<string, SortedSet<string>> memebrs)
{
    foreach (var currMember in memebrs.OrderByDescending(m => m.Value.Count))
    {
        if (currMember.Value.Any())
        {
            Console.WriteLine($"Side: {currMember.Key}, Members: {currMember.Value.Count}");
            foreach (var name in currMember.Value)
            {
                Console.WriteLine($"! {name}");
            }
        }
        
       
    }
}

