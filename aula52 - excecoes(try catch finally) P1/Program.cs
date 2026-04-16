
// aula52 - excecoes(try catch finally) P1

namespace aula52;

public class Aula52
{
    public static void Main()
    {
        int n1, n2, res;

        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0;

        try
        {
            res = n1 / n2;
            Console.WriteLine(res);

        } // todas excecoes herdam da classe System.Exception
        catch (Exception e) // pode ser qualquer tipo de excecao, mas o mais recomendado é usar a classe mais especifica possivel
        {
            Console.WriteLine($"ERRROOO: {e.Message}");
            Console.WriteLine($"ERRROOO: {e.GetType()}");
        }

        Console.WriteLine("----------------------------------------------------------");

        try
        {
            res = n1 / n2;
            Console.WriteLine(res);

        } // executa o catch mais especifico, ou seja, o que tem a classe mais especifica, nesse caso, o DivideByZeroException
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"ERRROOO: {e}");
            Console.WriteLine($"ERRROOO: {e.Message}");
            Console.WriteLine($"ERRROOO: {e.GetType()}");
        }
    }
}