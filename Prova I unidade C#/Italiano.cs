public class Italiano : Restaurante
{
    private string? nome;
    public bool menuEuropeu;
    public bool especilistaPizza;
    public string? Nome { get => nome; set => nome = value; }
    public Italiano(string? nome)
    {
        this.Nome = nome;
    }

    public void coletar()
    {
        System.Console.WriteLine("Coletando os tomates para a pizza");
    }
}