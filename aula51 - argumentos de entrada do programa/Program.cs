
namespace aula51;

public class Aula51
{
    // Argumenntos de entrada do programa: são os valores passados para o programa quando ele é executado.
    // com o programa já compilado, basta chamar o nome do arquivo no terminal e, em seguida, os argumentos separados por espaço (cada separação por espaço é um argumento novo). Exemplo: "aula51.exe CFB Cursos"
    // string[] args: é um array de strings que recebe os argumentos de entrada do programa.
    public static void Main(string[] args)
    {

        if (args.Length > 0)
        {
            Console.WriteLine($"Argumentos passados: {args.Length}");

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("não foram passados argumentos");
        }

        Console.ReadLine();
    }
}