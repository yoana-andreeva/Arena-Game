using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int battles = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < battles; i++)
            {
                Weapon weapon = new Axe();
                Weapon weapon2 = new Knife();
                Weapon noWeapon = new Weapon("no weapon", 0);
                Hero one = new Wizard("Gandalf", weapon);
                Hero two = new Warrior("Robih Hood", weapon2);

                Console.WriteLine($"Arena fight between: {one.Name} with {one.EquippedWeapon.Name} and {two.Name} with {two.EquippedWeapon.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine("---Battle Results---");
                Console.WriteLine($"Player one: {one.Health}HP, Player two: {two.Health}HP");
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == one) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"One has {oneWins} wins.");
            Console.WriteLine($"Two has {twoWins} wins.");


            Console.ReadLine();
        }
    }
}
