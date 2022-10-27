using System;

//Criando a class Arma

public class Weapon : Artefact
{
    public string? name;
    private int power;


    //Criando Construtor do Poder da arma
    public Weapon(int power)
    {
        this.power = power;
    }
}
