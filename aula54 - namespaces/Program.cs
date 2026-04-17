// aula54 - namespaces

// namespace: controla o escopo de classes, métodos e outras estruturas em um programa (CRIA UM AGRUPAMENTO). Ele é usado para organizar o código e evitar conflitos de nomes entre diferentes partes do programa ou entre bibliotecas externas.
// exemplo: se eu criar um grupo de classes que realizando calculos matemáticos, eu posso colocar todas essas classes dentro de um namespace chamado "Matematica". Assim, quando eu quiser usar uma dessas classes, eu posso referenciá-la como "Matematica.ClasseX", evitando conflitos com outras classes que possam ter o mesmo nome em outros namespaces.
namespace Calc1
{
    public class Area
    {
        public static float quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0 || bas <= 0 || alt <= 0)
            {
                throw new Exception("Base e altura devem ser maiores que zero.");
            }

            return bas * alt;
        }
    }
}

// posso ter classes com nomes iguais em namespaces diferentes, e isso não causará conflitos, pois cada classe estará associada ao seu respectivo namespace.
namespace Calc2
{
    public class Area
    {
        public static float quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0 || bas <= 0 || alt <= 0)
            {
                throw new Exception("Base e altura devem ser maiores que zero.");
            }

            return bas * alt;
        }
    }
}

public class Aula54
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
            Console.WriteLine(Calc1.Area.quad(10, 10));

            Console.WriteLine(Calc1.Area.quad(0, 10));

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"ERRROOO: {e.Message}");
            Console.WriteLine($"ERRROOO: {e.GetType()}");
        }
        finally
        {
            Console.WriteLine("Bloco finally executado.");
        }
    }
}
