namespace aula08;

public class Aula08
{
    public static void Main()
    {
        int v1, v2, soma;
        string nome;


        Console.Write("digite seu nome: ");
        nome = Console.ReadLine(); // lê uma linha de texto do console e retorna como string

        // "int.Parse": Convertendo a string lida para um inteiro
        Console.Write("digite valor 1: ");
        v1 = int.Parse(Console.ReadLine());

        // "Convert.ToInt32": Outra forma de converter a string lida para um inteiro
        Console.Write("digite valor 2: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma = v1 + v2;

        Console.WriteLine("nome: {0}", nome);
        Console.WriteLine("soma: {0}", soma);

    }
}