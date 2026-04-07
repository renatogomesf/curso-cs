
namespace aula35;

public class Aula35
{
    public static void Main()
    {
        Carro c1 = new Carro("Celta", "Branco", 4);

        Console.WriteLine($"Nome.......: {c1.nome}");
        Console.WriteLine($"Cor........: {c1.cor}");
        Console.WriteLine($"Rodas......: {c1.getRodas()}");
        Console.WriteLine($"VelMax.....: {c1.velMax}");
        Console.WriteLine($"Ligado.....: {c1.getLigado()}\n");

        CarroCombate cc1 = new CarroCombate("Tanque", "Verde", 6, 100);

        Console.WriteLine($"Nome.......: {cc1.nome}");
        Console.WriteLine($"Cor........: {cc1.cor}");
        Console.WriteLine($"Rodas......: {cc1.getRodas()}");
        Console.WriteLine($"VelMax.....: {cc1.velMax}");
        Console.WriteLine($"Ligado.....: {cc1.getLigado()}");
        Console.WriteLine($"Munição....: {cc1.municao}");
    }
}


public class Veiculo // Classe base ou superclasse
{
    public int velMax;
    private bool ligado;
    private int rodas;

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }

    public void ligar()
    {
        ligado = true;
    }

    public void desligar()
    {
        ligado = false;
    }

    public bool getLigado()
    {
        return ligado;
    }

    public int getRodas()
    {
        return rodas;
    }

}


public class Carro : Veiculo
{
    public string nome;
    public string cor;

    // Construtor da classe Carro que chama o construtor da classe Veiculo usando a sintaxe "base()" para inicializar a propriedade rodas.
    public Carro(string nome, string cor, int rodas) : base(rodas)
    {
        desligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

// Cadeia de herança: CarroCombate herda de Carro, que herda de Veiculo. Portanto, CarroCombate tem acesso a todas as propriedades e métodos de Carro e Veiculo.
public class CarroCombate : Carro
{
    public int municao;

    public CarroCombate(string nome, string cor, int rodas, int municao) : base(nome, cor, rodas)
    {
        this.municao = municao;
    }
}