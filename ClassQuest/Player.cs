// Author: Gérald Montúfar
// Created: 26.10.2025

namespace ClassQuest;

public class Player
{
    public string Name;
    public int Health;
    public int[] Position;

    public Weapon Weapon;

    public Player()
    {
        Name = "Player";
        Health = 100;
        Position = new int[] { 0, 0 };
        Weapon = new Weapon("Fists", 10);
    }

    public Player(string name, int health, int[] position, Weapon weapon)
    {
        Name = name;
        Health = health;
        Position = position;
        Weapon = weapon;
    }

    public void Attack(Enemy defending)
    {
        Console.WriteLine($"{Name} is attacking {defending.Name} with {Weapon.Name}.");
        defending.TakeDamage(Weapon);
    }

    public void TakeDamage(Weapon weapon)
    {
        Health -= weapon.Damage;
        Console.WriteLine($"{Name} has {Health} HP left.");
    }

    public void Move(int[] direction)
    {
        Position[0] += direction[0];
        Position[1] += direction[1];
        Console.WriteLine($"{Name} is at ({Position[0]}, {Position[1]})");
    }
}