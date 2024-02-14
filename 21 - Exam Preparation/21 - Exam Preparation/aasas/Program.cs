namespace _01.MonsterExtermination
{
   public class Program
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
                int originalStrike = currSoldierImpact;
                int nextSoldierImpact = 0;
                int currSoldierImpactRemainder = 0;
                int currMonsterArmorRemainder = 0;

                if (currSoldierImpact >= currMonsterArmor
                    && currSoldierImpact != 0)
                {
                    currSoldierImpactRemainder = currSoldierImpact - currMonsterArmor;
                    if (currSoldierImpactRemainder > 0)
                    {
                        if (soldierImpact.Any())
                        {
                            nextSoldierImpact = soldierImpact.Pop();
                        }
                        soldierImpact.Push(currSoldierImpactRemainder + nextSoldierImpact);
                       
                    }

                    killedMonsters++;
                }
                if (currSoldierImpact < currMonsterArmor)
                {
                    currMonsterArmorRemainder = currMonsterArmor - originalStrike;
                    if (currMonsterArmorRemainder > 0)
                    {
                        monstarArmor.Enqueue(currMonsterArmorRemainder);
                    }
                    
                }
            }
            if (monstarArmor.Any()
                && !soldierImpact.Any())
            {
                
                Console.WriteLine("The soldier has been defeated.");
            }
            else
            {
                Console.WriteLine("All monsters have been killed!");
            }

            Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }
    }
}