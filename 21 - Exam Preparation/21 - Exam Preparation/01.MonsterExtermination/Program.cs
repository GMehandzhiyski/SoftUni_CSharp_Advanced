﻿namespace _01.MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] monstarArmorInput = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] soldierImpactInput = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> monstarArmor = new Queue<int>(monstarArmorInput);
            Stack<int> soldierImpact = new Stack<int>(soldierImpactInput);
            int killedMonsters = 0;
            while (monstarArmor.Any()
                   && soldierImpact.Any())
            {
                int currMonsterArmor = monstarArmor.Dequeue();
                int currSoldierImpact = soldierImpact.Pop();
                //int originalStrike = currSoldierImpact;
                int nextSoldierImpact = 0;

                if (currSoldierImpact >= currMonsterArmor)
                {
                    currMonsterArmor = monstarArmor.Dequeue();
                    currSoldierImpact = currSoldierImpact - currMonsterArmor;
                    if (currSoldierImpact > 0)
                    {
                        if (soldierImpact.Any())
                        {
                            nextSoldierImpact = soldierImpact.Pop();
                        }
                        soldierImpact.Push(currSoldierImpact + nextSoldierImpact);
                    }

                    killedMonsters++;
                }
                if (currSoldierImpact < currMonsterArmor)
                {
                    currMonsterArmor = currMonsterArmor - currSoldierImpact;
                    monstarArmor.Enqueue(currSoldierImpact);
                }
            }
            if (!monstarArmor.Any()
                && soldierImpact.Any())
            {
                Console.WriteLine("All monsters have been killed!");
            }
            else
            {
                Console.WriteLine("The soldier has been defeated.");
            }

            Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }
    }
}