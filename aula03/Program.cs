
namespace aula03;

public class MyClass
{
    public static void Main()
    {
        byte n1 = 10; // 0 e 255
        int num = 10;
        char letra = 'a';
        float valor = 5.3f;
        string nome = "bruno";

        var aux = 10; // O compilador irá inferir o tipo da variável, nesse caso, int

        Console.WriteLine("valor de var: " + aux);

        int num1, num2, resultado;
        
        int num3 = 10, num4 = 10, resultado2;

        num1 = 10;
        num2 = 10;
        resultado = num1 * num2;
        Console.WriteLine("valor de resultado: " + resultado);
    }
}
