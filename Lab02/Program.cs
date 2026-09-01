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

            string name = "Xas";
            char AD = 'A';
            int maxAD = 1000;
            int currentAD = 240;
            int luck = 175;
            float DPS = 0.6f;
            double luckMultiplier = 20;
            bool isHumanoid = true;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {AD}");
            Console.WriteLine($"MaxAP: {maxAD}");
            Console.WriteLine($"AP: {currentAD}");
            Console.WriteLine($"Range: {luck}");
            Console.WriteLine($"Critchance: {DPS}");
            Console.WriteLine($"Isboss: {isHumanoid}");
            Console.WriteLine();
            int ADPercent = currentAD * 100 / maxAD;
            Console.WriteLine($"AP percent: {ADPercent}%");
            Console.WriteLine();
            currentAD = currentAD * 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"AP: {currentAD} / {maxAD}");
            ADPercent = currentAD * 100 / maxAD;
            Console.WriteLine($"AP Precent: {ADPercent}%");

            string pName = "Xavos";
            char power = 'F';
            int iq = 1000;
            int currentIq = 240;
            int maxIq = 175;
            float brainSpeed = 0.6f;
            double brainPower = 20;
            bool isHuman = true;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {pName}");
            Console.WriteLine($"Speed: {power}");
            Console.WriteLine($"MaxAP: {iq}");
            Console.WriteLine($"AP: {currentIq}");
            Console.WriteLine($"Range: {maxIq}");
            Console.WriteLine($"Critchance: {brainSpeed}");
            Console.WriteLine($"Isboss: {isHuman}");
            Console.WriteLine();
            int iqPercent = currentIq * 100 / maxIq;
            Console.WriteLine($"AP percent: {iqPercent}%");
            Console.WriteLine();
            currentIq = currentIq * 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"AP: {currentIq} / {maxIq}");
            iqPercent = currentIq * 100 / maxIq;
            Console.WriteLine($"AP Precent: {iqPercent}%");
        }
    }
}
