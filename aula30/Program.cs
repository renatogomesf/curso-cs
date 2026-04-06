
namespace aula30;

public class Aula30
{
    public static void Main()
    {

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Theo", 100);
        Jogador j4 = new Jogador("Benegundes", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();


    }

}

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    // Sobrecarga de construtor
    public Jogador()
    {
        energia = 100;
        vivo = true;
        this.nome = "Jogador";
    }

    public Jogador(string nome)
    {
        energia = 100;
        vivo = true;
        this.nome = nome;
    }

    public Jogador(string nome, int energia)
    {
        energia = 100;
        vivo = true;
        this.nome = nome;
        this.energia = energia;
    }

    public Jogador(string nome, int energia, bool vivo)
    {
        energia = 100;
        vivo = true;
        this.nome = nome;
        this.energia = energia;
        this.vivo = vivo;
    }

    public void info()
    {
        Console.WriteLine($"Nome......: {nome}");
        Console.WriteLine($"Energia...: {energia}");
        Console.WriteLine($"Vivo......: {vivo}\n");
    }
}