public abstract class Restaurante
{
    private string? localizacao;
    public string? Localizacao { get => localizacao; set => localizacao = value; }
    public virtual void Servir()
    {
        System.Console.WriteLine("Servindo a comida. . ");
    }
} 