
namespace aula34;

public class Aula34
{
    public static void Main()
    {
        Carro c1 = new Carro("Celta", "Branco");

        Console.WriteLine($"Nome.......: {c1.nome}");
        Console.WriteLine($"Cor........: {c1.cor}");
        Console.WriteLine($"Rodas......: {c1.velMax}");
        Console.WriteLine($"Ligado.....: {c1.getLigado()}");
    }
}


public class Veiculo // Classe base ou superclasse
{
    public int velMax;
    private bool ligado;
    protected int rodas;

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

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }
}

// Herança: A classe Carro herda os membros da classe Veiculo, ou seja, ela tem acesso às propriedades velMax e ligado, bem como aos métodos ligar() e desligar().
// Declaração de herança: A sintaxe para declarar que uma classe herda de outra é usando o símbolo de dois pontos (:) seguido do nome da classe base.
public class Carro:Veiculo
{
    public string nome;
    public string cor;

    public Carro(string nome, string cor)
    {
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}