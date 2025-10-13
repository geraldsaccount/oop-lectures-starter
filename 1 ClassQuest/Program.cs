using _1_ClassQuest.Weapons;

namespace _1_ClassQuest {
    internal class Program {
        private static void Main(string[] args) {
            Character player = new Paladin("Gerald", 100, 20);
            IWeapon sword = new Sword("Excalibur", 20);
            Character enemy = new Rogue("John", 100, 0.4f, 1.2f);
            IWeapon dagger = new Dagger("Butter Knife", 30, 0.5f);

            player.EquipWeapon(sword);
            enemy.EquipWeapon(dagger);

            while (player.Health > 0 && enemy.Health > 0) {
                player.Attack(enemy);
                enemy.Attack(player);
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}

