using System;

public class Character
{
    public string? name;
    private int strenght;
    private string? group;
    private int life;

    public Spell magic;
    public Weapon weapo;

    public Character(string? name, int strenght, string? group, int life, Spell magic)
    {
        this.Name = name;
        this.Strenght = strenght;
        this.Group = group;
        this.Life = life;
        this.magic = magic;
    }

        public Character(string? name, int strenght, string? group, int life, Weapon weapo)
    {
        this.Name = name;
        this.Strenght = strenght;
        this.Group = group;
        this.Life = life;
        this.weapo = weapo;
    }

    public string? Name { get => name; set => name = value; }
    public int Strenght { get => strenght; set => strenght = value; }
    public string? Group { get => group; set => group = value; }
    public int Life { get => life; set => life = value; }
}

