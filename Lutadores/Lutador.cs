using System;

public class Lutador 
{
    public string? nome;
    public int forca;
    public int vida;

    public void Lutar(Lutador l)
    {
        this.forca = new Random() .Next(0,15);

        if (this.forca > l.vida)
        {
            Console.WriteLine($"O lutador {this.nome} bateu no lutador {l.nome}");
        }
    }
}