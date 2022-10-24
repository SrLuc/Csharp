using System;

public class Weapon
{
    public string? name;
    private int power;

    public Weapon(string? name, int power)
    {
        this.name = name;
        this.power = power;
    }
    
    public string? Name { get => name; set => name = value; }
    public int Power { get => power; set => power = value; }
}




