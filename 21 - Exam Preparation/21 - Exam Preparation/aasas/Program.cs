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
//==================================================================================
                    currMonsterArmorRemainder = currMonsterArmor - originalStrike;
                    monstarArmor.Enqueue(currMonsterArmorRemainder);
 //=======================================================================================                  

                }
            }
//==================================================================================================
            if (monstarArmor.Count == 0)
            {
                Console.WriteLine("All monsters have been killed!");
            }

            if(soldierImpact.Count == 0)
            {
                Console.WriteLine("The soldier has been defeated.");
            }

            Console.WriteLine($"Total monsters killed: {killedMonsters}");
//======================================================================================================















            //int[] monstarArmorInput = Console.ReadLine()
            //    .Split(",", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //int[] soldierImpactInput = Console.ReadLine()
            //    .Split(",", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //Queue<int> monstarArmor = new Queue<int>(monstarArmorInput);
            //Stack<int> soldierImpact = new Stack<int>(soldierImpactInput);

            //int killedMonsters = 0;

            //while (monstarArmor.Any()
            //       && soldierImpact.Any())
            //{
            //    int currMonsterArmor = monstarArmor.Dequeue();
            //    int currSoldierImpact = soldierImpact.Pop();
            //    int originalStrike = currSoldierImpact;
            //    int nextSoldierImpact = 0;
            //    int currSoldierImpactRemainder = 0;
            //    int currMonsterArmorRemainder = 0;

            //    if (currSoldierImpact >= currMonsterArmor)
            //    {
            //        currSoldierImpactRemainder = currSoldierImpact - currMonsterArmor;
            //        if (currSoldierImpactRemainder > 0)
            //        {
            //            if (soldierImpact.Any())
            //            {
            //                nextSoldierImpact = soldierImpact.Pop();
            //            }

            //            soldierImpact.Push(currSoldierImpactRemainder + nextSoldierImpact);
            //        }

            //        killedMonsters++;
            //    }
            //    else 
            //    {
            //        currMonsterArmorRemainder = currMonsterArmor - originalStrike;
            //        monstarArmor.Enqueue(currMonsterArmorRemainder);
            //    }
            //}
            //if (monstarArmor.Count == 0)
            //{
            //    Console.WriteLine("All monsters have been killed!");
            //}

            //if(soldierImpact.Count == 0)
            //{
            //    Console.WriteLine("The soldier has been defeated.");
            //}

            //Console.WriteLine($"Total monsters killed: {killedMonsters}");
        }
    }
}