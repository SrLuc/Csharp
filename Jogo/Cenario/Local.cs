public class Local
{
    //atributos privados
    private int quantidadeJogadores;
    private string? nome;
    private bool npc;
    private bool monstros;
    private bool pontoDescanso;
    private string? chefe;

    //atributos publicos
    public bool pacifico;
    public string? descricao;

    //encapsulamentos dos atributos privados
    public int QuantidadeJogadores { get => quantidadeJogadores; set => quantidadeJogadores = value; }
    public string? Nome { get => nome; set => nome = value; }
    public bool Npc { get => npc; set => npc = value; }
    public bool Monstros { get => monstros; set => monstros = value; }
    public bool PontoDescanso { get => pontoDescanso; set => pontoDescanso = value; }
    public string? Chefe { get => chefe; set => chefe = value; }


    //construtor para Taverna
    public Local(int quantidadeJogadores, string? nome)
    {
        this.QuantidadeJogadores = quantidadeJogadores;
        this.Nome = nome;
    }

    //construtor para Floresta
    public Local(int quantidadeJogadores, string? nome, bool npc, bool monstros)
    {
        this.QuantidadeJogadores = quantidadeJogadores;
        this.Nome = nome;
        this.Npc = npc;
        this.Monstros = monstros;
    }

    //construtor para ponto de Descanso
    public Local(int quantidadeJogadores, string? nome, bool pontoDescanso)
    {
        this.QuantidadeJogadores = quantidadeJogadores;
        this.Nome = nome;
        this.PontoDescanso = pontoDescanso;
    }

    //construtor para Masmorra
    public Local(bool monstros, string? nome, string? chefe,int quantidadeJogadores)
    {
        this.monstros = monstros;
        this.nome = nome;
        this.Chefe = chefe;
        this.quantidadeJogadores = quantidadeJogadores;
    }

}