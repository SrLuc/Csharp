public class Japones : Restaurante
{
    private string? nome;
    public string? menu;
    public bool sushiBrazileiro;
    public string? Nome { get => nome; set => nome = value; }
    public Japones(string? nome)
    {
        this.Nome = nome;
    }

    public void Pescando()
    {
        System.Console.WriteLine("Pescando os frutos do mar");
    }
}