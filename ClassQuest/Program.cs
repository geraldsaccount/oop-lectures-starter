namespace ClassQuest;

class Program
{
    static void Main(string[] args)
    {

        Weapon sword = new Weapon("Long Sword", 25);
        Weapon axe = new Weapon("Battle Axe", 30);

        Player hero = new Player("Aragorn", 100, new int[] { 0, 0 }, sword);
        Enemy goblin = new Enemy("Goblin", 75, new int[] { 1, 0 }, axe);

        hero.Attack(goblin);
        goblin.Attack(hero);
    }
}