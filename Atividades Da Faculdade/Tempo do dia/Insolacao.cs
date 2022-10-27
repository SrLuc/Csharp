using System;

public class Insolacao
{
    //atributos
    public int probabilidadeDeFazerSol;
    //método
    public void FazerSol(Preciptacao p)
    {
        this.probabilidadeDeFazerSol = new Random() .Next(1,10);
        p.probabilidadeDeChover = new Random() .Next(1,5);
        if (this.probabilidadeDeFazerSol > p.probabilidadeDeChover)
        {
            Console.WriteLine("Hoje vai ser um dia Ensolarado");
        }
    }
}

