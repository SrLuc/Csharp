public class Ferramenta
{
    public string? nome;
    public int dureza;
    public int porrada;


    public void Bater(Obstaculo o)
    {
        this.porrada = new Random() .Next(0,7);
        if (this.porrada > o.resistencia)
        {
            Console.WriteLine($"o {this.nome} bateu na parede de {o.material}");
        }
        else if (o.resistencia > this.porrada)
        {
            Console.WriteLine($"a parede de {o.material} é mais dura que o {this.nome}");
        }
    }   
}
