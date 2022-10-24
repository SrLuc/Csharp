using System;

public class Spell : Artefact
{
    public string? name;
    private int power;

    public Spell(string? name, int power)
    {
        this.name = name;
        this.power = power;
    }
}


