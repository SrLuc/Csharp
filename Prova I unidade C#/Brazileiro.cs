public class Brazileiro : Restaurante
{
    private string? nome;
    public bool menuInternacional;
    public bool menuRegional;
    public int qtdGarcom;
    public bool mscAoVivo;

    public string? Nome { get => nome; set => nome = value; }

    public Brazileiro(string? nome)
    {
        this.Nome = nome;
    }

    public Brazileiro(string? nome, bool menuRegional)
    {
        this.Nome = nome;
        this.menuRegional = menuRegional;
    }

    public void PrepararFeijao()
    {
        System.Console.WriteLine("Preparando o feijão na panela");
    }

    public void tocarMusica()
    {
        System.Console.WriteLine("Tocando Pé de Serra!");
    }

    public override void Servir()
    {
        base.Servir();
        System.Console.WriteLine("As pessoas ficam felizes");
    }

}