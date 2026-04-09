
namespace aula41;

public class Aula41
{
    public static void Main()
    {

        Carro c1 = new Carro();

        // ao atribuir o valor 200 para a propriedade vm, o método set é chamado e o valor 200 é passado para o parâmetro value do método set.
        c1.vm = 200;

        // só de acessar a propriedade vm, o método get é chamado e retorna o valor do campo privado velMax, que é 120.
        Console.WriteLine($"Velocidade: {c1.vm}");
    }
}

public class Carro
{
    private int velMax;

    public Carro()
    {
        this.velMax = 120;
    }

    // Propriedade especial que possui um método get e set para acessar o campo privado velMax
    public int vm
    {
        get
        {
            return this.velMax;
        }

        // quando fazemos "vm = 150", o valor 150 é passado para o parâmetro value do método set.
        set
        {
            if (value > 0 && value <= 300)
            {
                this.velMax = value;
            }
            else
            {
                this.velMax = 0;
            }
        }
    }
}