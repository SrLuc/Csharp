using System;


//Criando a class Magia
public class Spell : Artefact
{
    public string? name;
    private int power;


    //Construtor do Poder da Magia
    public Spell(int power)
    {
        this.power = power;
    }
}


