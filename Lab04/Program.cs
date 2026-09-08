/*
 * Student ID : 1690703663
 * Name       :
 * Section    :129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("                New ADventure                   ");
            Console.WriteLine("---------------------");
            Console.Write("Hero Name");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\n\"Welcome, {playerName}. Your Journey Begin.../");

            Console.WriteLine("---------------------");
            Console.WriteLine("                Difficulty Select              ");
            Console.WriteLine("---------------------");
            Console.Write("Choose Difficulty (1-3): ");
            int Difficulty = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"\n\"Difficulty {Difficulty} Selected. Good Luck Nigga...");

            Console.WriteLine("---------------------");
            Console.WriteLine("                Item Shop                   ");
            Console.WriteLine("---------------------");
            Console.Write("How Many Potion");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);

            Console.WriteLine($"Valid Input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine("---------------------");
            Console.WriteLine("      Character Design     ");
            Console.WriteLine("---------------------");
            Console.Write("Name Your Character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting Luck (0.0 - 10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double Luck);
            Console.WriteLine($"\n{charName} The class-{classNum} adventurer Enter The Dungeon. Luck: {Luck}");

            Console.WriteLine("---------------------");
            Console.WriteLine("                Music Volume Setting                   ");
            Console.WriteLine("---------------------");
            Console.Write("Set Music Volume (0.0 - 1.0): ");
            bool volumeOk = double .TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("---------------------");
            Console.WriteLine("                Save Name                   ");
            Console.WriteLine("---------------------");
            Console.Write("Enter Save Name ");
            string saveName = Console.ReadLine();
            Console.WriteLine($"\n\"Save Name: {saveName}\"");
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");

        }
    }
}
