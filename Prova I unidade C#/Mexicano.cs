public class Mexicano : Restaurante
{
    private string? nome;
    public int qntGarcom;
    public bool comidaPicante;
    public string? Nome { get => nome; set => nome = value; }
    public Mexicano(string? nome)
    {
        this.Nome = nome;
    }

    public void adicionar() => System.Console.WriteLine("Adicionar molho picante");
}