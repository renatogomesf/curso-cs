
namespace aula43;

public class Aula43
{
    public static void Main()
    {
        Carro c1 = new Carro();
    }
}

// Interface é um contrato que define um conjunto somente de métodos que uma classe deve implementar. Ela é usada para definir um comportamento comum para um grupo de classes, sem se preocupar com a implementação específica de cada classe. Uma interface pode ser implementada por várias classes, e uma classe pode implementar várias interfaces.
// Toda classe que implementa uma interface deve fornecer uma implementação para todos os métodos definidos na interface.
public interface Veiculo
{
    public void ligar();

    public void desligar();

    public void info();
}

public interface Combate
{
    public void disparar();
}

public class Carro : Veiculo, Combate
{

    public bool ligado;
    private int municao;

    public Carro()
    {
        this.municao = 100;
    }

    public void ligar()
    {
        this.ligado = true;
        Console.WriteLine("Carro ligado");
    }

    public void desligar()
    {
        this.ligado = false;
        Console.WriteLine("Carro desligado");
    }

    public void info()
    {
        Console.WriteLine("Informações do carro");
    }

    public void disparar()
    {
        Console.WriteLine("Carro disparando");
    }
}