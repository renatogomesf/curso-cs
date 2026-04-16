
// aula53 - excecoes(try catch finally) P2

namespace aula53;

public class Aula53
{
    public static void Main()
    {
        int n1, n2, res;

        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 10;

        try
        {
            res = n1 / n2;
            Console.WriteLine(res);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(Area.quad(10, 10));

            Console.WriteLine(Area.quad(0, 10)); // Isso vai lançar uma exceção, pois a base é zero

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"ERRROOO: {e.Message}");
            Console.WriteLine($"ERRROOO: {e.GetType()}");
        }
        finally // sempre executa, independente de ter ocorrido ou não uma exceção
        {
            Console.WriteLine("Bloco finally executado.");
        }
    }
}

public class Area
{
    public static float quad(float bas, float alt)
    {
        if (bas == 0 || alt == 0 || bas <= 0 || alt <= 0)
        {
            // Lançar uma exceção personalizada para indicar que a base e a altura devem ser maiores que zero.
            throw new Exception("Base e altura devem ser maiores que zero.");
        }

        return bas * alt;
    }
}