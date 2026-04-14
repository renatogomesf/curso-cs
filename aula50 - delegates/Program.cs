
namespace aula50;

public class Aula50
{
    public static void Main()
    {
        int res;

        // Declaração: variável do tipo delegate, que pode apontar para um método específico. O método deve ser compatível com a assinatura do delegate.
        Op d1 = new Op(Mat.soma);

        // Chamada: invocação do método apontado pelo delegate, passando os argumentos necessários. O resultado da operação é armazenado na variável res.
        res = d1(10, 50);

        Console.WriteLine($"Resultado da soma: {res}");

        // para mudar a referência do delegate, basta criar uma nova instância do delegate apontando para o novo método desejado sem tipar uma nova variável.
        d1 = new Op(Mat.mult);

        res = d1(10, 50);

        Console.WriteLine($"Resultado da multiplicação: {res}");
    }
}

// Delegate: tipo de referência que pode apontar para um método. os parâmetros e o tipo de retorno do método devem ser compatíveis com os do delegate.
delegate int Op(int a, int b);

public class Mat
{

    public static int soma(int a, int b)
    {
        return a + b;
    }

    public static int mult(int a, int b)
    {
        return a * b;
    }
}