using System;

public class Pintura
{
    public string? cor;
    public bool tintaOleo;

    public void Pintar(Obstaculo o)
    {
        if (this.tintaOleo == true)
        {
            Console.WriteLine($"A parede foi pintada tinta cor {this.cor}");
        }
    }
}
