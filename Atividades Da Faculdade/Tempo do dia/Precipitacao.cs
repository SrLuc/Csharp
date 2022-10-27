using System;
public class Preciptacao
{
    //atributos
    public int probabilidadeDeChover;
    //método
    public void Chover(Insolacao i)
    {
        this.probabilidadeDeChover = new Random() .Next(1,10);
        i.probabilidadeDeFazerSol = new Random() .Next(1,5);
        if (this.probabilidadeDeChover > i.probabilidadeDeFazerSol)
        {
            Console.WriteLine("Hoje vai ser dia de chuva");
        }
    }


}