
namespace aula42;

public class Aula42
{
    public static void Main()
    {

        Carro c1 = new Carro();

        // com o indexador, posso usar a instancia do objeto como se fosse um array, e acessar os elementos do array velMax.
        c1[4] = 200;
        Console.WriteLine($"Velocidade: {c1[4]}");

    }
}

public class Carro
{
    private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };

    public Carro()
    {

    }

    // O indexador é um recurso que permite acessar os elementos de uma classe ou estrutura como se fosse um array. Ele é definido usando a palavra-chave this seguida de um índice entre colchetes ([]). O indexador pode ser usado para acessar os elementos de uma coleção, como um array ou uma lista, ou para acessar os membros de uma classe ou estrutura de forma mais conveniente.
    public int this[int i]
    {
        get
        {
            return this.velMax[i];
        }

        set
        {
            if (value > 0 && value <= 300)
            {
                this.velMax[i] = value;
            }
            else
            {
                this.velMax[i] = 0;
            }
        }
    }
}