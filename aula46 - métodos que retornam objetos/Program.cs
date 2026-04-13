
namespace aula46;

public class Aula46
{
    public static void Main()
    {
        Galinha g1 = new Galinha("Galinha Pintadinha");
        Galinha g2 = new Galinha("Galinha Preta");
        Galinha g3 = new Galinha("Galinha Branca");

        g1.botarOvo();
        g1.botarOvo();

        g2.botarOvo();
        g3.botarOvo();
    }
}

public class Galinha
{
    private string nomeGalinha;
    private int numOvo;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    // método que retorna um objeto do tipo Ovo. método tipado como "Ovo".
    public Ovo botarOvo()
    {
        numOvo++; // incrementa o número do ovo para a galinha

        // toda vez que o método botarOvo for chamado, uma instância do objeto Ovo será criada e retornada.
        return new Ovo(numOvo, nomeGalinha);
    }
}

public class Ovo
{
    private int numOvo;
    private string nomeGalinha;

    public Ovo(int numOvo, string nomeGalinha)
    {
        this.numOvo = numOvo;
        this.nomeGalinha = nomeGalinha;
        Console.WriteLine($"Ovo criado!\nqtde de ovos: {this.numOvo}\nnome galinha: {this.nomeGalinha}");
        Console.WriteLine("---------------------------------------------------------------\n");
    }
}