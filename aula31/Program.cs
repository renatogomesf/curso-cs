
namespace aula31;

public class Aula31
{
    public static void Main()
    {
        // Para acessar os membros de uma classe estática, basta usar o nome da classe seguido do operador de acesso a membro (.) e o nome do membro. Por exemplo, para acessar a propriedade energia da classe Jogador, você pode usar Jogador.energia. Para chamar o método info().
        Jogador.iniciar("Rafael");
        Jogador.info();

        Inimigo i1 = new Inimigo("Zumbi");
        Inimigo i2 = new Inimigo("Vampiro");
        Inimigo i3 = new Inimigo("Lobisomem");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();

    }
}

// Classes static não podem ser instanciadas, ou seja, não podem criar objetos a partir delas e não possuem construtores. Elas são usadas para agrupar métodos e propriedades que não dependem de uma instância específica da classe. Por exemplo, a classe Math em C# é uma classe estática que fornece métodos para operações matemáticas, como Math.Sqrt() para calcular a raiz quadrada. Já as classes normais podem ser instanciadas e possuem construtores para inicializar os objetos criados a partir delas.
public static class Jogador
{
    public static int energia;
    public static bool vivo;
    public static string nome;

    public static void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public static void info()
    {
        Console.WriteLine($"Nome......: {nome}");
        Console.WriteLine($"Energia...: {energia}");
        Console.WriteLine($"Vivo......: {vivo}\n");
    }
}

public class Inimigo
{
    public static bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine($"Nome......: {nome}");
        Console.WriteLine($"Alerta....: {alerta}\n");
    }

    
}