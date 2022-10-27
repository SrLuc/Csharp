using System;

public class Charcater 
{
    //Atributos
    public string? name;
    private string? group;
    private int strength;
    private int life;
    public Weapon? weap;
    public Spell? magic;


    //métodos
    public void Fight(Charcater c1)
    {
        if (this.strength > c1.life)
        {
            Console.WriteLine("The " +this.name+ " hit in " +c1.name);
            c1.life--;
        }
        else
        {
            System.Console.WriteLine("The " +c1.name+ " hit in " +this.name);
            this.life--;
        }

        if (this.life == 0 || c1.life == 0)
        {
            System.Console.WriteLine("The battle is Finished");
            if (this.life > 0)
            {
                System.Console.WriteLine("The winner is " + this.name);
            }
            else
            {
                System.Console.WriteLine("The winner is " + c1.name);

            }
        }

    }

    //Construtore com sobrecarga em Weapon
    public Charcater(string? group, int strength, int life, Weapon? weap)
    {
        this.group = group;
        this.strength = strength;
        this.life = life;
        this.weap = weap;
    }

    //Construtore com sobrecarga em Spell
    public Charcater(string? group, int strength, int life, Spell? magic)
    {
        this.group = group;
        this.strength = strength;
        this.life = life;
        this.magic = magic;
    }

    //Encapsulamento
    public string? Group { get => group; set => group = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Life { get => life; set => life = value; }

}