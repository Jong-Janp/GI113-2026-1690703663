/*
 * Student ID : 1690703663
 * Name       :Lab02
 * Section    :129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hp: {currentHp}");
            Console.WriteLine($"Attackpower: {attackPower}");
            Console.WriteLine($"CritMutiplier: {critMultiplier}");
            Console.WriteLine($"Isboss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp * 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Precent: {hpPercent}%");

            string charName = "Nou";
            char speed = 'A';
            int maxAP = 1000;
            int currentAP = 240;
            int range = 175;
            float attackSpeed = 0.6f;
            double critChance = 20;
            bool isChar = true;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {charName}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"MaxAP: {maxAP}");
            Console.WriteLine($"AP: {currentAP}");
            Console.WriteLine($"Range: {range}");
            Console.WriteLine($"Critchance: {critChance}");
            Console.WriteLine($"Isboss: {isChar}");
            Console.WriteLine();
            int APPercent = currentAP * 100 / maxAP;
            Console.WriteLine($"AP percent: {APPercent}%");
            Console.WriteLine();
            currentAP = currentAP * 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"AP: {currentAP} / {maxAP}");
            APPercent = currentAP * 100 / maxAP;
            Console.WriteLine($"AP Precent: {APPercent}%");

        }
    }
}
